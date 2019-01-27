using DiscordRPC;
using DiscordRPC.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfficientLeveling
{

    public partial class Window : Form
    {
        private static Player player { get; set; }
        private static List<string> chosenAttributes { get; set; }

        public DiscordRpcClient client;

        //Called when your application first starts.
        //For example, just before your main loop, on OnEnable for unity.
        void Initialize()
        {
            /*
            Create a discord client
            NOTE: 	If you are using Unity3D, you must use the full constructor and define
                     the pipe connection as DiscordRPC.IO.NativeNamedPipeClient
            */
            client = new DiscordRpcClient("538566172270919710");

            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = "Oblivion",
                State = "No character chosen",
                Assets = new Assets()
                {
                    LargeImageKey = "largeimage",
                    LargeImageText = "Efficient Leveling",
                    SmallImageKey = "small"
                }
            });
        }

        //The main loop of your application, or some sort of timer. Literally the Update function in Unity3D
        void Update(string State)
        {
            //Invoke all the events, such as OnPresenceUpdate
            client.SetPresence(new RichPresence()
            {
                Details = "Oblivion",
                State = State,
                Assets = new Assets()
                {
                    LargeImageKey = "largeimage",
                    LargeImageText = "Efficient Leveling",
                    SmallImageKey = "small"
                }
            });
            client.Invoke();
        }

        public Window()
        {
            Initialize();
            InitializeComponent();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            client.Dispose();
            this.Close();
        }

        private void Reset()
        {
            Attributes.DataSource = null;
            CanLevelUp.ResetText();
            Skills.DataSource = null;
            ExpectedIncrease.Text = "";
            AttributesChosen.ResetText();
            AttributesChosen.DataSource = null;
            Level.ResetText();
            PlayerName.ResetText();
            Update("No Character Chosen");
            return;
        }

        private void ShowData()
        {
            if(player == null)
            {
                Reset();
                return;
            }
            SetExpectedIncrease();
            List<string> attributes = new List<string>();
            var expectedIncreases = new List<string>();
            foreach (var attribute in player.Attributes)
            {
                var modifier = "";
                if (attribute.ExpectedIncrease >= 0)
                    modifier = "+";
                else
                    modifier = "-";
                attributes.Add(attribute.Level + " " + attribute.Name);
                expectedIncreases.Add(modifier + attribute.ExpectedIncrease.ToString());
            }
            Attributes.DataSource = attributes;
            PlayerName.Text = player.Name;
            Level.Text = player.Level.ToString();
            ExpectedIncrease.DataSource = expectedIncreases;
            if (player.CanLevelUp)
                CanLevelUp.Text = "Level";
            else
                CanLevelUp.Text = "CantLevel";

            List<string> skills = new List<string>();
            foreach (var attribute in player.Attributes)
                foreach (var skill in attribute.Skills)
                {
                    {
                        var mod = "";
                        if (skill.IsMajor)
                            mod = "+";
                        skills.Add(skill.Level + " " + skill.Name + " " + mod + "\t(" + attribute.Name + ")");
                    }
                }
            MajorSkillIncreases.Text = player.MajorSkillIncreases + "/10";
            MinorSkillIncreases.Text = player.MinorSkillIncreases + "/20";


            List<string> attrChTxt = new List<string>();
            if (chosenAttributes == null)
                chosenAttributes = new List<string>();
            for (int i = 0; i < chosenAttributes.Count; i++)
                attrChTxt.Add(chosenAttributes.ElementAt(i));

            if(attrChTxt.Count > 0)
                AttributesChosen.DataSource = attrChTxt;

            Skills.DataSource = skills;
            Update(player.Name + " level " + player.Level);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Display the open file dialog and load the file that is selected
            // the window is implicitly displayed by the showDialog method
            // When the ok is selected, load what is selected into the picture loader
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Set(JsonConvert.DeserializeObject<Player>(File.ReadAllText((openFileDialog1.FileName))));
                ShowData();
            }
        }

        private void Set(Player newPlayer)
        {
            player = newPlayer;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the image when this button is pressed
            //pictureBox1.Image = null;
            player = null;
            Reset();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MajorSkillIncreases_Click(object sender, EventArgs e)
        {

        }

        private void SetExpectedIncrease()
        {


            foreach (var attribute in player.Attributes)
            {
                int sum = 0;
                foreach (var skill in attribute.Skills)
                {
                    sum += skill.IncreasesThisLevel;
                }
                if (sum == 0)
                    attribute.ExpectedIncrease = 1;
                else if (sum <= 4)
                    attribute.ExpectedIncrease = 2;
                else if (sum <= 7)
                    attribute.ExpectedIncrease = 3;
                else if (sum <= 9)
                    attribute.ExpectedIncrease = 4;
                else if (sum >= 10)
                    attribute.ExpectedIncrease = 5;
            }

        }


        private void LevelSkill_Click(object sender, EventArgs e)
        {
            if (player == null)
            {
                //MessageBox.Show("No skill selected");
                return;
            }
            foreach (var attribute in player.Attributes)
                foreach (var skill in attribute.Skills)
                {
                    if (Skills.SelectedItem.ToString().Contains(skill.Name))
                    {
                        skill.IncreasesThisLevel++;
                        attribute.SkillIncreases++;
                        skill.Level++;
                        if (skill.IsMajor)
                            player.MajorSkillIncreases++;
                        else
                            player.MinorSkillIncreases++;
                    }
                    
                }
            if (player.MajorSkillIncreases < 10)
                player.CanLevelUp = false;
            else
                player.CanLevelUp = true;
            SetExpectedIncrease();
            ShowData();
        }



        private void LevelUp_Click(object sender, EventArgs e)
        {
            //TODO Alter code to only level up selected attributes
            if(player == null)
                MessageBox.Show("No player data loaded");
            else if (!player.CanLevelUp)
                MessageBox.Show("Player cannot level up");
            else if(chosenAttributes.Count != 3)
            {
                MessageBox.Show("3 attributes not chosen");
                return;
            }
            else
            {
                foreach (var attribute in player.Attributes)
                {
                    foreach (var selectedAttribute in chosenAttributes)
                    {
                        if (selectedAttribute.ToString().Contains(attribute.Name))
                        {
                            attribute.Level += attribute.ExpectedIncrease;
                            attribute.ExpectedIncrease = 1;
                            foreach (var skill in attribute.Skills)
                            {
                                skill.IncreasesThisLevel = 0;
                            }
                        }
                    }
                }
                player.Level++;
                player.CanLevelUp = false;
                player.MajorSkillIncreases = 0;
                player.MinorSkillIncreases = 0;
            }

            ShowData();
        }

        private void saveStats_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            var outP = JsonConvert.SerializeObject(player);

            saveFileDialog.Filter = "json files (*.JSON)|*.json";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, outP);
            }
        }

        private void SelectAttribute_Click(object sender, EventArgs e)
        {
            bool alreadyExists = false;
            if (chosenAttributes == null)
                chosenAttributes = new List<string>();

            for (int i = 0; i < chosenAttributes.Count; i++)
                if (Attributes.SelectedItem.ToString().Contains(chosenAttributes.ElementAt(i)))
                {
                    alreadyExists = true;
                    break;
                }



            if (!alreadyExists && Attributes.SelectedItem != null)
                if (chosenAttributes.Count < 3)
                    chosenAttributes.Add(Attributes.SelectedItem.ToString().Split(' ')[1]);
                else {
                    chosenAttributes.RemoveAt(2);
                    chosenAttributes.Insert(0,Attributes.SelectedItem.ToString().Split(' ')[1]);
                }
            ShowData();
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }

        
    }
}

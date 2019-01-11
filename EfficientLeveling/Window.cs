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

        public Window()
        {
            InitializeComponent();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset()
        {
            Attributes.DataSource = null;
            CanLevelUp.ResetText();
            Skills.DataSource = null;
            ExpectedIncrease.Text = "";
            Level.ResetText();
            PlayerName.ResetText();

            return;
        }

        private void ShowData()
        {
            if(player == null)
            {
                Reset();
                return;
            }

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
                CanLevelUp.Text = "+++++++";
            else
                CanLevelUp.Text = "-------";

            List<string> skills = new List<string>();
            foreach (var attribute in player.Attributes)
                foreach (var skill in attribute.Skills)
                {
                    {
                        var mod = "";
                        if (skill.IsMajor)
                            mod = "+";
                        skills.Add(skill.Name + " " + skill.Level + " " + mod);
                    }
                }

            Skills.DataSource = skills;
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
                        {
                            player.MajorSkillIncreases++;
                        }
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
            else
            {
                foreach (var attribute in player.Attributes)
                {
                    attribute.Level += attribute.ExpectedIncrease;
                    attribute.ExpectedIncrease = 0;
                    foreach (var skill in attribute.Skills)
                    {
                        skill.IncreasesThisLevel = 0;
                    }
                }
                player.Level++;
                player.CanLevelUp = false;
                player.MajorSkillIncreases = 0;
            }

            ShowData();
        }
    }
}

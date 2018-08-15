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
        private Player player { get; set; }
        public Window()
        {
            InitializeComponent();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show(Player player)
        {
            if(player == null)
            {
                Attributes.ResetText();
                CanLevelUp.ResetText();
                ExpectedIncrease.Text = "";
                Level.ResetText();
                PlayerName.ResetText();
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
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Display the open file dialog and load the file that is selected
            // the window is implicitly displayed by the showDialog method
            // When the ok is selected, load what is selected into the picture loader
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                show(JsonConvert.DeserializeObject<Player>(File.ReadAllText((openFileDialog1.FileName))));
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the image when this button is pressed
            //pictureBox1.Image = null;
            player = null;
            show(player);
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box, 
            // change the PictureBox's
            // SizeMode property to "Stretch". If the user clears 
            // the check box, change it to "Normal".
            //if (checkBox1.Checked)
            //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //else
            //    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
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
    }
}

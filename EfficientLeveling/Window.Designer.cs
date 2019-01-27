namespace EfficientLeveling
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showPlayer = new System.Windows.Forms.Button();
            this.saveStats = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.Attributes = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayerName = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.MajorSkillIncreases = new System.Windows.Forms.Label();
            this.MinorSkillIncreases = new System.Windows.Forms.Label();
            this.ExpectedIncrease = new System.Windows.Forms.ListBox();
            this.CanLevelUp = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.AttributeHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Skills = new System.Windows.Forms.ListBox();
            this.AttributesChosen = new System.Windows.Forms.ListBox();
            this.LevelSkill = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.LevelUp = new System.Windows.Forms.Button();
            this.SelectAttribute = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.01087F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.89674F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.09239F));
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tableLayoutPanelMain.Controls.Add(this.Attributes, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanel3, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.ExpectedIncrease, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.CanLevelUp, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.LevelSkill, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanel5, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.264462F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.797101F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.43271F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.264462F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(736, 573);
            this.tableLayoutPanelMain.TabIndex = 0;
            this.tableLayoutPanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.showPlayer);
            this.flowLayoutPanel1.Controls.Add(this.saveStats);
            this.flowLayoutPanel1.Controls.Add(this.clearButton);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(282, 527);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(451, 43);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // showPlayer
            // 
            this.showPlayer.AutoSize = true;
            this.showPlayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.showPlayer.Location = new System.Drawing.Point(3, 3);
            this.showPlayer.Name = "showPlayer";
            this.showPlayer.Size = new System.Drawing.Size(94, 23);
            this.showPlayer.TabIndex = 0;
            this.showPlayer.Text = "Load stats";
            this.showPlayer.UseVisualStyleBackColor = true;
            this.showPlayer.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveStats
            // 
            this.saveStats.Location = new System.Drawing.Point(103, 3);
            this.saveStats.Name = "saveStats";
            this.saveStats.Size = new System.Drawing.Size(103, 23);
            this.saveStats.TabIndex = 4;
            this.saveStats.Text = "Save stats";
            this.saveStats.UseVisualStyleBackColor = true;
            this.saveStats.Click += new System.EventHandler(this.saveStats_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(212, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(79, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear stats";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(297, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Attributes
            // 
            this.Attributes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Attributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Attributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attributes.FormattingEnabled = true;
            this.Attributes.ItemHeight = 20;
            this.Attributes.Location = new System.Drawing.Point(3, 83);
            this.Attributes.Name = "Attributes";
            this.Attributes.Size = new System.Drawing.Size(156, 438);
            this.Attributes.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.PlayerName);
            this.flowLayoutPanel2.Controls.Add(this.Level);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 11);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(144, 25);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // PlayerName
            // 
            this.PlayerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(3, 0);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(68, 25);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.Text = "Name";
            // 
            // Level
            // 
            this.Level.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(77, 0);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(64, 25);
            this.Level.TabIndex = 1;
            this.Level.Text = "Level";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel3.Controls.Add(this.MajorSkillIncreases);
            this.flowLayoutPanel3.Controls.Add(this.MinorSkillIncreases);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(282, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(451, 41);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // MajorSkillIncreases
            // 
            this.MajorSkillIncreases.AutoSize = true;
            this.MajorSkillIncreases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorSkillIncreases.Location = new System.Drawing.Point(3, 0);
            this.MajorSkillIncreases.Name = "MajorSkillIncreases";
            this.MajorSkillIncreases.Size = new System.Drawing.Size(213, 25);
            this.MajorSkillIncreases.TabIndex = 0;
            this.MajorSkillIncreases.Text = "Major Increases ?/10";
            this.MajorSkillIncreases.Click += new System.EventHandler(this.MajorSkillIncreases_Click);
            // 
            // MinorSkillIncreases
            // 
            this.MinorSkillIncreases.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MinorSkillIncreases.AutoSize = true;
            this.MinorSkillIncreases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinorSkillIncreases.Location = new System.Drawing.Point(222, 0);
            this.MinorSkillIncreases.Name = "MinorSkillIncreases";
            this.MinorSkillIncreases.Size = new System.Drawing.Size(213, 25);
            this.MinorSkillIncreases.TabIndex = 1;
            this.MinorSkillIncreases.Text = "Minor Increases ?/20";
            // 
            // ExpectedIncrease
            // 
            this.ExpectedIncrease.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpectedIncrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpectedIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpectedIncrease.FormattingEnabled = true;
            this.ExpectedIncrease.ItemHeight = 20;
            this.ExpectedIncrease.Location = new System.Drawing.Point(165, 83);
            this.ExpectedIncrease.Name = "ExpectedIncrease";
            this.ExpectedIncrease.Size = new System.Drawing.Size(111, 438);
            this.ExpectedIncrease.TabIndex = 6;
            // 
            // CanLevelUp
            // 
            this.CanLevelUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CanLevelUp.AutoSize = true;
            this.CanLevelUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanLevelUp.Location = new System.Drawing.Point(165, 11);
            this.CanLevelUp.Name = "CanLevelUp";
            this.CanLevelUp.Size = new System.Drawing.Size(83, 24);
            this.CanLevelUp.TabIndex = 7;
            this.CanLevelUp.Text = "levelUp?";
            this.CanLevelUp.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.AttributeHeader);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 50);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(156, 27);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // AttributeHeader
            // 
            this.AttributeHeader.AutoSize = true;
            this.AttributeHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributeHeader.Location = new System.Drawing.Point(3, 0);
            this.AttributeHeader.Name = "AttributeHeader";
            this.AttributeHeader.Size = new System.Drawing.Size(87, 24);
            this.AttributeHeader.TabIndex = 0;
            this.AttributeHeader.Text = "Attributes";
            this.AttributeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.69911F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.30088F));
            this.tableLayoutPanel2.Controls.Add(this.Skills, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AttributesChosen, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(282, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(451, 438);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // Skills
            // 
            this.Skills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Skills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Skills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skills.FormattingEnabled = true;
            this.Skills.ItemHeight = 20;
            this.Skills.Location = new System.Drawing.Point(3, 3);
            this.Skills.Name = "Skills";
            this.Skills.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Skills.Size = new System.Drawing.Size(299, 432);
            this.Skills.TabIndex = 0;
            // 
            // AttributesChosen
            // 
            this.AttributesChosen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttributesChosen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttributesChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributesChosen.FormattingEnabled = true;
            this.AttributesChosen.ItemHeight = 20;
            this.AttributesChosen.Location = new System.Drawing.Point(308, 3);
            this.AttributesChosen.Name = "AttributesChosen";
            this.AttributesChosen.Size = new System.Drawing.Size(140, 432);
            this.AttributesChosen.TabIndex = 1;
            // 
            // LevelSkill
            // 
            this.LevelSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelSkill.Location = new System.Drawing.Point(165, 527);
            this.LevelSkill.Name = "LevelSkill";
            this.LevelSkill.Size = new System.Drawing.Size(111, 43);
            this.LevelSkill.TabIndex = 10;
            this.LevelSkill.Text = "Level Skill";
            this.LevelSkill.UseVisualStyleBackColor = true;
            this.LevelSkill.Click += new System.EventHandler(this.LevelSkill_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.LevelUp);
            this.flowLayoutPanel5.Controls.Add(this.SelectAttribute);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 527);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(156, 43);
            this.flowLayoutPanel5.TabIndex = 11;
            // 
            // LevelUp
            // 
            this.LevelUp.Location = new System.Drawing.Point(3, 3);
            this.LevelUp.Name = "LevelUp";
            this.LevelUp.Size = new System.Drawing.Size(68, 23);
            this.LevelUp.TabIndex = 0;
            this.LevelUp.Text = "Level Up";
            this.LevelUp.UseVisualStyleBackColor = true;
            this.LevelUp.Click += new System.EventHandler(this.LevelUp_Click);
            // 
            // SelectAttribute
            // 
            this.SelectAttribute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectAttribute.Location = new System.Drawing.Point(77, 3);
            this.SelectAttribute.Name = "SelectAttribute";
            this.SelectAttribute.Size = new System.Drawing.Size(67, 23);
            this.SelectAttribute.TabIndex = 1;
            this.SelectAttribute.Text = "Attribute";
            this.SelectAttribute.UseVisualStyleBackColor = true;
            this.SelectAttribute.Click += new System.EventHandler(this.SelectAttribute_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JSON Files (*.json)|*.json|All files (*.*)|*.*  ";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 573);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Window";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.Window_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showPlayer;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox Attributes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ListBox ExpectedIncrease;
        private System.Windows.Forms.Button saveStats;
        private System.Windows.Forms.Label MajorSkillIncreases;
        private System.Windows.Forms.Label CanLevelUp;
        private System.Windows.Forms.Label MinorSkillIncreases;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label AttributeHeader;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox Skills;
        private System.Windows.Forms.Button LevelSkill;
        private System.Windows.Forms.ListBox AttributesChosen;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button LevelUp;
        private System.Windows.Forms.Button SelectAttribute;
    }
}
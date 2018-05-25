namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Game_Manager game_manager;
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.goldLabel = new System.Windows.Forms.Label();
            this.fameLabel = new System.Windows.Forms.Label();
            this.beliefLabel = new System.Windows.Forms.Label();
            this.goldTextBox = new System.Windows.Forms.TextBox();
            this.fameTextBox = new System.Windows.Forms.TextBox();
            this.beliefTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.castleTab = new System.Windows.Forms.TabPage();
            this.beliefCounterLabel = new System.Windows.Forms.Label();
            this.getBeliefLabel = new System.Windows.Forms.Label();
            this.fameCounterLabel = new System.Windows.Forms.Label();
            this.getFameLabel = new System.Windows.Forms.Label();
            this.goldCounterLabel = new System.Windows.Forms.Label();
            this.getGoldLabel = new System.Windows.Forms.Label();
            this.beliefButton = new System.Windows.Forms.Button();
            this.fameButton = new System.Windows.Forms.Button();
            this.goldButton = new System.Windows.Forms.Button();
            this.studentTab = new System.Windows.Forms.TabPage();
            this.actionTab = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.game_manager = new Game_Manager();
            this.tabControl1.SuspendLayout();
            this.castleTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*  ";
            this.openFileDialog1.Title = "Seletc a picture file";
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.Location = new System.Drawing.Point(29, 20);
            this.goldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(29, 13);
            this.goldLabel.TabIndex = 0;
            this.goldLabel.Text = "Gold";
            // 
            // fameLabel
            // 
            this.fameLabel.AutoSize = true;
            this.fameLabel.Location = new System.Drawing.Point(29, 49);
            this.fameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fameLabel.Name = "fameLabel";
            this.fameLabel.Size = new System.Drawing.Size(33, 13);
            this.fameLabel.TabIndex = 1;
            this.fameLabel.Text = "Fame";
            this.fameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // beliefLabel
            // 
            this.beliefLabel.AutoSize = true;
            this.beliefLabel.Location = new System.Drawing.Point(29, 72);
            this.beliefLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.beliefLabel.Name = "beliefLabel";
            this.beliefLabel.Size = new System.Drawing.Size(33, 13);
            this.beliefLabel.TabIndex = 2;
            this.beliefLabel.Text = "Belief";
            this.beliefLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // goldTextBox
            // 
            this.goldTextBox.Location = new System.Drawing.Point(68, 18);
            this.goldTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.goldTextBox.Name = "goldTextBox";
            this.goldTextBox.Size = new System.Drawing.Size(76, 20);
            this.goldTextBox.TabIndex = 6;
            // 
            // fameTextBox
            // 
            this.fameTextBox.Location = new System.Drawing.Point(68, 46);
            this.fameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fameTextBox.Name = "fameTextBox";
            this.fameTextBox.Size = new System.Drawing.Size(76, 20);
            this.fameTextBox.TabIndex = 7;
            // 
            // beliefTextBox
            // 
            this.beliefTextBox.Location = new System.Drawing.Point(68, 70);
            this.beliefTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.beliefTextBox.Name = "beliefTextBox";
            this.beliefTextBox.Size = new System.Drawing.Size(76, 20);
            this.beliefTextBox.TabIndex = 8;
            this.beliefTextBox.TextChanged += new System.EventHandler(this.beliefTextBox_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(677, -168);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.castleTab);
            this.tabControl1.Controls.Add(this.studentTab);
            this.tabControl1.Controls.Add(this.actionTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 561);
            this.tabControl1.TabIndex = 10;
            // 
            // castleTab
            // 
            this.castleTab.Controls.Add(this.beliefCounterLabel);
            this.castleTab.Controls.Add(this.getBeliefLabel);
            this.castleTab.Controls.Add(this.fameCounterLabel);
            this.castleTab.Controls.Add(this.getFameLabel);
            this.castleTab.Controls.Add(this.goldCounterLabel);
            this.castleTab.Controls.Add(this.getGoldLabel);
            this.castleTab.Controls.Add(this.beliefButton);
            this.castleTab.Controls.Add(this.fameButton);
            this.castleTab.Controls.Add(this.goldButton);
            this.castleTab.Controls.Add(this.goldTextBox);
            this.castleTab.Controls.Add(this.textBox4);
            this.castleTab.Controls.Add(this.goldLabel);
            this.castleTab.Controls.Add(this.beliefTextBox);
            this.castleTab.Controls.Add(this.fameLabel);
            this.castleTab.Controls.Add(this.fameTextBox);
            this.castleTab.Controls.Add(this.beliefLabel);
            this.castleTab.Location = new System.Drawing.Point(4, 22);
            this.castleTab.Margin = new System.Windows.Forms.Padding(2);
            this.castleTab.Name = "castleTab";
            this.castleTab.Padding = new System.Windows.Forms.Padding(2);
            this.castleTab.Size = new System.Drawing.Size(773, 535);
            this.castleTab.TabIndex = 0;
            this.castleTab.Text = "Castle Tab";
            this.castleTab.UseVisualStyleBackColor = true;
            // 
            // beliefCounterLabel
            // 
            this.beliefCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.beliefCounterLabel.AutoSize = true;
            this.beliefCounterLabel.Location = new System.Drawing.Point(593, 81);
            this.beliefCounterLabel.Name = "beliefCounterLabel";
            this.beliefCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.beliefCounterLabel.TabIndex = 18;
            this.beliefCounterLabel.Text = "0";
            // 
            // getBeliefLabel
            // 
            this.getBeliefLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getBeliefLabel.AutoSize = true;
            this.getBeliefLabel.Location = new System.Drawing.Point(539, 81);
            this.getBeliefLabel.Name = "getBeliefLabel";
            this.getBeliefLabel.Size = new System.Drawing.Size(36, 13);
            this.getBeliefLabel.TabIndex = 17;
            this.getBeliefLabel.Text = "Belief:";
            // 
            // fameCounterLabel
            // 
            this.fameCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fameCounterLabel.AutoSize = true;
            this.fameCounterLabel.Location = new System.Drawing.Point(593, 53);
            this.fameCounterLabel.Name = "fameCounterLabel";
            this.fameCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.fameCounterLabel.TabIndex = 16;
            this.fameCounterLabel.Text = "0";
            // 
            // getFameLabel
            // 
            this.getFameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getFameLabel.AutoSize = true;
            this.getFameLabel.Location = new System.Drawing.Point(539, 53);
            this.getFameLabel.Name = "getFameLabel";
            this.getFameLabel.Size = new System.Drawing.Size(36, 13);
            this.getFameLabel.TabIndex = 15;
            this.getFameLabel.Text = "Fame:";
            // 
            // goldCounterLabel
            // 
            this.goldCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goldCounterLabel.AutoSize = true;
            this.goldCounterLabel.Location = new System.Drawing.Point(593, 25);
            this.goldCounterLabel.Name = "goldCounterLabel";
            this.goldCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.goldCounterLabel.TabIndex = 14;
            this.goldCounterLabel.Text = "0";
            // 
            // getGoldLabel
            // 
            this.getGoldLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getGoldLabel.AutoSize = true;
            this.getGoldLabel.Location = new System.Drawing.Point(539, 25);
            this.getGoldLabel.Name = "getGoldLabel";
            this.getGoldLabel.Size = new System.Drawing.Size(32, 13);
            this.getGoldLabel.TabIndex = 13;
            this.getGoldLabel.Text = "Gold:";
            // 
            // beliefButton
            // 
            this.beliefButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.beliefButton.Location = new System.Drawing.Point(458, 76);
            this.beliefButton.Margin = new System.Windows.Forms.Padding(2);
            this.beliefButton.Name = "beliefButton";
            this.beliefButton.Size = new System.Drawing.Size(62, 23);
            this.beliefButton.TabIndex = 12;
            this.beliefButton.Text = "Get Belief";
            this.beliefButton.UseVisualStyleBackColor = true;
            this.beliefButton.Click += new System.EventHandler(this.beliefButton_Click);
            // 
            // fameButton
            // 
            this.fameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fameButton.Location = new System.Drawing.Point(458, 49);
            this.fameButton.Margin = new System.Windows.Forms.Padding(2);
            this.fameButton.Name = "fameButton";
            this.fameButton.Size = new System.Drawing.Size(62, 23);
            this.fameButton.TabIndex = 11;
            this.fameButton.Text = "Get Fame";
            this.fameButton.UseVisualStyleBackColor = true;
            this.fameButton.Click += new System.EventHandler(this.fameButton_Click);
            // 
            // goldButton
            // 
            this.goldButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goldButton.Location = new System.Drawing.Point(458, 20);
            this.goldButton.Margin = new System.Windows.Forms.Padding(2);
            this.goldButton.Name = "goldButton";
            this.goldButton.Size = new System.Drawing.Size(62, 23);
            this.goldButton.TabIndex = 10;
            this.goldButton.Text = "Get Gold";
            this.goldButton.UseVisualStyleBackColor = true;
            this.goldButton.Click += new System.EventHandler(this.goldButton_Click);
            // 
            // studentTab
            // 
            this.studentTab.Location = new System.Drawing.Point(4, 22);
            this.studentTab.Margin = new System.Windows.Forms.Padding(2);
            this.studentTab.Name = "studentTab";
            this.studentTab.Padding = new System.Windows.Forms.Padding(2);
            this.studentTab.Size = new System.Drawing.Size(773, 535);
            this.studentTab.TabIndex = 1;
            this.studentTab.Text = "Student Tab";
            this.studentTab.UseVisualStyleBackColor = true;
            // 
            // actionTab
            // 
            this.actionTab.Location = new System.Drawing.Point(4, 22);
            this.actionTab.Margin = new System.Windows.Forms.Padding(2);
            this.actionTab.Name = "actionTab";
            this.actionTab.Padding = new System.Windows.Forms.Padding(2);
            this.actionTab.Size = new System.Drawing.Size(773, 535);
            this.actionTab.TabIndex = 2;
            this.actionTab.Text = "Action Tab";
            this.actionTab.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.castleTab.ResumeLayout(false);
            this.castleTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Label fameLabel;
        private System.Windows.Forms.Label beliefLabel;
        private System.Windows.Forms.TextBox goldTextBox;
        private System.Windows.Forms.TextBox fameTextBox;
        private System.Windows.Forms.TextBox beliefTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage castleTab;
        private System.Windows.Forms.TabPage studentTab;
        private System.Windows.Forms.TabPage actionTab;
        private System.Windows.Forms.Button beliefButton;
        private System.Windows.Forms.Button fameButton;
        private System.Windows.Forms.Button goldButton;
        private System.Windows.Forms.Label beliefCounterLabel;
        private System.Windows.Forms.Label getBeliefLabel;
        private System.Windows.Forms.Label fameCounterLabel;
        private System.Windows.Forms.Label getFameLabel;
        private System.Windows.Forms.Label goldCounterLabel;
        private System.Windows.Forms.Label getGoldLabel;
        private System.Windows.Forms.Timer timer1;
    }
}


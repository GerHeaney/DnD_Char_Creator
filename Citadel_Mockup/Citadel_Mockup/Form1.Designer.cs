namespace WindowsFormsApp1
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.goldLabel = new System.Windows.Forms.Label();
            this.fameLabel = new System.Windows.Forms.Label();
            this.beliefLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goldTextBox = new System.Windows.Forms.TextBox();
            this.fameTextBox = new System.Windows.Forms.TextBox();
            this.beliefTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.castleTab = new System.Windows.Forms.TabPage();
            this.studentTab = new System.Windows.Forms.TabPage();
            this.actionTab = new System.Windows.Forms.TabPage();
            this.goldButton = new System.Windows.Forms.Button();
            this.fameButton = new System.Windows.Forms.Button();
            this.beliefButton = new System.Windows.Forms.Button();
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
            this.goldLabel.Location = new System.Drawing.Point(39, 25);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(38, 17);
            this.goldLabel.TabIndex = 0;
            this.goldLabel.Text = "Gold";
            // 
            // fameLabel
            // 
            this.fameLabel.AutoSize = true;
            this.fameLabel.Location = new System.Drawing.Point(39, 60);
            this.fameLabel.Name = "fameLabel";
            this.fameLabel.Size = new System.Drawing.Size(43, 17);
            this.fameLabel.TabIndex = 1;
            this.fameLabel.Text = "Fame";
            this.fameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // beliefLabel
            // 
            this.beliefLabel.AutoSize = true;
            this.beliefLabel.Location = new System.Drawing.Point(39, 89);
            this.beliefLabel.Name = "beliefLabel";
            this.beliefLabel.Size = new System.Drawing.Size(43, 17);
            this.beliefLabel.TabIndex = 2;
            this.beliefLabel.Text = "Belief";
            this.beliefLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, -201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-48, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // goldTextBox
            // 
            this.goldTextBox.Location = new System.Drawing.Point(91, 22);
            this.goldTextBox.Name = "goldTextBox";
            this.goldTextBox.Size = new System.Drawing.Size(100, 22);
            this.goldTextBox.TabIndex = 6;
            // 
            // fameTextBox
            // 
            this.fameTextBox.Location = new System.Drawing.Point(91, 57);
            this.fameTextBox.Name = "fameTextBox";
            this.fameTextBox.Size = new System.Drawing.Size(100, 22);
            this.fameTextBox.TabIndex = 7;
            // 
            // beliefTextBox
            // 
            this.beliefTextBox.Location = new System.Drawing.Point(91, 86);
            this.beliefTextBox.Name = "beliefTextBox";
            this.beliefTextBox.Size = new System.Drawing.Size(100, 22);
            this.beliefTextBox.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(634, -207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 540);
            this.tabControl1.TabIndex = 10;
            // 
            // castleTab
            // 
            this.castleTab.Controls.Add(this.beliefButton);
            this.castleTab.Controls.Add(this.fameButton);
            this.castleTab.Controls.Add(this.goldButton);
            this.castleTab.Controls.Add(this.goldTextBox);
            this.castleTab.Controls.Add(this.textBox4);
            this.castleTab.Controls.Add(this.goldLabel);
            this.castleTab.Controls.Add(this.label5);
            this.castleTab.Controls.Add(this.beliefTextBox);
            this.castleTab.Controls.Add(this.label4);
            this.castleTab.Controls.Add(this.fameLabel);
            this.castleTab.Controls.Add(this.fameTextBox);
            this.castleTab.Controls.Add(this.beliefLabel);
            this.castleTab.Location = new System.Drawing.Point(4, 25);
            this.castleTab.Name = "castleTab";
            this.castleTab.Padding = new System.Windows.Forms.Padding(3);
            this.castleTab.Size = new System.Drawing.Size(765, 511);
            this.castleTab.TabIndex = 0;
            this.castleTab.Text = "Castle Tab";
            this.castleTab.UseVisualStyleBackColor = true;
            // 
            // studentTab
            // 
            this.studentTab.Location = new System.Drawing.Point(4, 25);
            this.studentTab.Name = "studentTab";
            this.studentTab.Padding = new System.Windows.Forms.Padding(3);
            this.studentTab.Size = new System.Drawing.Size(765, 511);
            this.studentTab.TabIndex = 1;
            this.studentTab.Text = "Student Tab";
            this.studentTab.UseVisualStyleBackColor = true;
            // 
            // actionTab
            // 
            this.actionTab.Location = new System.Drawing.Point(4, 25);
            this.actionTab.Name = "actionTab";
            this.actionTab.Padding = new System.Windows.Forms.Padding(3);
            this.actionTab.Size = new System.Drawing.Size(765, 511);
            this.actionTab.TabIndex = 2;
            this.actionTab.Text = "Action Tab";
            this.actionTab.UseVisualStyleBackColor = true;
            // 
            // goldButton
            // 
            this.goldButton.Location = new System.Drawing.Point(495, 25);
            this.goldButton.Name = "goldButton";
            this.goldButton.Size = new System.Drawing.Size(82, 28);
            this.goldButton.TabIndex = 10;
            this.goldButton.Text = "Get Gold";
            this.goldButton.UseVisualStyleBackColor = true;
            // 
            // fameButton
            // 
            this.fameButton.Location = new System.Drawing.Point(495, 60);
            this.fameButton.Name = "fameButton";
            this.fameButton.Size = new System.Drawing.Size(82, 28);
            this.fameButton.TabIndex = 11;
            this.fameButton.Text = "Get Fame";
            this.fameButton.UseVisualStyleBackColor = true;
            // 
            // beliefButton
            // 
            this.beliefButton.Location = new System.Drawing.Point(495, 94);
            this.beliefButton.Name = "beliefButton";
            this.beliefButton.Size = new System.Drawing.Size(82, 28);
            this.beliefButton.TabIndex = 12;
            this.beliefButton.Text = "Get Belief";
            this.beliefButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.tabControl1);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
    }
}


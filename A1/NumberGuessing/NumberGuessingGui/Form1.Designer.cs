namespace NumberGuessingGui
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
            this.lowerLimitText = new System.Windows.Forms.TextBox();
            this.lowerLimitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upperLimitLabel = new System.Windows.Forms.TextBox();
            this.generateRandomNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.makeAGuessTextBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberIsLabel = new System.Windows.Forms.Label();
            this.limitInputErrorLimit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lowerLimitText
            // 
            this.lowerLimitText.Location = new System.Drawing.Point(124, 12);
            this.lowerLimitText.Name = "lowerLimitText";
            this.lowerLimitText.Size = new System.Drawing.Size(100, 20);
            this.lowerLimitText.TabIndex = 0;
            // 
            // lowerLimitLabel
            // 
            this.lowerLimitLabel.AutoSize = true;
            this.lowerLimitLabel.Location = new System.Drawing.Point(56, 15);
            this.lowerLimitLabel.Name = "lowerLimitLabel";
            this.lowerLimitLabel.Size = new System.Drawing.Size(60, 13);
            this.lowerLimitLabel.TabIndex = 1;
            this.lowerLimitLabel.Text = "Lower Limit";
            this.lowerLimitLabel.Click += new System.EventHandler(this.lowerLimitLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upper Limit";
            // 
            // upperLimitLabel
            // 
            this.upperLimitLabel.Location = new System.Drawing.Point(319, 18);
            this.upperLimitLabel.Name = "upperLimitLabel";
            this.upperLimitLabel.Size = new System.Drawing.Size(100, 20);
            this.upperLimitLabel.TabIndex = 3;
            // 
            // generateRandomNumber
            // 
            this.generateRandomNumber.Location = new System.Drawing.Point(446, 14);
            this.generateRandomNumber.Name = "generateRandomNumber";
            this.generateRandomNumber.Size = new System.Drawing.Size(246, 23);
            this.generateRandomNumber.TabIndex = 4;
            this.generateRandomNumber.Text = "Generate Random Number";
            this.generateRandomNumber.UseVisualStyleBackColor = true;
            this.generateRandomNumber.Click += new System.EventHandler(this.generateRandomNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "make a guess";
            // 
            // makeAGuessTextBox
            // 
            this.makeAGuessTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.makeAGuessTextBox.Location = new System.Drawing.Point(124, 67);
            this.makeAGuessTextBox.Name = "makeAGuessTextBox";
            this.makeAGuessTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.makeAGuessTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeAGuessTextBox.TabIndex = 6;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(255, 63);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Attempts";
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Location = new System.Drawing.Point(408, 73);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(10, 13);
            this.attemptsLabel.TabIndex = 9;
            this.attemptsLabel.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "The number is";
            // 
            // numberIsLabel
            // 
            this.numberIsLabel.AutoSize = true;
            this.numberIsLabel.Location = new System.Drawing.Point(506, 73);
            this.numberIsLabel.Name = "numberIsLabel";
            this.numberIsLabel.Size = new System.Drawing.Size(10, 13);
            this.numberIsLabel.TabIndex = 11;
            this.numberIsLabel.Text = "-";
            // 
            // limitInputErrorLimit
            // 
            this.limitInputErrorLimit.AutoSize = true;
            this.limitInputErrorLimit.Location = new System.Drawing.Point(446, 44);
            this.limitInputErrorLimit.Name = "limitInputErrorLimit";
            this.limitInputErrorLimit.Size = new System.Drawing.Size(10, 13);
            this.limitInputErrorLimit.TabIndex = 12;
            this.limitInputErrorLimit.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limitInputErrorLimit);
            this.Controls.Add(this.numberIsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.makeAGuessTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateRandomNumber);
            this.Controls.Add(this.upperLimitLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lowerLimitLabel);
            this.Controls.Add(this.lowerLimitText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lowerLimitText;
        private System.Windows.Forms.Label lowerLimitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox upperLimitLabel;
        private System.Windows.Forms.Button generateRandomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox makeAGuessTextBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numberIsLabel;
        private System.Windows.Forms.Label limitInputErrorLimit;
    }
}


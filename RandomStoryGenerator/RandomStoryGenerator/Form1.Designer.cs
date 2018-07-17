namespace RandomStoryGenerator
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
            this.WhenButton = new System.Windows.Forms.Button();
            this.WhoButton = new System.Windows.Forms.Button();
            this.WhatButton = new System.Windows.Forms.Button();
            this.WhyButton = new System.Windows.Forms.Button();
            this.WhereButton = new System.Windows.Forms.Button();
            this.EndingButton = new System.Windows.Forms.Button();
            this.whenBox = new System.Windows.Forms.TextBox();
            this.whereBox = new System.Windows.Forms.TextBox();
            this.whoBox = new System.Windows.Forms.TextBox();
            this.whatBox = new System.Windows.Forms.TextBox();
            this.whyBox = new System.Windows.Forms.TextBox();
            this.endingBox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhenButton
            // 
            this.WhenButton.Location = new System.Drawing.Point(59, 39);
            this.WhenButton.Name = "WhenButton";
            this.WhenButton.Size = new System.Drawing.Size(75, 23);
            this.WhenButton.TabIndex = 0;
            this.WhenButton.Text = "When?";
            this.WhenButton.UseVisualStyleBackColor = true;
            this.WhenButton.Click += new System.EventHandler(this.WhenButton_Click);
            // 
            // WhoButton
            // 
            this.WhoButton.Location = new System.Drawing.Point(59, 153);
            this.WhoButton.Name = "WhoButton";
            this.WhoButton.Size = new System.Drawing.Size(75, 23);
            this.WhoButton.TabIndex = 1;
            this.WhoButton.Text = "Who?";
            this.WhoButton.UseVisualStyleBackColor = true;
            this.WhoButton.Click += new System.EventHandler(this.WhoButton_Click);
            // 
            // WhatButton
            // 
            this.WhatButton.Location = new System.Drawing.Point(59, 220);
            this.WhatButton.Name = "WhatButton";
            this.WhatButton.Size = new System.Drawing.Size(75, 23);
            this.WhatButton.TabIndex = 2;
            this.WhatButton.Text = "What?";
            this.WhatButton.UseVisualStyleBackColor = true;
            this.WhatButton.Click += new System.EventHandler(this.WhatButton_Click);
            // 
            // WhyButton
            // 
            this.WhyButton.Location = new System.Drawing.Point(59, 291);
            this.WhyButton.Name = "WhyButton";
            this.WhyButton.Size = new System.Drawing.Size(75, 23);
            this.WhyButton.TabIndex = 3;
            this.WhyButton.Text = "Why?";
            this.WhyButton.UseVisualStyleBackColor = true;
            this.WhyButton.Click += new System.EventHandler(this.WhyButton_Click);
            // 
            // WhereButton
            // 
            this.WhereButton.Location = new System.Drawing.Point(59, 97);
            this.WhereButton.Name = "WhereButton";
            this.WhereButton.Size = new System.Drawing.Size(75, 23);
            this.WhereButton.TabIndex = 4;
            this.WhereButton.Text = "Where?";
            this.WhereButton.UseVisualStyleBackColor = true;
            this.WhereButton.Click += new System.EventHandler(this.WhereButton_Click);
            // 
            // EndingButton
            // 
            this.EndingButton.Location = new System.Drawing.Point(59, 369);
            this.EndingButton.Name = "EndingButton";
            this.EndingButton.Size = new System.Drawing.Size(75, 23);
            this.EndingButton.TabIndex = 5;
            this.EndingButton.Text = "Ending...";
            this.EndingButton.UseVisualStyleBackColor = true;
            this.EndingButton.Click += new System.EventHandler(this.EndingButton_Click);
            // 
            // whenBox
            // 
            this.whenBox.Location = new System.Drawing.Point(227, 39);
            this.whenBox.Multiline = true;
            this.whenBox.Name = "whenBox";
            this.whenBox.ReadOnly = true;
            this.whenBox.Size = new System.Drawing.Size(472, 40);
            this.whenBox.TabIndex = 6;
            // 
            // whereBox
            // 
            this.whereBox.Location = new System.Drawing.Point(227, 99);
            this.whereBox.Multiline = true;
            this.whereBox.Name = "whereBox";
            this.whereBox.ReadOnly = true;
            this.whereBox.Size = new System.Drawing.Size(472, 40);
            this.whereBox.TabIndex = 7;
            // 
            // whoBox
            // 
            this.whoBox.Location = new System.Drawing.Point(227, 155);
            this.whoBox.Multiline = true;
            this.whoBox.Name = "whoBox";
            this.whoBox.ReadOnly = true;
            this.whoBox.Size = new System.Drawing.Size(472, 40);
            this.whoBox.TabIndex = 8;
            // 
            // whatBox
            // 
            this.whatBox.Location = new System.Drawing.Point(227, 222);
            this.whatBox.Multiline = true;
            this.whatBox.Name = "whatBox";
            this.whatBox.ReadOnly = true;
            this.whatBox.Size = new System.Drawing.Size(472, 40);
            this.whatBox.TabIndex = 9;
            // 
            // whyBox
            // 
            this.whyBox.Location = new System.Drawing.Point(227, 291);
            this.whyBox.Multiline = true;
            this.whyBox.Name = "whyBox";
            this.whyBox.ReadOnly = true;
            this.whyBox.Size = new System.Drawing.Size(472, 40);
            this.whyBox.TabIndex = 10;
            // 
            // endingBox
            // 
            this.endingBox.Location = new System.Drawing.Point(227, 371);
            this.endingBox.Multiline = true;
            this.endingBox.Name = "endingBox";
            this.endingBox.ReadOnly = true;
            this.endingBox.Size = new System.Drawing.Size(472, 40);
            this.endingBox.TabIndex = 11;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(12, 415);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(183, 23);
            this.exportButton.TabIndex = 12;
            this.exportButton.Text = "Export Your Masterpiece!";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.endingBox);
            this.Controls.Add(this.whyBox);
            this.Controls.Add(this.whatBox);
            this.Controls.Add(this.whoBox);
            this.Controls.Add(this.whereBox);
            this.Controls.Add(this.whenBox);
            this.Controls.Add(this.EndingButton);
            this.Controls.Add(this.WhereButton);
            this.Controls.Add(this.WhyButton);
            this.Controls.Add(this.WhatButton);
            this.Controls.Add(this.WhoButton);
            this.Controls.Add(this.WhenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WhenButton;
        private System.Windows.Forms.Button WhoButton;
        private System.Windows.Forms.Button WhatButton;
        private System.Windows.Forms.Button WhyButton;
        private System.Windows.Forms.Button WhereButton;
        private System.Windows.Forms.Button EndingButton;
        private System.Windows.Forms.TextBox whenBox;
        private System.Windows.Forms.TextBox whereBox;
        private System.Windows.Forms.TextBox whoBox;
        private System.Windows.Forms.TextBox whatBox;
        private System.Windows.Forms.TextBox whyBox;
        private System.Windows.Forms.TextBox endingBox;
        private System.Windows.Forms.Button exportButton;
    }
}


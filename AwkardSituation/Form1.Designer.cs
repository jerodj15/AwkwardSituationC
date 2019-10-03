namespace AwkardSituation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.applauseButton = new System.Windows.Forms.Button();
            this.aweButton = new System.Windows.Forms.Button();
            this.censorButton = new System.Windows.Forms.Button();
            this.cricketsButton = new System.Windows.Forms.Button();
            this.dramaButton = new System.Windows.Forms.Button();
            this.jokeButton = new System.Windows.Forms.Button();
            this.sadButton = new System.Windows.Forms.Button();
            this.screamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Awkawrd Situation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "For those awkward moments in life";
            // 
            // applauseButton
            // 
            this.applauseButton.Location = new System.Drawing.Point(71, 211);
            this.applauseButton.Name = "applauseButton";
            this.applauseButton.Size = new System.Drawing.Size(284, 168);
            this.applauseButton.TabIndex = 2;
            this.applauseButton.Text = "Applause";
            this.applauseButton.UseVisualStyleBackColor = true;
            this.applauseButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // aweButton
            // 
            this.aweButton.Location = new System.Drawing.Point(71, 416);
            this.aweButton.Name = "aweButton";
            this.aweButton.Size = new System.Drawing.Size(284, 168);
            this.aweButton.TabIndex = 3;
            this.aweButton.Text = "Awe";
            this.aweButton.UseVisualStyleBackColor = true;
            this.aweButton.Click += new System.EventHandler(this.AweButton_Click);
            // 
            // censorButton
            // 
            this.censorButton.Location = new System.Drawing.Point(71, 626);
            this.censorButton.Name = "censorButton";
            this.censorButton.Size = new System.Drawing.Size(284, 168);
            this.censorButton.TabIndex = 4;
            this.censorButton.Text = "Censor Bleep";
            this.censorButton.UseVisualStyleBackColor = true;
            this.censorButton.Click += new System.EventHandler(this.CensorButton_Click);
            // 
            // cricketsButton
            // 
            this.cricketsButton.Location = new System.Drawing.Point(71, 845);
            this.cricketsButton.Name = "cricketsButton";
            this.cricketsButton.Size = new System.Drawing.Size(284, 168);
            this.cricketsButton.TabIndex = 5;
            this.cricketsButton.Text = "Crickets";
            this.cricketsButton.UseVisualStyleBackColor = true;
            this.cricketsButton.Click += new System.EventHandler(this.CricketsButton_Click);
            // 
            // dramaButton
            // 
            this.dramaButton.Location = new System.Drawing.Point(552, 211);
            this.dramaButton.Name = "dramaButton";
            this.dramaButton.Size = new System.Drawing.Size(284, 168);
            this.dramaButton.TabIndex = 6;
            this.dramaButton.Text = "Dramatic";
            this.dramaButton.UseVisualStyleBackColor = true;
            this.dramaButton.Click += new System.EventHandler(this.DramaButton_Click);
            // 
            // jokeButton
            // 
            this.jokeButton.Location = new System.Drawing.Point(552, 416);
            this.jokeButton.Name = "jokeButton";
            this.jokeButton.Size = new System.Drawing.Size(284, 168);
            this.jokeButton.TabIndex = 7;
            this.jokeButton.Text = "Joke Drum";
            this.jokeButton.UseVisualStyleBackColor = true;
            this.jokeButton.Click += new System.EventHandler(this.JokeButton_Click);
            // 
            // sadButton
            // 
            this.sadButton.Location = new System.Drawing.Point(552, 626);
            this.sadButton.Name = "sadButton";
            this.sadButton.Size = new System.Drawing.Size(284, 168);
            this.sadButton.TabIndex = 8;
            this.sadButton.Text = "Sad ";
            this.sadButton.UseVisualStyleBackColor = true;
            this.sadButton.Click += new System.EventHandler(this.SadButton_Click);
            // 
            // screamButton
            // 
            this.screamButton.Location = new System.Drawing.Point(552, 845);
            this.screamButton.Name = "screamButton";
            this.screamButton.Size = new System.Drawing.Size(284, 168);
            this.screamButton.TabIndex = 9;
            this.screamButton.Text = "Scream";
            this.screamButton.UseVisualStyleBackColor = true;
            this.screamButton.Click += new System.EventHandler(this.ScreamButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 1025);
            this.Controls.Add(this.screamButton);
            this.Controls.Add(this.sadButton);
            this.Controls.Add(this.jokeButton);
            this.Controls.Add(this.dramaButton);
            this.Controls.Add(this.cricketsButton);
            this.Controls.Add(this.censorButton);
            this.Controls.Add(this.aweButton);
            this.Controls.Add(this.applauseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applauseButton;
        private System.Windows.Forms.Button aweButton;
        private System.Windows.Forms.Button censorButton;
        private System.Windows.Forms.Button cricketsButton;
        private System.Windows.Forms.Button dramaButton;
        private System.Windows.Forms.Button jokeButton;
        private System.Windows.Forms.Button sadButton;
        private System.Windows.Forms.Button screamButton;
    }
}


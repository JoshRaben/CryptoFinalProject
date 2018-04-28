namespace CryptoFinalProject
{
    partial class Secret
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
            this.home = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.Label();
            this.discordInviteText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(353, 300);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Location = new System.Drawing.Point(226, 92);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(349, 26);
            this.infoText.TabIndex = 1;
            this.infoText.Text = "Congratulations on completing both Linear and Differential Cryptanalysis! \r\n     " +
    "                    As a reward here is a link to our Discord server! \r\n";
            // 
            // discordInviteText
            // 
            this.discordInviteText.AutoSize = true;
            this.discordInviteText.Location = new System.Drawing.Point(339, 196);
            this.discordInviteText.Name = "discordInviteText";
            this.discordInviteText.Size = new System.Drawing.Size(100, 13);
            this.discordInviteText.TabIndex = 2;
            this.discordInviteText.Text = "PUT INVITE HERE";
            // 
            // Secret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.discordInviteText);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.home);
            this.Name = "Secret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Label discordInviteText;
    }
}
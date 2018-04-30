﻿namespace CryptoFinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secret));
            this.home = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.Label();
            this.discordInviteText = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(190, 206);
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
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(12, 66);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(439, 48);
            this.infoText.TabIndex = 1;
            this.infoText.Text = resources.GetString("infoText.Text");
            // 
            // discordInviteText
            // 
            this.discordInviteText.AutoSize = true;
            this.discordInviteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordInviteText.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.discordInviteText.Location = new System.Drawing.Point(120, 148);
            this.discordInviteText.Name = "discordInviteText";
            this.discordInviteText.Size = new System.Drawing.Size(216, 18);
            this.discordInviteText.TabIndex = 3;
            this.discordInviteText.TabStop = true;
            this.discordInviteText.Text = "https://discord.gg/EtHhZdW";
            this.discordInviteText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discordInviteText_LinkClicked);
            // 
            // Secret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 276);
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
        private System.Windows.Forms.LinkLabel discordInviteText;
    }
}
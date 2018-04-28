﻿namespace CryptoFinalProject
{
    partial class LandingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.infoText = new System.Windows.Forms.Label();
            this.linear = new System.Windows.Forms.Button();
            this.differential = new System.Windows.Forms.Button();
            this.LinearKeyTxtBox = new System.Windows.Forms.TextBox();
            this.linearKeyText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiffKeyTxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(104, 92);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(575, 24);
            this.infoText.TabIndex = 2;
            this.infoText.Text = "Choose which Cryptanalysis method you wish to learn about.";
            // 
            // linear
            // 
            this.linear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linear.Location = new System.Drawing.Point(87, 207);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(151, 68);
            this.linear.TabIndex = 3;
            this.linear.TabStop = false;
            this.linear.Text = "Linear Cryptanalysis";
            this.linear.UseVisualStyleBackColor = true;
            this.linear.Click += new System.EventHandler(this.linear_Click);
            // 
            // differential
            // 
            this.differential.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differential.Location = new System.Drawing.Point(550, 207);
            this.differential.Name = "differential";
            this.differential.Size = new System.Drawing.Size(163, 68);
            this.differential.TabIndex = 4;
            this.differential.Text = "Differential Cryptanalysis";
            this.differential.UseVisualStyleBackColor = true;
            this.differential.Click += new System.EventHandler(this.differential_Click);
            // 
            // LinearKeyTxtBox
            // 
            this.LinearKeyTxtBox.Location = new System.Drawing.Point(108, 346);
            this.LinearKeyTxtBox.Name = "LinearKeyTxtBox";
            this.LinearKeyTxtBox.Size = new System.Drawing.Size(100, 20);
            this.LinearKeyTxtBox.TabIndex = 5;
            // 
            // linearKeyText
            // 
            this.linearKeyText.AutoSize = true;
            this.linearKeyText.Location = new System.Drawing.Point(12, 307);
            this.linearKeyText.Name = "linearKeyText";
            this.linearKeyText.Size = new System.Drawing.Size(311, 13);
            this.linearKeyText.TabIndex = 6;
            this.linearKeyText.Text = "Enter the Secret Key given upon completing Linear Cryptanalysis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter the Secret Key given upon completing Differential Cryptanalysis";
            // 
            // DiffKeyTxtBox
            // 
            this.DiffKeyTxtBox.Location = new System.Drawing.Point(579, 346);
            this.DiffKeyTxtBox.Name = "DiffKeyTxtBox";
            this.DiffKeyTxtBox.Size = new System.Drawing.Size(100, 20);
            this.DiffKeyTxtBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 148);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit Keys";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiffKeyTxtBox);
            this.Controls.Add(this.linearKeyText);
            this.Controls.Add(this.LinearKeyTxtBox);
            this.Controls.Add(this.differential);
            this.Controls.Add(this.linear);
            this.Controls.Add(this.infoText);
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button linear;
        private System.Windows.Forms.Button differential;
        private System.Windows.Forms.TextBox LinearKeyTxtBox;
        private System.Windows.Forms.Label linearKeyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiffKeyTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
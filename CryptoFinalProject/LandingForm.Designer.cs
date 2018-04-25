namespace CryptoFinalProject
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
            this.infoText = new System.Windows.Forms.Label();
            this.linear = new System.Windows.Forms.Button();
            this.differential = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(104, 61);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(575, 24);
            this.infoText.TabIndex = 2;
            this.infoText.Text = "Choose which Cryptanalysis method you wish to learn about.";
            // 
            // linear
            // 
            this.linear.Location = new System.Drawing.Point(108, 207);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(151, 68);
            this.linear.TabIndex = 3;
            this.linear.Text = "Linear Cryptanalysis";
            this.linear.UseVisualStyleBackColor = true;
            this.linear.Click += new System.EventHandler(this.linear_Click);
            // 
            // differential
            // 
            this.differential.Location = new System.Drawing.Point(516, 207);
            this.differential.Name = "differential";
            this.differential.Size = new System.Drawing.Size(163, 68);
            this.differential.TabIndex = 4;
            this.differential.Text = "Differential Cryptanalysis";
            this.differential.UseVisualStyleBackColor = true;
            this.differential.Click += new System.EventHandler(this.differential_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.differential);
            this.Controls.Add(this.linear);
            this.Controls.Add(this.infoText);
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button linear;
        private System.Windows.Forms.Button differential;
    }
}
namespace CryptoFinalProject
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
            this.differential = new System.Windows.Forms.Label();
            this.linear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // differential
            // 
            this.differential.AutoSize = true;
            this.differential.Location = new System.Drawing.Point(110, 93);
            this.differential.Name = "differential";
            this.differential.Size = new System.Drawing.Size(121, 13);
            this.differential.TabIndex = 0;
            this.differential.Text = "Differential Cryptanalysis";
            // 
            // linear
            // 
            this.linear.AutoSize = true;
            this.linear.Location = new System.Drawing.Point(557, 93);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(100, 13);
            this.linear.TabIndex = 1;
            this.linear.Text = "Linear Cryptanalysis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linear);
            this.Controls.Add(this.differential);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label differential;
        private System.Windows.Forms.Label linear;
    }
}


namespace CryptoFinalProject
{
    partial class LinearStep2
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
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(12, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(1078, 601);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 1;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(965, 601);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // LinearStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 636);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Controls.Add(this.home);
            this.Name = "LinearStep2";
            this.Text = "LinearStep2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
    }
}
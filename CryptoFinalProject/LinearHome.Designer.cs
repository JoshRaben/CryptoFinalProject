namespace CryptoFinalProject
{
    partial class LinearHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearHome));
            this.infoText1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoText2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoText1
            // 
            this.infoText1.AutoSize = true;
            this.infoText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText1.Location = new System.Drawing.Point(287, 167);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(576, 80);
            this.infoText1.TabIndex = 3;
            this.infoText1.Text = resources.GetString("infoText1.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CryptoFinalProject.Properties.Resources.Untitled_Diagram__1_;
            this.pictureBox2.Location = new System.Drawing.Point(153, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 62);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 548);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // infoText2
            // 
            this.infoText2.AutoSize = true;
            this.infoText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText2.Location = new System.Drawing.Point(287, 268);
            this.infoText2.Name = "infoText2";
            this.infoText2.Size = new System.Drawing.Size(587, 80);
            this.infoText2.TabIndex = 5;
            this.infoText2.Text = resources.GetString("infoText2.Text");
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(434, 55);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 37);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Your Mission";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(345, 432);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(123, 62);
            this.back.TabIndex = 8;
            this.back.Text = "Decline";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(624, 432);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(123, 62);
            this.next.TabIndex = 9;
            this.next.Text = "Accept";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // LinearHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 574);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.infoText2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.infoText1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LinearHome";
            this.Text = "Linear Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infoText1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label infoText2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
    }
}
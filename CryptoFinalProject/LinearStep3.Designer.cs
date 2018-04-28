namespace CryptoFinalProject
{
    partial class LinearStep3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearStep3));
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.submitAnsBtn = new System.Windows.Forms.Button();
            this.ansListBox1 = new System.Windows.Forms.CheckedListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoText1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.feebackTitle = new System.Windows.Forms.Label();
            this.feedbackText = new System.Windows.Forms.Label();
            this.infoText2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(836, 637);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(975, 637);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 3;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(12, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 5;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // submitAnsBtn
            // 
            this.submitAnsBtn.Location = new System.Drawing.Point(885, 243);
            this.submitAnsBtn.Name = "submitAnsBtn";
            this.submitAnsBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAnsBtn.TabIndex = 6;
            this.submitAnsBtn.Text = "Submit";
            this.submitAnsBtn.UseVisualStyleBackColor = true;
            this.submitAnsBtn.Click += new System.EventHandler(this.submitAnsBtn_Click);
            // 
            // ansListBox1
            // 
            this.ansListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansListBox1.FormattingEnabled = true;
            this.ansListBox1.Items.AddRange(new object[] {
            "Brute force K2 as previously running through every possible value using the masks" +
                ".",
            "Use the known ciphertext, the S-box, and M to calculate a guessed K2.",
            "Re-calculate the approximation table, except now using \'M\' as the plaintext.",
            "Send multiple strings through the S-Box to try to gain more information about it." +
                ""});
            this.ansListBox1.Location = new System.Drawing.Point(354, 149);
            this.ansListBox1.Name = "ansListBox1";
            this.ansListBox1.Size = new System.Drawing.Size(606, 88);
            this.ansListBox1.TabIndex = 7;
            this.ansListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ansListBox1_ItemCheck);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(603, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(112, 24);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Getting K2 ";
            // 
            // infoText1
            // 
            this.infoText1.AutoSize = true;
            this.infoText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText1.Location = new System.Drawing.Point(304, 70);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(840, 60);
            this.infoText1.TabIndex = 9;
            this.infoText1.Text = resources.GetString("infoText1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CryptoFinalProject.Properties.Resources.DESwithM;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 558);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // feebackTitle
            // 
            this.feebackTitle.AutoSize = true;
            this.feebackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feebackTitle.Location = new System.Drawing.Point(350, 302);
            this.feebackTitle.Name = "feebackTitle";
            this.feebackTitle.Size = new System.Drawing.Size(84, 20);
            this.feebackTitle.TabIndex = 11;
            this.feebackTitle.Text = "Feedback:";
            // 
            // feedbackText
            // 
            this.feedbackText.AutoSize = true;
            this.feedbackText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackText.Location = new System.Drawing.Point(440, 302);
            this.feedbackText.Name = "feedbackText";
            this.feedbackText.Size = new System.Drawing.Size(0, 20);
            this.feedbackText.TabIndex = 12;
            // 
            // infoText2
            // 
            this.infoText2.AutoSize = true;
            this.infoText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText2.Location = new System.Drawing.Point(350, 449);
            this.infoText2.Name = "infoText2";
            this.infoText2.Size = new System.Drawing.Size(0, 20);
            this.infoText2.TabIndex = 13;
            // 
            // LinearStep3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 672);
            this.Controls.Add(this.infoText2);
            this.Controls.Add(this.feedbackText);
            this.Controls.Add(this.feebackTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.infoText1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.ansListBox1);
            this.Controls.Add(this.submitAnsBtn);
            this.Controls.Add(this.home);
            this.Controls.Add(this.back);
            this.Controls.Add(this.next);
            this.Name = "LinearStep3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinearStep3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button submitAnsBtn;
        private System.Windows.Forms.CheckedListBox ansListBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label infoText1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label feebackTitle;
        private System.Windows.Forms.Label feedbackText;
        private System.Windows.Forms.Label infoText2;
    }
}
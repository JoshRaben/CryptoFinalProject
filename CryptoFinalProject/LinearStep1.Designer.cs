namespace CryptoFinalProject
{
    partial class LinearStep1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearStep1));
            this.infoText1 = new System.Windows.Forms.Label();
            this.ansListBox1 = new System.Windows.Forms.CheckedListBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.submitAnsBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.infoText2 = new System.Windows.Forms.Label();
            this.tableCreation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.feedbackTitle = new System.Windows.Forms.Label();
            this.feedbackText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoText1
            // 
            this.infoText1.AutoSize = true;
            this.infoText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText1.Location = new System.Drawing.Point(272, 315);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(260, 32);
            this.infoText1.TabIndex = 3;
            this.infoText1.Text = "Which (Output, Input) mask pair out of the\r\nfollowing is the most promising? (Pic" +
    "k One)";
            // 
            // ansListBox1
            // 
            this.ansListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansListBox1.FormattingEnabled = true;
            this.ansListBox1.Items.AddRange(new object[] {
            "(6, 3)   ->   5",
            "(6, 5)   ->   6",
            "(4, 4)   ->   9",
            "(3, 2)   ->   6",
            "(1, 3)   ->   6",
            "(2, 2)   ->   1"});
            this.ansListBox1.Location = new System.Drawing.Point(415, 358);
            this.ansListBox1.Name = "ansListBox1";
            this.ansListBox1.Size = new System.Drawing.Size(117, 106);
            this.ansListBox1.TabIndex = 4;
            this.ansListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ansListBox1_ItemCheck);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(894, 588);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // submitAnsBtn
            // 
            this.submitAnsBtn.Location = new System.Drawing.Point(457, 475);
            this.submitAnsBtn.Name = "submitAnsBtn";
            this.submitAnsBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAnsBtn.TabIndex = 6;
            this.submitAnsBtn.Text = "Submit";
            this.submitAnsBtn.UseVisualStyleBackColor = true;
            this.submitAnsBtn.Click += new System.EventHandler(this.submitAnsBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(794, 588);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(12, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 23);
            this.homeBtn.TabIndex = 8;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // infoText2
            // 
            this.infoText2.AutoSize = true;
            this.infoText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText2.Location = new System.Drawing.Point(18, 49);
            this.infoText2.Name = "infoText2";
            this.infoText2.Size = new System.Drawing.Size(1000, 160);
            this.infoText2.TabIndex = 9;
            this.infoText2.Text = resources.GetString("infoText2.Text");
            // 
            // tableCreation
            // 
            this.tableCreation.Location = new System.Drawing.Point(115, 475);
            this.tableCreation.Name = "tableCreation";
            this.tableCreation.Size = new System.Drawing.Size(137, 23);
            this.tableCreation.TabIndex = 10;
            this.tableCreation.Text = "More on table creation...";
            this.tableCreation.UseVisualStyleBackColor = true;
            this.tableCreation.Click += new System.EventHandler(this.tableCreation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 230);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(377, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(219, 24);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Linear Approximations";
            // 
            // feedbackTitle
            // 
            this.feedbackTitle.AutoSize = true;
            this.feedbackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackTitle.Location = new System.Drawing.Point(585, 331);
            this.feedbackTitle.Name = "feedbackTitle";
            this.feedbackTitle.Size = new System.Drawing.Size(73, 16);
            this.feedbackTitle.TabIndex = 12;
            this.feedbackTitle.Text = "Feedback:";
            // 
            // feedbackText
            // 
            this.feedbackText.AutoSize = true;
            this.feedbackText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackText.Location = new System.Drawing.Point(664, 331);
            this.feedbackText.Name = "feedbackText";
            this.feedbackText.Size = new System.Drawing.Size(0, 16);
            this.feedbackText.TabIndex = 13;
            // 
            // LinearStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 631);
            this.Controls.Add(this.feedbackText);
            this.Controls.Add(this.feedbackTitle);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.tableCreation);
            this.Controls.Add(this.infoText2);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitAnsBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.ansListBox1);
            this.Controls.Add(this.infoText1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LinearStep1";
            this.Text = "Step 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infoText1;
        private System.Windows.Forms.CheckedListBox ansListBox1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button submitAnsBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label infoText2;
        private System.Windows.Forms.Button tableCreation;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label feedbackTitle;
        private System.Windows.Forms.Label feedbackText;
    }
}
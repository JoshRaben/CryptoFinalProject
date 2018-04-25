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
            this.answerBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoText1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.submitAnsBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.infoText2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(153, 543);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(132, 20);
            this.answerBox.TabIndex = 0;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(28, 543);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(119, 13);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.Text = "Enter your answer here:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 331);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // infoText1
            // 
            this.infoText1.AutoSize = true;
            this.infoText1.Location = new System.Drawing.Point(416, 252);
            this.infoText1.Name = "infoText1";
            this.infoText1.Size = new System.Drawing.Size(349, 26);
            this.infoText1.TabIndex = 3;
            this.infoText1.Text = "Display optimal input/output mask values from table displayed to the left. \r\nAlso" +
    " explain where this table comes from and it\'s signifigance.";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3",
            "item4",
            "item5"});
            this.checkedListBox1.Location = new System.Drawing.Point(419, 332);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 4;
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
            this.submitAnsBtn.Location = new System.Drawing.Point(464, 444);
            this.submitAnsBtn.Name = "submitAnsBtn";
            this.submitAnsBtn.Size = new System.Drawing.Size(75, 23);
            this.submitAnsBtn.TabIndex = 6;
            this.submitAnsBtn.Text = "Submit";
            this.submitAnsBtn.UseVisualStyleBackColor = true;
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
            this.infoText2.Location = new System.Drawing.Point(18, 47);
            this.infoText2.Name = "infoText2";
            this.infoText2.Size = new System.Drawing.Size(951, 117);
            this.infoText2.TabIndex = 9;
            this.infoText2.Text = resources.GetString("infoText2.Text");
            // 
            // LinearStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 623);
            this.Controls.Add(this.infoText2);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitAnsBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.infoText1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.answerBox);
            this.Name = "LinearStep1";
            this.Text = "Step 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label infoText1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button submitAnsBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label infoText2;
    }
}
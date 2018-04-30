namespace CryptoFinalProject
{
    partial class DiffStep2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiffStep2));
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.prevStepBtn = new System.Windows.Forms.Button();
            this.nextStepBtn = new System.Windows.Forms.Button();
            this.K1GuessPicBox = new System.Windows.Forms.PictureBox();
            this.titleText = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.stepsCompleteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.K1GuessPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(978, 600);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(1078, 600);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Location = new System.Drawing.Point(12, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 23);
            this.homeBtn.TabIndex = 12;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // prevStepBtn
            // 
            this.prevStepBtn.Location = new System.Drawing.Point(610, 507);
            this.prevStepBtn.Name = "prevStepBtn";
            this.prevStepBtn.Size = new System.Drawing.Size(75, 23);
            this.prevStepBtn.TabIndex = 17;
            this.prevStepBtn.Text = "Prev. Step";
            this.prevStepBtn.UseVisualStyleBackColor = true;
            this.prevStepBtn.Click += new System.EventHandler(this.prevStepBtn_Click);
            // 
            // nextStepBtn
            // 
            this.nextStepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextStepBtn.Location = new System.Drawing.Point(748, 507);
            this.nextStepBtn.Name = "nextStepBtn";
            this.nextStepBtn.Size = new System.Drawing.Size(75, 23);
            this.nextStepBtn.TabIndex = 16;
            this.nextStepBtn.Text = "Next Step";
            this.nextStepBtn.UseVisualStyleBackColor = true;
            this.nextStepBtn.Click += new System.EventHandler(this.nextStepBtn_Click);
            // 
            // K1GuessPicBox
            // 
            this.K1GuessPicBox.Image = ((System.Drawing.Image)(resources.GetObject("K1GuessPicBox.Image")));
            this.K1GuessPicBox.Location = new System.Drawing.Point(12, 55);
            this.K1GuessPicBox.Name = "K1GuessPicBox";
            this.K1GuessPicBox.Size = new System.Drawing.Size(811, 568);
            this.K1GuessPicBox.TabIndex = 15;
            this.K1GuessPicBox.TabStop = false;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(454, 27);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(278, 25);
            this.titleText.TabIndex = 14;
            this.titleText.Text = "Chosen Plain Text Attack";
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(829, 71);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(330, 176);
            this.infoText.TabIndex = 18;
            this.infoText.Text = resources.GetString("infoText.Text");
            // 
            // stepsCompleteLabel
            // 
            this.stepsCompleteLabel.AutoSize = true;
            this.stepsCompleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsCompleteLabel.Location = new System.Drawing.Point(829, 291);
            this.stepsCompleteLabel.Name = "stepsCompleteLabel";
            this.stepsCompleteLabel.Size = new System.Drawing.Size(0, 16);
            this.stepsCompleteLabel.TabIndex = 19;
            // 
            // DiffStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 635);
            this.Controls.Add(this.stepsCompleteLabel);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.prevStepBtn);
            this.Controls.Add(this.nextStepBtn);
            this.Controls.Add(this.K1GuessPicBox);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Name = "DiffStep2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiffStep2";
            ((System.ComponentModel.ISupportInitialize)(this.K1GuessPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button prevStepBtn;
        private System.Windows.Forms.Button nextStepBtn;
        private System.Windows.Forms.PictureBox K1GuessPicBox;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Label stepsCompleteLabel;
    }
}
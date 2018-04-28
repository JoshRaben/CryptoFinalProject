namespace CryptoFinalProject
{
    partial class LinearStep4
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
            this.keyClaimBtn = new System.Windows.Forms.Button();
            this.keyString = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyClaimBtn
            // 
            this.keyClaimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyClaimBtn.Location = new System.Drawing.Point(234, 268);
            this.keyClaimBtn.Name = "keyClaimBtn";
            this.keyClaimBtn.Size = new System.Drawing.Size(108, 49);
            this.keyClaimBtn.TabIndex = 0;
            this.keyClaimBtn.Text = "Return to Home";
            this.keyClaimBtn.UseVisualStyleBackColor = true;
            this.keyClaimBtn.Click += new System.EventHandler(this.keyClaimBtn_Click);
            // 
            // keyString
            // 
            this.keyString.AutoSize = true;
            this.keyString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyString.Location = new System.Drawing.Point(256, 195);
            this.keyString.Name = "keyString";
            this.keyString.Size = new System.Drawing.Size(66, 18);
            this.keyString.TabIndex = 2;
            this.keyString.Text = "m@yB3";
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(66, 46);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(0, 20);
            this.infoText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Key:";
            // 
            // LinearStep4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.keyString);
            this.Controls.Add(this.keyClaimBtn);
            this.Name = "LinearStep4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinearStep4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button keyClaimBtn;
        private System.Windows.Forms.Label keyString;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Label label1;
    }
}
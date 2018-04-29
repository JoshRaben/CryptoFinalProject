namespace CryptoFinalProject
{
    partial class DiffStep4
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
            this.label1 = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.keyString = new System.Windows.Forms.Label();
            this.keyClaimBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Key:";
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(30, 67);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(0, 20);
            this.infoText.TabIndex = 7;
            // 
            // keyString
            // 
            this.keyString.AutoSize = true;
            this.keyString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyString.Location = new System.Drawing.Point(241, 136);
            this.keyString.Name = "keyString";
            this.keyString.Size = new System.Drawing.Size(70, 18);
            this.keyString.TabIndex = 6;
            this.keyString.Text = "Ca11m3";
            // 
            // keyClaimBtn
            // 
            this.keyClaimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyClaimBtn.Location = new System.Drawing.Point(203, 215);
            this.keyClaimBtn.Name = "keyClaimBtn";
            this.keyClaimBtn.Size = new System.Drawing.Size(108, 49);
            this.keyClaimBtn.TabIndex = 5;
            this.keyClaimBtn.Text = "Return to Home";
            this.keyClaimBtn.UseVisualStyleBackColor = true;
            this.keyClaimBtn.Click += new System.EventHandler(this.keyClaimBtn_Click);
            // 
            // DiffStep4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.keyString);
            this.Controls.Add(this.keyClaimBtn);
            this.Name = "DiffStep4";
            this.Text = "DiffStep4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Label keyString;
        private System.Windows.Forms.Button keyClaimBtn;
    }
}
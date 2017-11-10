namespace ATM
{
    partial class FormNhanh2
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
            this.lblNhanh2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNhanh2
            // 
            this.lblNhanh2.AutoSize = true;
            this.lblNhanh2.Location = new System.Drawing.Point(195, 106);
            this.lblNhanh2.Name = "lblNhanh2";
            this.lblNhanh2.Size = new System.Drawing.Size(102, 13);
            this.lblNhanh2.TabIndex = 0;
            this.lblNhanh2.Text = "Day la form nhanh 2";
            // 
            // FormNhanh2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 328);
            this.Controls.Add(this.lblNhanh2);
            this.Name = "FormNhanh2";
            this.Text = "FormNhanh2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhanh2;
    }
}
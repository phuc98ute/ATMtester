namespace ATM
{
    partial class FormNhnh1
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
            this.lblNhanh1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNhanh1
            // 
            this.lblNhanh1.AutoSize = true;
            this.lblNhanh1.Location = new System.Drawing.Point(80, 100);
            this.lblNhanh1.Name = "lblNhanh1";
            this.lblNhanh1.Size = new System.Drawing.Size(107, 13);
            this.lblNhanh1.TabIndex = 0;
            this.lblNhanh1.Text = "Day la nhanh 1 Phuc";
            this.lblNhanh1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormNhnh1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 262);
            this.Controls.Add(this.lblNhanh1);
            this.Name = "FormNhnh1";
            this.Text = "FormNhnh1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhanh1;
    }
}
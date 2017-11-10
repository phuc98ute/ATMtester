namespace ATM
{
    partial class Form1
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
            this.btnNhanh1 = new System.Windows.Forms.Button();
            this.btnNhanh2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhanh1
            // 
            this.btnNhanh1.Location = new System.Drawing.Point(27, 144);
            this.btnNhanh1.Name = "btnNhanh1";
            this.btnNhanh1.Size = new System.Drawing.Size(75, 23);
            this.btnNhanh1.TabIndex = 0;
            this.btnNhanh1.Text = "Nhanh1";
            this.btnNhanh1.UseVisualStyleBackColor = true;
            this.btnNhanh1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNhanh2
            // 
            this.btnNhanh2.Location = new System.Drawing.Point(280, 144);
            this.btnNhanh2.Name = "btnNhanh2";
            this.btnNhanh2.Size = new System.Drawing.Size(75, 23);
            this.btnNhanh2.TabIndex = 1;
            this.btnNhanh2.Text = "Nhanh 2";
            this.btnNhanh2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 337);
            this.Controls.Add(this.btnNhanh2);
            this.Controls.Add(this.btnNhanh1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhanh1;
        private System.Windows.Forms.Button btnNhanh2;
    }
}


namespace _2212390_DNTKhanh_48
{
    partial class fComboBox
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
            this.lblNgonNgu = new System.Windows.Forms.Label();
            this.lblComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblNgonNgu
            // 
            this.lblNgonNgu.AutoSize = true;
            this.lblNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgonNgu.Location = new System.Drawing.Point(65, 35);
            this.lblNgonNgu.Name = "lblNgonNgu";
            this.lblNgonNgu.Size = new System.Drawing.Size(146, 24);
            this.lblNgonNgu.TabIndex = 0;
            this.lblNgonNgu.Text = "Chọn ngoại ngữ";
            // 
            // lblComboBox
            // 
            this.lblComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lblComboBox.Cursor = System.Windows.Forms.Cursors.No;
            this.lblComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboBox.FormattingEnabled = true;
            this.lblComboBox.Location = new System.Drawing.Point(265, 35);
            this.lblComboBox.Name = "lblComboBox";
            this.lblComboBox.Size = new System.Drawing.Size(121, 32);
            this.lblComboBox.TabIndex = 1;
            this.lblComboBox.SelectedIndexChanged += new System.EventHandler(this.lblComboBox_SelectedIndexChanged);
            // 
            // fComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 213);
            this.Controls.Add(this.lblComboBox);
            this.Controls.Add(this.lblNgonNgu);
            this.Name = "fComboBox";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.fComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgonNgu;
        private System.Windows.Forms.ComboBox lblComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


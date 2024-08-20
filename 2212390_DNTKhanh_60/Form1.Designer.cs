namespace _2212390_DNTKhanh_60
{
    partial class CheckListBox
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
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.ImeMode = System.Windows.Forms.ImeMode.On;
            this.clbMonHoc.Items.AddRange(new object[] {
            "Bóng rổ",
            "Bóng Bàn",
            "Cầu Lông",
            "Đá Banh",
            "Trượt Ván",
            "Pickleball",
            "Bơi",
            "Võ"});
            this.clbMonHoc.Location = new System.Drawing.Point(66, 56);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(143, 124);
            this.clbMonHoc.TabIndex = 0;
            this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.clbMonHoc_SelectedIndexChanged);
            // 
            // CheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 225);
            this.Controls.Add(this.clbMonHoc);
            this.Name = "CheckListBox";
            this.Text = "CheckListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbMonHoc;
    }
}


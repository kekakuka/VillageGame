namespace Village
{
    partial class ViewForm3
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
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "All Buildings",
            "All Castles",
            "All Storages",
            "All Trainings"});
            this.cbSelect.Location = new System.Drawing.Point(188, 549);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(551, 23);
            this.cbSelect.TabIndex = 0;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDrawOn.Location = new System.Drawing.Point(29, 32);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(917, 480);
            this.pnlDrawOn.TabIndex = 20;
            // 
            // ViewForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.Controls.Add(this.pnlDrawOn);
            this.Controls.Add(this.cbSelect);
            this.Name = "ViewForm3";
            this.Text = "ViewForm3";
            this.Load += new System.EventHandler(this.ViewForm3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Panel pnlDrawOn;
    }
}
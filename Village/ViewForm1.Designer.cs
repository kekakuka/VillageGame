namespace Village
{
    partial class ViewForm1
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
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.lstBuildings = new System.Windows.Forms.ListBox();
            this.rbCastle = new System.Windows.Forms.RadioButton();
            this.rbStorage = new System.Windows.Forms.RadioButton();
            this.rbTraining = new System.Windows.Forms.RadioButton();
            this.tbCastle = new System.Windows.Forms.TrackBar();
            this.cbStorage = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTraining = new System.Windows.Forms.NumericUpDown();
            this.txtX = new System.Windows.Forms.NumericUpDown();
            this.txtY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDrawOn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCastle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDrawOn.Controls.Add(this.lstBuildings);
            this.pnlDrawOn.Location = new System.Drawing.Point(41, 31);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(917, 460);
            this.pnlDrawOn.TabIndex = 0;
            // 
            // lstBuildings
            // 
            this.lstBuildings.FormattingEnabled = true;
            this.lstBuildings.ItemHeight = 15;
            this.lstBuildings.Location = new System.Drawing.Point(4, 3);
            this.lstBuildings.Name = "lstBuildings";
            this.lstBuildings.Size = new System.Drawing.Size(910, 439);
            this.lstBuildings.TabIndex = 0;
            this.lstBuildings.SelectedIndexChanged += new System.EventHandler(this.lstBuildings_SelectedIndexChanged);
            // 
            // rbCastle
            // 
            this.rbCastle.AutoSize = true;
            this.rbCastle.Checked = true;
            this.rbCastle.Location = new System.Drawing.Point(23, 508);
            this.rbCastle.Name = "rbCastle";
            this.rbCastle.Size = new System.Drawing.Size(76, 19);
            this.rbCastle.TabIndex = 2;
            this.rbCastle.TabStop = true;
            this.rbCastle.Text = "Castle";
            this.rbCastle.UseVisualStyleBackColor = true;
            this.rbCastle.CheckedChanged += new System.EventHandler(this.rbCastle_CheckedChanged);
            // 
            // rbStorage
            // 
            this.rbStorage.AutoSize = true;
            this.rbStorage.Location = new System.Drawing.Point(23, 575);
            this.rbStorage.Name = "rbStorage";
            this.rbStorage.Size = new System.Drawing.Size(84, 19);
            this.rbStorage.TabIndex = 3;
            this.rbStorage.Text = "Storage";
            this.rbStorage.UseVisualStyleBackColor = true;
            this.rbStorage.CheckedChanged += new System.EventHandler(this.rbStorage_CheckedChanged);
            // 
            // rbTraining
            // 
            this.rbTraining.AutoSize = true;
            this.rbTraining.Location = new System.Drawing.Point(23, 641);
            this.rbTraining.Name = "rbTraining";
            this.rbTraining.Size = new System.Drawing.Size(84, 19);
            this.rbTraining.TabIndex = 4;
            this.rbTraining.Text = "Traning";
            this.rbTraining.UseVisualStyleBackColor = true;
            this.rbTraining.CheckedChanged += new System.EventHandler(this.rbTraining_CheckedChanged);
            // 
            // tbCastle
            // 
            this.tbCastle.Location = new System.Drawing.Point(135, 508);
            this.tbCastle.Name = "tbCastle";
            this.tbCastle.Size = new System.Drawing.Size(151, 56);
            this.tbCastle.TabIndex = 6;
            // 
            // cbStorage
            // 
            this.cbStorage.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbStorage.DisplayMember = "Level 1";
            this.cbStorage.FormattingEnabled = true;
            this.cbStorage.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3"});
            this.cbStorage.Location = new System.Drawing.Point(135, 574);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(151, 23);
            this.cbStorage.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(766, 508);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 37);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Building";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(766, 575);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(139, 37);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Modify Building";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(766, 641);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 37);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Building";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTraining
            // 
            this.txtTraining.Location = new System.Drawing.Point(135, 641);
            this.txtTraining.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtTraining.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtTraining.Name = "txtTraining";
            this.txtTraining.Size = new System.Drawing.Size(151, 25);
            this.txtTraining.TabIndex = 12;
            this.txtTraining.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(477, 573);
            this.txtX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(120, 25);
            this.txtX.TabIndex = 13;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(477, 641);
            this.txtY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(120, 25);
            this.txtY.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 641);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Y";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPosition.Location = new System.Drawing.Point(413, 517);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(179, 19);
            this.lbPosition.TabIndex = 17;
            this.lbPosition.Text = "Building Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(292, 645);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "50-200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(603, 645);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "0-300";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(603, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "0-500";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "dat";
            this.saveFileDialog1.FileName = "village";
            this.saveFileDialog1.Filter = "\"Dat files (*.dat)|*.dat|All files (*.*)|*.*\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "dat";
            this.openFileDialog1.FileName = "village";
            this.openFileDialog1.Filter = "\"Dat files (*.dat)|*.dat|All files (*.*)|*.*\"";
            this.openFileDialog1.FilterIndex = 0;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(63, 24);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(124, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // ViewForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 696);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtTraining);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbStorage);
            this.Controls.Add(this.tbCastle);
            this.Controls.Add(this.rbTraining);
            this.Controls.Add(this.rbStorage);
            this.Controls.Add(this.rbCastle);
            this.Controls.Add(this.pnlDrawOn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewForm1";
            this.Text = "ViewForm1";
            this.Load += new System.EventHandler(this.ViewForm1_Load);
            this.pnlDrawOn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCastle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtY)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.RadioButton rbCastle;
        private System.Windows.Forms.RadioButton rbStorage;
        private System.Windows.Forms.RadioButton rbTraining;
        private System.Windows.Forms.TrackBar tbCastle;
        private System.Windows.Forms.ComboBox cbStorage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown txtTraining;
        private System.Windows.Forms.NumericUpDown txtX;
        private System.Windows.Forms.NumericUpDown txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBuildings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}
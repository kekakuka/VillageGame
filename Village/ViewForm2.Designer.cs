namespace Village
{
    partial class ViewForm2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm2));
            this.label3 = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.NumericUpDown();
            this.txtX = new System.Windows.Forms.NumericUpDown();
            this.txtTraining = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbStorage = new System.Windows.Forms.ComboBox();
            this.tbCastle = new System.Windows.Forms.TrackBar();
            this.rbTraining = new System.Windows.Forms.RadioButton();
            this.rbStorage = new System.Windows.Forms.RadioButton();
            this.rbCastle = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmReDrawn = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eixtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtGame = new System.Windows.Forms.TextBox();
            this.lblBuildingInfo = new System.Windows.Forms.Label();
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCastle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(310, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "50-200";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPosition.Location = new System.Drawing.Point(424, 525);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(179, 19);
            this.lbPosition.TabIndex = 33;
            this.lbPosition.Text = "Building Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "X";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(488, 649);
            this.txtY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(120, 25);
            this.txtY.TabIndex = 30;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(488, 581);
            this.txtX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(120, 25);
            this.txtX.TabIndex = 29;
            // 
            // txtTraining
            // 
            this.txtTraining.Location = new System.Drawing.Point(153, 649);
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
            this.txtTraining.TabIndex = 28;
            this.txtTraining.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(733, 649);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 37);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete Building";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(733, 583);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(139, 37);
            this.btnModify.TabIndex = 26;
            this.btnModify.Text = "Modify Building";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(733, 516);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 37);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add Building";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.cbStorage.Location = new System.Drawing.Point(153, 582);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(151, 23);
            this.cbStorage.TabIndex = 24;
            // 
            // tbCastle
            // 
            this.tbCastle.Location = new System.Drawing.Point(153, 516);
            this.tbCastle.Name = "tbCastle";
            this.tbCastle.Size = new System.Drawing.Size(151, 56);
            this.tbCastle.TabIndex = 23;
            // 
            // rbTraining
            // 
            this.rbTraining.AutoSize = true;
            this.rbTraining.Location = new System.Drawing.Point(41, 649);
            this.rbTraining.Name = "rbTraining";
            this.rbTraining.Size = new System.Drawing.Size(84, 19);
            this.rbTraining.TabIndex = 22;
            this.rbTraining.TabStop = true;
            this.rbTraining.Text = "Traning";
            this.rbTraining.UseVisualStyleBackColor = true;
            this.rbTraining.CheckedChanged += new System.EventHandler(this.rbTraining_CheckedChanged);
            // 
            // rbStorage
            // 
            this.rbStorage.AutoSize = true;
            this.rbStorage.Location = new System.Drawing.Point(41, 583);
            this.rbStorage.Name = "rbStorage";
            this.rbStorage.Size = new System.Drawing.Size(84, 19);
            this.rbStorage.TabIndex = 21;
            this.rbStorage.TabStop = true;
            this.rbStorage.Text = "Storage";
            this.rbStorage.UseVisualStyleBackColor = true;
            this.rbStorage.CheckedChanged += new System.EventHandler(this.rbStorage_CheckedChanged);
            // 
            // rbCastle
            // 
            this.rbCastle.AutoSize = true;
            this.rbCastle.Location = new System.Drawing.Point(41, 516);
            this.rbCastle.Name = "rbCastle";
            this.rbCastle.Size = new System.Drawing.Size(76, 19);
            this.rbCastle.TabIndex = 20;
            this.rbCastle.TabStop = true;
            this.rbCastle.Text = "Castle";
            this.rbCastle.UseVisualStyleBackColor = true;
            this.rbCastle.CheckedChanged += new System.EventHandler(this.rbCastle_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(614, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "0-500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(614, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "0-300";
            // 
            // tmReDrawn
            // 
            this.tmReDrawn.Enabled = true;
            this.tmReDrawn.Interval = 5000;
            this.tmReDrawn.Tick += new System.EventHandler(this.tmReDrawn_Tick);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1378, 28);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.eixtToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // eixtToolStripMenuItem
            // 
            this.eixtToolStripMenuItem.Name = "eixtToolStripMenuItem";
            this.eixtToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.eixtToolStripMenuItem.Text = "Eixt";
            this.eixtToolStripMenuItem.Click += new System.EventHandler(this.eixtToolStripMenuItem_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(908, 41);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(406, 65);
            this.btnPlay.TabIndex = 40;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtGame
            // 
            this.txtGame.Enabled = false;
            this.txtGame.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGame.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtGame.Location = new System.Drawing.Point(908, 142);
            this.txtGame.Multiline = true;
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(458, 456);
            this.txtGame.TabIndex = 41;
            this.txtGame.Text = resources.GetString("txtGame.Text");
            // 
            // lblBuildingInfo
            // 
            this.lblBuildingInfo.AutoSize = true;
            this.lblBuildingInfo.Location = new System.Drawing.Point(905, 624);
            this.lblBuildingInfo.Name = "lblBuildingInfo";
            this.lblBuildingInfo.Size = new System.Drawing.Size(0, 15);
            this.lblBuildingInfo.TabIndex = 42;
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDrawOn.Location = new System.Drawing.Point(41, 31);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(831, 466);
            this.pnlDrawOn.TabIndex = 19;
            this.pnlDrawOn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn_MouseDown);
            this.pnlDrawOn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn_MouseMove);
            this.pnlDrawOn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn_MouseUp);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(1214, 642);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(139, 37);
            this.btnEnd.TabIndex = 43;
            this.btnEnd.Text = "End Game";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // ViewForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 711);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.lblBuildingInfo);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.btnPlay);
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
            this.Name = "ViewForm2";
            this.Text = "ViewForm2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewForm2_FormClosing);
            this.Load += new System.EventHandler(this.ViewForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCastle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtY;
        private System.Windows.Forms.NumericUpDown txtX;
        private System.Windows.Forms.NumericUpDown txtTraining;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbStorage;
        private System.Windows.Forms.TrackBar tbCastle;
        private System.Windows.Forms.RadioButton rbTraining;
        private System.Windows.Forms.RadioButton rbStorage;
        private System.Windows.Forms.RadioButton rbCastle;
        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmReDrawn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eixtToolStripMenuItem;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.Label lblBuildingInfo;
        private System.Windows.Forms.Button btnEnd;
    }
}
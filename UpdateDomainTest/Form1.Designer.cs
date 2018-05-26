namespace UpdateDomainTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.butSelectFile = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.opFile = new System.Windows.Forms.OpenFileDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.butSetup2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clucbSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cluFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cluVer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cluCreaateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folderBrows = new System.Windows.Forms.FolderBrowserDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbExcludeFolder = new System.Windows.Forms.CheckBox();
            this.lbExcludeList = new System.Windows.Forms.ListBox();
            this.cMenExclude = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel6.SuspendLayout();
            this.cMenExclude.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 412);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.butSelectFile);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 46);
            this.panel4.TabIndex = 0;
            // 
            // butSelectFile
            // 
            this.butSelectFile.Location = new System.Drawing.Point(507, 12);
            this.butSelectFile.Name = "butSelectFile";
            this.butSelectFile.Size = new System.Drawing.Size(75, 23);
            this.butSelectFile.TabIndex = 1;
            this.butSelectFile.Text = "Brown";
            this.butSelectFile.UseVisualStyleBackColor = true;
            this.butSelectFile.Click += new System.EventHandler(this.butSelectFile_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(16, 10);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(379, 25);
            this.tbFile.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(588, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 412);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clucbSelect,
            this.cluFileName,
            this.cluVer,
            this.cluCreaateTime});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(588, 366);
            this.dataGridView1.TabIndex = 1;
            // 
            // opFile
            // 
            this.opFile.FileName = "openFileDialog1";
            this.opFile.Multiselect = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.butSetup2);
            this.panel5.Controls.Add(this.tbFile);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(701, 48);
            this.panel5.TabIndex = 0;
            // 
            // butSetup2
            // 
            this.butSetup2.Location = new System.Drawing.Point(427, 11);
            this.butSetup2.Name = "butSetup2";
            this.butSetup2.Size = new System.Drawing.Size(71, 23);
            this.butSetup2.TabIndex = 1;
            this.butSetup2.Text = "button1";
            this.butSetup2.UseVisualStyleBackColor = true;
            this.butSetup2.Click += new System.EventHandler(this.butSetup2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(701, 364);
            this.dataGridView2.TabIndex = 1;
            // 
            // clucbSelect
            // 
            this.clucbSelect.HeaderText = "Select";
            this.clucbSelect.Name = "clucbSelect";
            this.clucbSelect.ReadOnly = true;
            // 
            // cluFileName
            // 
            this.cluFileName.DataPropertyName = "FileName";
            this.cluFileName.HeaderText = "FileName";
            this.cluFileName.Name = "cluFileName";
            this.cluFileName.ReadOnly = true;
            // 
            // cluVer
            // 
            this.cluVer.DataPropertyName = "VersionNO";
            this.cluVer.HeaderText = "Version";
            this.cluVer.Name = "cluVer";
            this.cluVer.ReadOnly = true;
            // 
            // cluCreaateTime
            // 
            this.cluCreaateTime.DataPropertyName = "CreateTime";
            this.cluCreaateTime.HeaderText = "CreateTime";
            this.cluCreaateTime.Name = "cluCreaateTime";
            this.cluCreaateTime.ReadOnly = true;
            // 
            // folderBrows
            // 
            this.folderBrows.ShowNewFolderButton = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbExcludeList);
            this.panel6.Controls.Add(this.cbExcludeFolder);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1092, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 412);
            this.panel6.TabIndex = 3;
            // 
            // cbExcludeFolder
            // 
            this.cbExcludeFolder.AutoSize = true;
            this.cbExcludeFolder.Location = new System.Drawing.Point(24, 15);
            this.cbExcludeFolder.Name = "cbExcludeFolder";
            this.cbExcludeFolder.Size = new System.Drawing.Size(89, 19);
            this.cbExcludeFolder.TabIndex = 0;
            this.cbExcludeFolder.Text = "排除目录";
            this.cbExcludeFolder.UseVisualStyleBackColor = true;
            // 
            // lbExcludeList
            // 
            this.lbExcludeList.ContextMenuStrip = this.cMenExclude;
            this.lbExcludeList.FormattingEnabled = true;
            this.lbExcludeList.ItemHeight = 15;
            this.lbExcludeList.Items.AddRange(new object[] {
            "ALL"});
            this.lbExcludeList.Location = new System.Drawing.Point(24, 48);
            this.lbExcludeList.Name = "lbExcludeList";
            this.lbExcludeList.Size = new System.Drawing.Size(161, 259);
            this.lbExcludeList.TabIndex = 1;
            this.lbExcludeList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbExcludeList_MouseClick);
            this.lbExcludeList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbExcludeList_MouseDown);
            // 
            // cMenExclude
            // 
            this.cMenExclude.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenExclude.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cMenExclude.Name = "cMenExclude";
            this.cMenExclude.Size = new System.Drawing.Size(127, 52);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 512);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.cMenExclude.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button butSelectFile;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog opFile;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button butSetup2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clucbSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluCreaateTime;
        private System.Windows.Forms.FolderBrowserDialog folderBrows;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox lbExcludeList;
        private System.Windows.Forms.CheckBox cbExcludeFolder;
        private System.Windows.Forms.ContextMenuStrip cMenExclude;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}


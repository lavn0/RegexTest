namespace RegexTest
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.差分ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tortoise差分ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.縦横切替ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl = new CustomControl.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.regexModeControl1 = new RegexTest.RegexModeControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(212)))), ((int)(((byte)(249)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(523, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DOBON.NET";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem,
            this.差分ToolStripMenuItem,
            this.表示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // 差分ToolStripMenuItem
            // 
            this.差分ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tortoise差分ToolStripMenuItem});
            this.差分ToolStripMenuItem.Name = "差分ToolStripMenuItem";
            this.差分ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.差分ToolStripMenuItem.Text = "差分";
            // 
            // Tortoise差分ToolStripMenuItem
            // 
            this.Tortoise差分ToolStripMenuItem.Name = "Tortoise差分ToolStripMenuItem";
            this.Tortoise差分ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.Tortoise差分ToolStripMenuItem.Text = "Tortoise差分";
            this.Tortoise差分ToolStripMenuItem.Click += new System.EventHandler(this.tortoise差分ToolStripMenuItem_Click);
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.縦横切替ToolStripMenuItem});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.表示ToolStripMenuItem.Text = "表示";
            // 
            // 縦横切替ToolStripMenuItem
            // 
            this.縦横切替ToolStripMenuItem.Name = "縦横切替ToolStripMenuItem";
            this.縦横切替ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.縦横切替ToolStripMenuItem.Text = "縦横切替";
            this.縦横切替ToolStripMenuItem.Click += new System.EventHandler(this.縦横切替ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(592, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl
            // 
            this.tabControl.CloseOnClickTabClose = true;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(592, 318);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.regexModeControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NewTab　　";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // regexModeControl1
            // 
            this.regexModeControl1.BackColor = System.Drawing.SystemColors.Control;
            this.regexModeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regexModeControl1.Location = new System.Drawing.Point(3, 3);
            this.regexModeControl1.Name = "regexModeControl1";
            this.regexModeControl1.Size = new System.Drawing.Size(578, 286);
            this.regexModeControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 318);
            this.panel1.TabIndex = 5;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "正規表現テスト(RegexTest) 改造版";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 縦横切替ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 差分ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tortoise差分ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private CustomControl.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private RegexTest.RegexModeControl regexModeControl1;
        private System.Windows.Forms.Panel panel1;
    }
}

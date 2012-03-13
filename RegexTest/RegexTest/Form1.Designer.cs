using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RegexTest
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private IContainer components = null;

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
            this.tortoiseMergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.縦横切替ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTextBox = new CustomControl.ToolStripSpringTextBox();
            this.regexModeControl = new RegexTest.RegexModeControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.表示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tortoiseMergeToolStripMenuItem});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // tortoiseMergeToolStripMenuItem
            // 
            this.tortoiseMergeToolStripMenuItem.Name = "tortoiseMergeToolStripMenuItem";
            this.tortoiseMergeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tortoiseMergeToolStripMenuItem.Text = "TortoiseMerge";
            this.tortoiseMergeToolStripMenuItem.Click += new System.EventHandler(this.tortoiseMergeToolStripMenuItem_Click);
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(592, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTextBox
            // 
            this.toolStripTextBox.Name = "toolStripTextBox";
            this.toolStripTextBox.Size = new System.Drawing.Size(544, 25);
            this.toolStripTextBox.Spring = true;
            this.toolStripTextBox.Text = "C:\\Program Files\\TortoiseSVN\\bin\\TortoiseMerge.exe";
            this.toolStripTextBox.Leave += new System.EventHandler(this.toolStripTextBox_Leave);
            // 
            // regexModeControl
            // 
            this.regexModeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regexModeControl.Location = new System.Drawing.Point(0, 26);
            this.regexModeControl.Name = "regexModeControl";
            this.regexModeControl.Size = new System.Drawing.Size(592, 315);
            this.regexModeControl.TabIndex = 4;
            this.regexModeControl.TextChanged += new System.EventHandler(this.regexModeControl_TextChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.regexModeControl);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "正規表現テスト(RegexTest) 改造版";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private LinkLabel linkLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem メニューToolStripMenuItem;
        private ToolStripMenuItem 表示ToolStripMenuItem;
        private ToolStripMenuItem 縦横切替ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private CustomControl.ToolStripSpringTextBox toolStripTextBox;
        private ToolStripMenuItem tortoiseMergeToolStripMenuItem;
        private global::RegexTest.RegexModeControl regexModeControl;
    }
}

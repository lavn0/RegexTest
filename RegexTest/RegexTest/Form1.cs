using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace RegexTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();

            // アセンブリからタイトルを取得
            this.Text = ((AssemblyTitleAttribute)
                Attribute.GetCustomAttribute(
                Assembly.GetExecutingAssembly(),
                typeof(AssemblyTitleAttribute))).Title;

            // アセンブリからバージョン番号を取得
            this.Text += " (v" + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion + ")";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            Process.Start("http://dobon.net/");
            label.LinkVisited = true;
        }

        private void tortoise差分ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control c = tabControl.SelectedTab.Controls[0];
            if (c.GetType() == typeof(RegexTest.RegexModeControl))
            {
                ((RegexTest.RegexModeControl)c).fireTortoiseMerge();
            }
        }

        private void 縦横切替ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control c = tabControl.SelectedTab.Controls[0];
            if (c.GetType() == typeof(RegexTest.RegexModeControl))
            {
                ((RegexTest.RegexModeControl)c).ChangeOrientation();
            }
        }

        /// <summary>
        /// タブ右側余白ダブルクリック時の処理
        /// 新規タブを作成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            this.SuspendLayout();
            TabPage newTabPage = new TabPage("NewTab　　");
            RegexModeControl regexModeControl = new RegexTest.RegexModeControl();
            regexModeControl.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(regexModeControl);
            tabControl.TabPages.Add(newTabPage);
            this.ResumeLayout();
        }
    }
}

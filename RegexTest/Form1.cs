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
            else if (c.GetType() == typeof(RegexTest.IDiffControl))
            {
                ((RegexTest.IDiffControl)c).fireTortoiseIDiff();
            }

        }

        private void 縦横切替ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control c = tabControl.SelectedTab.Controls[0];
            if (c.GetType() == typeof(RegexTest.RegexModeControl))
            {
                ((RegexTest.RegexModeControl)c).ChangeOrientation();
            }
            else if (c.GetType() == typeof(RegexTest.IDiffControl))
            {
                ((RegexTest.IDiffControl)c).ChangeOrientation();
            }
        }

        /// <summary>
        /// 新規Regexタブを作成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewRegexTab(object sender, EventArgs e)
        {
            RegexModeControl regexModeControl = new RegexTest.RegexModeControl();
            CreateNewTab(regexModeControl, "Regex　　");
        }

        /// <summary>
        /// 新規IDiffタブを作成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewIDiffTab(object sender, EventArgs e)
        {
            IDiffControl idiffControl = new IDiffControl();
            CreateNewTab(idiffControl, "IDiff　　");
        }

        /// <summary>
        /// 新規タブを作成する
        /// </summary>
        /// <param name="appendControl">タブに追加するコントロール</param>
        /// <param name="tabName">新規タブの表示名</param>
        private void CreateNewTab(Control appendControl, string tabText)
        {
            this.SuspendLayout();
            TabPage newTabPage = new TabPage(tabText);
            appendControl.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(appendControl);
            tabControl.TabPages.Add(newTabPage);
            this.ResumeLayout();
        }

        /// <summary>
        /// タブのダブルクリック時の処理
        /// タブ表示名を変更する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_DoubleClick(object sender, EventArgs e)
        {
            //フォームの作成
            RenameForm renameForm = new RenameForm(((TabControl)sender).SelectedTab.Text.Trim());

            //フォームの表示
            if (renameForm.ShowDialog(this) == DialogResult.OK)
            {
                // タブ名の変更
                this.tabControl.SelectedTab.Text = renameForm.textBox_Name.Text + "　　";
            }
            renameForm.Dispose();
        }
    }
}

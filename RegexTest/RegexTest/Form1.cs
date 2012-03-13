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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            regexModeControl.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            Process.Start("http://dobon.net/");
            label.LinkVisited = true;
        }

        /// <summary>
        /// TortoiseMergeの指定パスが変わった場合更新する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripTextBox_Leave(object sender, EventArgs e)
        {
            regexModeControl.Tag = ((ToolStripTextBox)sender).Text;
        }

        /// <summary>
        /// ユーザーコントロール側からTortoiseMergeの指定パスが変わった場合更新する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regexModeControl_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox.Text = ((UserControl)sender).Text;
        }

        private void tortoiseMergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regexModeControl.fireTortoiseMerge();
        }

        private void 縦横切替ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regexModeControl.ChangeOrientation();
        }

    }
}

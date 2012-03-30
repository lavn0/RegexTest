using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace RegexTest
{
    public partial class IDiffControl : UserControl
    {
        /// <summary>
        /// TortoiseIDiff.exeの格納場所
        /// </summary>
        private string tortoiseIDiffPath = Properties.Resources.TortoiseIDiffPath;

        /// <summary>
        /// TotoiseIDiff用一時ファイル名リスト
        /// </summary>
        List<string> tmpFileNameList = new List<string>();

        public IDiffControl()
        {
            InitializeComponent();
            this.Disposed += this.IDiffControl_Dispose;
        }

        public void IDiffControl_Dispose(object sender, EventArgs e)
        {
            foreach (string fileName in tmpFileNameList)
            {
                File.Delete(fileName);
            }
        }

        /// <summary>
        /// ImageDiffを実行します
        /// </summary>
        public void fireTortoiseIDiff()
        {
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                return;
            }
            if (!File.Exists(tortoiseIDiffPath))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.FileName = Path.GetFileName(tortoiseIDiffPath);
                ofd.Title = ofd.FileName + "ファイルを選択してください。";
                ofd.Filter = "実行ファイル (*.exe)|*.exe";
                do
                {
                    tortoiseIDiffPath = Path.GetDirectoryName(tortoiseIDiffPath);
                } while (!Directory.Exists(tortoiseIDiffPath));
                ofd.InitialDirectory = tortoiseIDiffPath;
                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                tortoiseIDiffPath = ofd.FileName;
            }
            string baseFileName = Path.GetTempFileName();
            string mineFileName = Path.GetTempFileName();
            pictureBox1.Image.Save(baseFileName);
            tmpFileNameList.Add(baseFileName);
            pictureBox2.Image.Save(mineFileName);
            tmpFileNameList.Add(mineFileName);

            // TortoiseIDiff起動
            Process process = new Process();
            process.StartInfo.FileName = @"""" + tortoiseIDiffPath + @"""";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.Arguments = string.Format(Properties.Resources.TortoiseIDiffFormat, baseFileName, mineFileName);
            process.Start();
        }

        /// <summary>
        /// 入力文字列と結果の縦横構成を切り替える
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangeOrientation()
        {
            if (splitContainer1.Orientation == Orientation.Horizontal)
            {
                splitContainer1.SplitterDistance = splitContainer1.Width * (splitContainer1.Panel1.Height + splitContainer1.SplitterWidth / 2) / splitContainer1.Height - +splitContainer1.SplitterWidth / 2;
                splitContainer1.Orientation = Orientation.Vertical;
            }
            else
            {
                splitContainer1.SplitterDistance = splitContainer1.Height * (splitContainer1.Panel1.Width + splitContainer1.SplitterWidth / 2) / splitContainer1.Width - +splitContainer1.SplitterWidth / 2;
                splitContainer1.Orientation = Orientation.Horizontal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Clipboard.GetImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Clipboard.GetImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Clipboard.SetImage(pictureBox1.Image);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Clipboard.SetImage(pictureBox2.Image);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }
    }
}

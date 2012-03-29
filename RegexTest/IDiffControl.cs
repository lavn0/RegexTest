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
        /// TotoiseMerge用一時ファイル名リスト
        /// </summary>
        List<string> tmpFileNameList = new List<string>();

        public IDiffControl()
        {
            InitializeComponent();
            this.Disposed += this.IDiffControl_Dispose;
            this.Text = @"C:\Program Files\TortoiseSVN\bin\TortoiseIDiff.exe";
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
            string baseFileName = Path.GetTempFileName();
            string mineFileName = Path.GetTempFileName();
            pictureBox1.Image.Save(baseFileName);
            tmpFileNameList.Add(baseFileName);
            pictureBox2.Image.Save(mineFileName);
            tmpFileNameList.Add(mineFileName);

            // TortoiseMerge起動
            Process process = new Process();
            process.StartInfo.FileName = @"""" + this.Text + @"""";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.Arguments = "/left:\"" + baseFileName + "\" /right:\"" + mineFileName + "\"";
            process.Start();
        }

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

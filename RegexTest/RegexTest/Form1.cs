using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexTest
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// TotoiseMerge用一時ファイル名リスト
        /// </summary>
        List<string> tmpFileNameList = new List<string>();

        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (string fileName in tmpFileNameList)
            {
                File.Delete(fileName);
            }
        }

        public string DoRegexIsMatch(string input, string pattern, RegexOptions opt)
        {
            Regex regex = new Regex(pattern, opt);
            return regex.IsMatch(input).ToString();
        }

        public string DoRegexMatches(string input, string pattern, RegexOptions opt)
        {
            StringBuilder builder = new StringBuilder();
            MatchCollection matchs = new Regex(pattern, opt).Matches(input);
            for (int i = 0; i < matchs.Count; i++)
            {
                builder.AppendFormat("Matches[{0}]:{1}\r\n", i, matchs[i].Value);
                foreach (Group group in matchs[i].Groups)
                {
                    builder.AppendFormat("  Group:{0}\r\n", group.Value);
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

        public string DoRegexReplace(string input, string pattern, string replacePattern, RegexOptions opt)
        {
            Regex regex = new Regex(pattern, opt);
            return regex.Replace(input, replacePattern);
        }

        public string DoRegexSplit(string input, string pattern, RegexOptions opt)
        {
            string[] strArray = new Regex(pattern, opt).Split(input);
            return string.Join("\r\n", strArray);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable("RegexMode");
            table.Columns.Add("DisplayName", typeof(string));
            table.Columns.Add("Value", typeof(RegexMode));
            table.Rows.Add(new object[] { "Regex.Matches", RegexMode.Matches });
            table.Rows.Add(new object[] { "Regex.IsMatch", RegexMode.IsMatch });
            table.Rows.Add(new object[] { "Regex.Replace", RegexMode.Replace });
            table.Rows.Add(new object[] { "Regex.Split", RegexMode.Split });
            this.regexMode.DisplayMember = "DisplayName";
            this.regexMode.ValueMember = "Value";
            this.regexMode.DataSource = table;
            foreach (RegexOptions options in Enum.GetValues(typeof(RegexOptions)))
            {
                this.regexOptions.Items.Add(options);
            }
        }

        private RegexOptions GetRegexOptions()
        {
            RegexOptions none = RegexOptions.None;
            foreach (int num in this.regexOptions.CheckedIndices)
            {
                none |= (RegexOptions)this.regexOptions.Items[num];
            }
            return none;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel label = (LinkLabel)sender;
            Process.Start("http://dobon.net/");
            label.LinkVisited = true;
        }

        private void regexMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((RegexMode)this.regexMode.SelectedValue) == RegexMode.Replace)
            {
                this.replaceText.ReadOnly = false;
            }
            else
            {
                this.replaceText.ReadOnly = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string str = "";
            RegexOptions regexOptions = this.GetRegexOptions();
            switch (((RegexMode)this.regexMode.SelectedValue))
            {
                case RegexMode.Matches:
                    str = this.DoRegexMatches(this.inputText.Text, this.patternText.Text, regexOptions);
                    break;

                case RegexMode.IsMatch:
                    str = this.DoRegexIsMatch(this.inputText.Text, this.patternText.Text, regexOptions);
                    break;

                case RegexMode.Replace:
                    str = this.DoRegexReplace(this.inputText.Text, this.patternText.Text, this.replaceText.Text, regexOptions);
                    break;

                case RegexMode.Split:
                    str = this.DoRegexSplit(this.inputText.Text, this.patternText.Text, regexOptions);
                    break;
            }
            this.resultText.Text = str;
        }

        /// <summary>
        /// 入力文字列と結果の縦横構成を切り替える
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 縦横切替ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Orientation == Orientation.Horizontal)
            {
                splitContainer2.SplitterDistance = splitContainer2.Width * (splitContainer2.Panel1.Height + splitContainer2.SplitterWidth / 2) / splitContainer2.Height - +splitContainer2.SplitterWidth / 2;
                splitContainer2.Orientation = Orientation.Vertical;
            }
            else
            {
                splitContainer2.SplitterDistance = splitContainer2.Height * (splitContainer2.Panel1.Width + splitContainer2.SplitterWidth / 2) / splitContainer2.Width - +splitContainer2.SplitterWidth / 2;
                splitContainer2.Orientation = Orientation.Horizontal;
            }
        }

        /// <summary>
        /// スプリッタ位置を中央にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splitContainer2_DoubleClick(object sender, EventArgs e)
        {
            SplitContainer splitContainer = (SplitContainer)sender;
            if (splitContainer.Orientation == Orientation.Horizontal)
            {
                splitContainer.SplitterDistance = (splitContainer.Height - splitContainer.SplitterWidth) / 2;
            }
            else
            {
                splitContainer.SplitterDistance = (splitContainer.Width - splitContainer.SplitterWidth) / 2;
            }
        }

        /// <summary>
        /// TextBoxキー入力時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (typeof(TextBox).Equals(sender.GetType()))
            {
                if (e.KeyCode == Keys.A &&
                    e.Control)
                {
                    // TextBoxのCtrl+A全選択をサポートする。
                    ((TextBox)sender).SelectAll();
                }
            }
        }

        private void textBox_DragEnter(object sender, DragEventArgs e)
        {
            // ファイルがコントロール上にきたら
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // 該当ファイルをコピー（+のアイコン状態）で受け取る
                e.Effect = DragDropEffects.Move;
            }
            else
            {   // ファイルでなかったら（文字列とかだと）拒否マークで受け付けない
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox_DragDrop(object sender, DragEventArgs e)
        {
            // イベント呼び出し元がテキストボックスであることをチェック
            if (typeof(TextBox).Equals(sender.GetType()))
            {
                // ドロップがエクスプローラからのファイル/フォルダドロップであることをチェック
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    // 単一のデータのドロップであることをチェック
                    if (((string[])e.Data.GetData(DataFormats.FileDrop)).Length == 1)
                    {
                        string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

                        // フォルダではなくファイルのドロップであることをチェック
                        if (File.Exists(fileName))
                        {
                            // ファイルの読み込み
                            using (StreamReader sr = new StreamReader(fileName))
                            {
                                ((TextBox)sender).Text = sr.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// TortoiseMergeの起動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tortoiseMergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(toolStripTextBox.Text))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "TortoiseMerge.exeファイルを選択してください。";
                ofd.Filter = "実行ファイル (*.exe)|*.exe";
                if (Directory.Exists(@"C:\Program Files\TortoiseSVN\bin"))
                {
                    ofd.InitialDirectory = @"C:\Program Files\TortoiseSVN\bin";
                }
                else if (Directory.Exists(@"C:\Program Files\TortoiseSVN"))
                {
                    ofd.InitialDirectory = @"C:\Program Files\TortoiseSVN";
                }
                else if (Directory.Exists(@"C:\Program Files"))
                {
                    ofd.InitialDirectory = @"C:\Program Files";
                }
                ofd.FileName = "TortoiseMerge.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    toolStripTextBox.Text = ofd.FileName;
                }
                else
                {
                    return;
                }
            }
            string baseFileName = Path.GetTempFileName();
            string mineFileName = Path.GetTempFileName();
            using (StreamWriter sw = new StreamWriter(baseFileName))
            {
                sw.Write(inputText.Text);
                tmpFileNameList.Add(baseFileName);
            }
            using (StreamWriter sw = new StreamWriter(mineFileName))
            {
                sw.Write(resultText.Text);
                tmpFileNameList.Add(mineFileName);
            }

            // TortoiseMerge起動
            Process process = new Process();
            process.StartInfo.FileName = @"""" + toolStripTextBox.Text + @"""";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.Arguments = "/base:\"" + baseFileName + "\" /mine:\"" + mineFileName + "\"";
            process.Start();
        }
    }
}

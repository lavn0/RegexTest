using System;
using System.Windows.Forms;

namespace RegexTest
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }

        public RenameForm(string tagName)
            : this()
        {
            textBox_Name.Text = tagName;
            textBox_Name.Select();
        }

        private void RenameForm_Load(object sender, EventArgs e)
        {
            this.textBox_Name.SelectAll();
        }

        /// <summary>
        /// OKボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            // 戻り値をセット
            this.DialogResult = DialogResult.OK;

            // フォームを閉じる
            this.Close();
        }

        /// <summary>
        /// キャンセルボタン押下事処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            // 戻り値をセット
            this.DialogResult = DialogResult.Cancel;

            // フォームを閉じる
            this.Close();
        }

        /// <summary>
        /// テキストボックスへのEnter/ESCキー押下時に確定/キャンセルを行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Name_KeyDown(object sender, KeyEventArgs e)
        {
            // Enterが押された場合
            if (e.KeyCode == Keys.Enter)
            {
                // OKボタン押下と同じ処理を行う
                this.button_OK_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // キャンセルボタン押下と同じ処理を行う
                this.button_Cancel_Click(sender, e);
            }
        }

    }
}

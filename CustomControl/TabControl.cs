using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace CustomControl
{
    public class TabControl : System.Windows.Forms.TabControl
    {
        /// <summary>
        /// タブの閉じるボタンクリックイベント
        /// </summary>
        public event EventHandler _TabCloseButtonClick;

        /// <summary>
        /// タブの閉じるボタンクリックイベント
        /// </summary>
        public event EventHandler TabCloseButtonClick;

        /// <summary>
        /// タブの閉じるボタン押下時にタブを閉じるかどうか
        /// </summary>
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue(true)]
        public bool CloseOnClickTabClose
        {
            get;
            set;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TabControl()
        {
            this._TabCloseButtonClick += this.TabCloseButtonClick;
            this._TabCloseButtonClick += this.tabCloseButtonClick;
        }

        /// <summary>
        /// タブクリック時の処理
        /// タブの閉じるボタン動作を有効にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabCloseButtonClick(object sender, EventArgs e)
        {
            if (this.CloseOnClickTabClose && this.TabCount > 1)
            {
                // 子コントロールを適切に破棄するため this.TabPages.Remove では無く Dispose を呼び出す
                this.SelectedTab.Dispose();
            }
        }

        /// <summary>
        /// タブの閉じるボタンクリックイベント
        /// </summary>
        /// <param name="e"></param>
        protected void OnCloseButtonClick(EventArgs e)
        {
            if (this._TabCloseButtonClick != null)
            {
                this._TabCloseButtonClick(this, e);
            }
        }

        /// <summary>
        /// マウスアップイベント
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Point pt = new Point(e.X, e.Y);
            Rectangle rect = this.GetTabCloseButtonRect(pt);
            if (rect.Contains(pt))
            {
                this.OnCloseButtonClick(new EventArgs());
                this.Invalidate(rect);
            }
        }

        /// <summary>
        /// タブの閉じるボタン場所を取得
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        private Rectangle GetTabCloseButtonRect(Point pt)
        {
            Rectangle rect;
            for (int i = 0; i < base.TabCount; i++)
            {
                rect = this.GetTabCloseButtonRect(i);
                if (rect.Contains(pt))
                {
                    return rect;
                }
            }
            return Rectangle.Empty;
        }

        /// <summary>
        /// タブの閉じるボタン場所を取得
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Rectangle GetTabCloseButtonRect(int index)
        {
            Rectangle rect = this.GetTabRect(index);
            rect.X = rect.Right - 20;
            rect.Y = rect.Top + 2;
            rect.Width = 16;
            rect.Height = 16;

            return rect;
        }

        /// <summary>
        /// タブに閉じるボタンを描画
        /// </summary>
        private void DrawTabCloseButton()
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = Rectangle.Empty;
            Point pt = this.PointToClient(Cursor.Position);
            for (int i = 0; i < this.TabPages.Count; i++)
            {
                rect = this.GetTabCloseButtonRect(i);
                // 閉じるボタン描画
                ControlPaint.DrawCaptionButton(g, rect, CaptionButton.Close, ButtonState.Flat);
            }
            g = null;
        }

        /// <summary>
        /// ウィンドウプロシージャ
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case 15:
                    this.DrawTabCloseButton();
                    break;
                default:
                    break;
            }
        }
    }
}

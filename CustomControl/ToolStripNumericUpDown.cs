using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CustomControl
{
    [ToolStripItemDesignerAvailability(
       ToolStripItemDesignerAvailability.ToolStrip |
       ToolStripItemDesignerAvailability.StatusStrip)]
    public class ToolStripNumericUpDown : ToolStripControlHost
    {
        /// <summary>
        /// ホストするNumericUpDownコントロール
        /// </summary>
        private NumericUpDown numericUpDown;

        #region デザイン用プロパティ
        /// <summary>
        /// スピン ボックス (アップダウン コントロール) の最大値を取得または設定します。
        /// </summary>
        [Browsable(true)]
        [DefaultValue(1000)]
        public decimal Maximum
        {
            get { return numericUpDown.Maximum; }
            set { numericUpDown.Maximum = value; }
        }

        /// <summary>
        /// スピン ボックス (アップダウン コントロール) の最小値を取得または設定します。
        /// </summary>
        [Browsable(true)]
        [DefaultValue(0)]
        public decimal Minimum
        {
            get { return numericUpDown.Minimum; }
            set { numericUpDown.Minimum = value; }
        }

        /// <summary>
        /// 値の設定と取得
        /// </summary>
        [Browsable(true)]
        public decimal Value
        {
            get { return NumericUpDown.Value; }
            set { NumericUpDown.Value = value; }
        }
        #endregion

        /// <summary>
        /// ホストしているNumericUpDownコントロール
        /// </summary>
        public NumericUpDown NumericUpDown
        {
            get { return (NumericUpDown)Control; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ToolStripNumericUpDown()
            : base(new NumericUpDown())
        {
            numericUpDown = (NumericUpDown)this.Control;
        }

        /// <summary>
        /// ホストしているNumericUpDownのイベントをサブスクライブする
        /// </summary>
        /// <param name="control">ホストしているNumericUpDownコントロール</param>
        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            NumericUpDown numControl = (NumericUpDown)control;
            numControl.ValueChanged += new EventHandler(NumericUpDown_OnValueChanged);
        }

        /// <summary>
        /// ホストしているNumericUpDownのイベントをアンサブスクライブする
        /// </summary>
        /// <param name="control">ホストしているNumericUpDownコントロール</param>
        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            NumericUpDown numControl = (NumericUpDown)control;
            numControl.ValueChanged -= new EventHandler(NumericUpDown_OnValueChanged);
        }

        /// <summary>
        /// なんらかの方法で System.Windows.Forms.NumericUpDown.Value プロパティが変更されたときに発生します。
        /// </summary>
        [Browsable(true)]
        public event EventHandler ValueChanged;

        /// <summary>
        /// ValueChanged発生時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericUpDown_OnValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, e);
            }
        }
    }
}

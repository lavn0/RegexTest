using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CustomControl
{
    [ToolStripItemDesignerAvailability(
       ToolStripItemDesignerAvailability.ToolStrip |
       ToolStripItemDesignerAvailability.StatusStrip)]
    public class ToolStripBackgroundWorkProgressBar : ToolStripProgressBar
    {
        #region ProgressBarのプロパティ
        /// <summary>
        /// System.ComponentModel.BackgroundWorker が非同期操作を実行中かどうかを示す値を取得します。
        /// </summary>
        public bool IsBusy
        {
            get { return backgroundWorkerMainProcess.IsBusy; }
        }

        /// <summary>
        /// アプリケーションがバックグラウンド操作のキャンセルを要求したかどうかを示す値を取得します。
        /// </summary>
        public bool CancellationPending
        {
            get { return backgroundWorkerMainProcess.CancellationPending; }
        }

        /// <summary>
        /// System.ComponentModel.BackgroundWorker が進行状況の更新を報告できるかどうかを示す値を取得または設定します。
        /// </summary>
        [Browsable(true)]
        public bool WorkerReportsProgress
        {
            get { return backgroundWorkerMainProcess.WorkerReportsProgress; }
            set { backgroundWorkerMainProcess.WorkerReportsProgress = value; }
        }

        /// <summary>
        /// System.ComponentModel.BackgroundWorker が非同期のキャンセルをサポートしているかどうかを示す値を取得または設定します。
        /// </summary>
        [Browsable(true)]
        public bool WorkerSupportsCancellation
        {
            get { return backgroundWorkerMainProcess.WorkerSupportsCancellation; }
            set { backgroundWorkerMainProcess.WorkerSupportsCancellation = value; }
        }
        #endregion
        #region ProgressBarのメソッド
        /// <summary>
        /// System.ComponentModel.BackgroundWorker.RunWorkerAsync()が呼び出されたときに発生します
        /// </summary>
        [Category("非同期")]
        [Description("操作が始まるときに別のスレッドでイベントハンドラを実行します。")]
        public event DoWorkEventHandler DoWork
        {
            add { backgroundWorkerMainProcess.DoWork += value; }
            remove { backgroundWorkerMainProcess.DoWork -= value; }
        }

        /// <summary>
        /// System.ComponentModel.BackgroundWorker.ReportProgress(System.Int32)が呼び出されたときに発生します
        /// </summary>
        [Category("非同期")]
        [Description("状況が進歩したことをワーカー スレッドが示すときに発生します。")]
        public event ProgressChangedEventHandler ProgressChanged
        {
            add { backgroundWorkerMainProcess.ProgressChanged += value; }
            remove { backgroundWorkerMainProcess.ProgressChanged -= value; }
        }

        /// <summary>
        /// バックグラウンドの処理が完了したとき、キャンセルされたとき、例外が発生したときに呼び出されます
        /// </summary>
        [Category("非同期")]
        [Description("ワーカーが完了（成功、失敗またはキャンセルのいずれか）したときに発生します。")]
        public event RunWorkerCompletedEventHandler RunWorkerCompleted
        {
            add { backgroundWorkerMainProcess.RunWorkerCompleted += value; }
            remove { backgroundWorkerMainProcess.RunWorkerCompleted -= value; }
        }

        /// <summary>
        /// <para>バックグラウンド操作の実行を開始します。</para>
        /// <para>　</para>
        /// <para>例外:</para>
        /// <para>　　System.InvalidOperationException</para>
        /// </summary>
        public void RunWorkerAsync()
        {
            backgroundWorkerMainProcess.RunWorkerAsync();
        }

        /// <summary>
        /// <para>バックグラウンド操作の実行を開始します。</para>
        /// <para>　</para>
        /// <para>例外:</para>
        /// <para>　　System.InvalidOperationException</para>
        /// </summary>
        /// <param name="argument">System.ComponentModel.BackgroundWorker.DoWork イベント ハンドラで実行されるバックグラウンド操作で使用するパラメータ。</param>
        public void RunWorkerAsync(object argument)
        {
            backgroundWorkerMainProcess.RunWorkerAsync(argument);
        }

        /// <summary>
        /// <para>保留中のバックグラウンド操作のキャンセルを要求します。</para>
        /// <para>　</para>
        /// <para>例外:</para>
        /// <para>　　System.InvalidOperationException</para>
        /// </summary>
        public void CancelAsync()
        {
            backgroundWorkerMainProcess.CancelAsync();
        }

        /// <summary>
        /// <para>System.ComponentModel.BackgroundWorker.ProgressChanged イベントを発生させます。</para>
        /// <para>　</para>
        /// <para>例外:</para>
        /// <para>　　System.InvalidOperationException</para>
        /// </summary>
        /// <param name="percentProgress">完了しているバックグラウンド操作の比率 (0 ～ 100%)。</param>
        public void ReportProgress(int percentProgress)
        {
            backgroundWorkerMainProcess.ReportProgress(percentProgress);
        }

        /// <summary>
        /// <para>System.ComponentModel.BackgroundWorker.ProgressChanged イベントを発生させます。</para>
        /// <para>　</para>
        /// <para>例外:</para>
        /// <para>　　System.InvalidOperationException</para>
        /// </summary>
        /// <param name="percentProgress">完了しているバックグラウンド操作の比率 (0 ～ 100%)。</param>
        /// <param name="userState">System.ComponentModel.BackgroundWorker.RunWorkerAsync(System.Object) に渡される状態オブジェクト。</param>
        public void ReportProgress(int percentProgress, object userState)
        {
            backgroundWorkerMainProcess.ReportProgress(percentProgress, userState);
        }
        #endregion

        /// <summary>
        /// 実行中表示更新のインターバル
        /// </summary>
        public TimeSpan WaitInterval = new TimeSpan(1000);

        BackgroundWorker backgroundWorkerProgressBar = new BackgroundWorker();
        BackgroundWorker backgroundWorkerMainProcess = new BackgroundWorker();
        public ToolStripBackgroundWorkProgressBar()
            : base()
        {
            backgroundWorkerProgressBar.DoWork += backgroundWorkerProgressBar_DoWork;
            backgroundWorkerProgressBar.ProgressChanged += backgroundWorkerProgressBar_ProgressChanged;
            backgroundWorkerProgressBar.RunWorkerCompleted += backgroundWorkerProgressBar_RunWorkerCompleted;
        }

        ~ToolStripBackgroundWorkProgressBar()
        {
            Dispose();
        }
        new public void Dispose()
        {
            // Cleanup
        }

        #region backgroundWorkerProgressBar
        public DoWorkEventHandler e;
        private void backgroundWorkerProgressBar_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int percentage = 0; ; percentage += 9, percentage %= 110)
            {
                Thread.Sleep(WaitInterval);
                backgroundWorkerProgressBar.ReportProgress(Math.Min(percentage, 100));

                // キャンセル
                if (backgroundWorkerProgressBar.CancellationPending)
                {
                    return;
                }
            }
        }
        private void backgroundWorkerProgressBar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // 進行状況更新
            this.Value = Math.Min(e.ProgressPercentage, 100);
        }
        private void backgroundWorkerProgressBar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // 進行状況初期化
            this.Value = 0;

            if (e.Error != null)
            {
                // エラー出ないはず
                MessageBox.Show(e.Error.GetType() + " occured.");
            }

            // 本処理が停止しているかどうか
            if (!backgroundWorkerMainProcess.IsBusy)
            {
                // 活性化状態初期化
            }
        }
        #endregion
    }
}

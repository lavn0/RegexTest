namespace RegexTest
{
    partial class RenameForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_NewName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.button_OK, 2);
            this.button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OK.Location = new System.Drawing.Point(3, 40);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(100, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.button_Cancel, 2);
            this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancel.Location = new System.Drawing.Point(109, 40);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(109, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "キャンセル";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_Name
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_Name, 4);
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Name.Location = new System.Drawing.Point(3, 15);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(215, 19);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Name_KeyDown);
            // 
            // label_NewName
            // 
            this.label_NewName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_NewName, 4);
            this.label_NewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_NewName.Location = new System.Drawing.Point(3, 0);
            this.label_NewName.Name = "label_NewName";
            this.label_NewName.Size = new System.Drawing.Size(215, 12);
            this.label_NewName.TabIndex = 3;
            this.label_NewName.Text = "新しい名前";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button_OK, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_NewName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Cancel, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 66);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 66);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameForm";
            this.Text = "名前の変更";
            this.Load += new System.EventHandler(this.RenameForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        public System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_NewName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
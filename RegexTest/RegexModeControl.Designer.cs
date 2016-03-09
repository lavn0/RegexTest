namespace RegexTest
{
	partial class RegexModeControl
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

		#region コンポーネント デザイナで生成されたコード
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.regexMode = new System.Windows.Forms.ComboBox();
			this.regexOptions = new System.Windows.Forms.CheckedListBox();
			this.patternText = new System.Windows.Forms.TextBox();
			this.replaceText = new System.Windows.Forms.TextBox();
			this.inputText = new System.Windows.Forms.TextBox();
			this.resultText = new System.Windows.Forms.TextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(3);
			this.label1.Size = new System.Drawing.Size(139, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "オプション (Regex&Options):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(3);
			this.label2.Size = new System.Drawing.Size(86, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "動作 (&Method):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(3);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(3);
			this.label3.Size = new System.Drawing.Size(123, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "検索パターン (&Pattern):";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Margin = new System.Windows.Forms.Padding(3);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(3);
			this.label4.Size = new System.Drawing.Size(152, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "置換パターン (Repla&cement):";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Margin = new System.Windows.Forms.Padding(3);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(3);
			this.label5.Size = new System.Drawing.Size(110, 18);
			this.label5.TabIndex = 0;
			this.label5.Text = "入力文字列 (&Input):";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Margin = new System.Windows.Forms.Padding(3);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(3);
			this.label6.Size = new System.Drawing.Size(82, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "結果 (&Result):";
			// 
			// regexMode
			// 
			this.regexMode.Dock = System.Windows.Forms.DockStyle.Top;
			this.regexMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.regexMode.FormattingEnabled = true;
			this.regexMode.Location = new System.Drawing.Point(0, 18);
			this.regexMode.Margin = new System.Windows.Forms.Padding(0);
			this.regexMode.Name = "regexMode";
			this.regexMode.Size = new System.Drawing.Size(152, 20);
			this.regexMode.TabIndex = 2;
			this.regexMode.SelectedIndexChanged += new System.EventHandler(this.regexMode_SelectedIndexChanged);
			// 
			// regexOptions
			// 
			this.regexOptions.CheckOnClick = true;
			this.regexOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.regexOptions.FormattingEnabled = true;
			this.regexOptions.Location = new System.Drawing.Point(0, 56);
			this.regexOptions.Name = "regexOptions";
			this.regexOptions.Size = new System.Drawing.Size(152, 68);
			this.regexOptions.TabIndex = 4;
			// 
			// patternText
			// 
			this.patternText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.patternText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.patternText.Location = new System.Drawing.Point(0, 18);
			this.patternText.MaxLength = 0;
			this.patternText.Multiline = true;
			this.patternText.Name = "patternText";
			this.patternText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.patternText.Size = new System.Drawing.Size(152, 61);
			this.patternText.TabIndex = 6;
			this.patternText.WordWrap = false;
			this.patternText.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
			this.patternText.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
			this.patternText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
			// 
			// replaceText
			// 
			this.replaceText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.replaceText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.replaceText.Location = new System.Drawing.Point(0, 18);
			this.replaceText.MaxLength = 0;
			this.replaceText.Multiline = true;
			this.replaceText.Name = "replaceText";
			this.replaceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.replaceText.Size = new System.Drawing.Size(152, 68);
			this.replaceText.TabIndex = 8;
			this.replaceText.WordWrap = false;
			this.replaceText.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
			this.replaceText.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
			this.replaceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
			// 
			// inputText
			// 
			this.inputText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.inputText.Location = new System.Drawing.Point(0, 18);
			this.inputText.MaxLength = 0;
			this.inputText.Multiline = true;
			this.inputText.Name = "inputText";
			this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.inputText.Size = new System.Drawing.Size(209, 302);
			this.inputText.TabIndex = 1;
			this.inputText.WordWrap = false;
			this.inputText.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
			this.inputText.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
			this.inputText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
			// 
			// resultText
			// 
			this.resultText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.resultText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.resultText.Location = new System.Drawing.Point(0, 18);
			this.resultText.MaxLength = 0;
			this.resultText.Multiline = true;
			this.resultText.Name = "resultText";
			this.resultText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.resultText.Size = new System.Drawing.Size(223, 302);
			this.resultText.TabIndex = 1;
			this.resultText.WordWrap = false;
			this.resultText.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
			this.resultText.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
			this.resultText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
			// 
			// startButton
			// 
			this.startButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.startButton.Location = new System.Drawing.Point(0, 169);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(152, 23);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "開始 (&Start)";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.patternText);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.replaceText);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Size = new System.Drawing.Size(152, 169);
			this.splitContainer1.SplitterDistance = 79;
			this.splitContainer1.TabIndex = 0;
			this.splitContainer1.TabStop = false;
			this.splitContainer1.DoubleClick += new System.EventHandler(this.splitContainer_DoubleClick);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.inputText);
			this.splitContainer2.Panel1.Controls.Add(this.label5);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.resultText);
			this.splitContainer2.Panel2.Controls.Add(this.label6);
			this.splitContainer2.Size = new System.Drawing.Size(436, 320);
			this.splitContainer2.SplitterDistance = 209;
			this.splitContainer2.TabIndex = 0;
			this.splitContainer2.TabStop = false;
			this.splitContainer2.DoubleClick += new System.EventHandler(this.splitContainer_DoubleClick);
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.regexOptions);
			this.splitContainer3.Panel1.Controls.Add(this.label1);
			this.splitContainer3.Panel1.Controls.Add(this.regexMode);
			this.splitContainer3.Panel1.Controls.Add(this.label2);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
			this.splitContainer3.Panel2.Controls.Add(this.startButton);
			this.splitContainer3.Size = new System.Drawing.Size(152, 320);
			this.splitContainer3.SplitterDistance = 124;
			this.splitContainer3.TabIndex = 2;
			this.splitContainer3.TabStop = false;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.splitContainer3);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer4.Size = new System.Drawing.Size(592, 320);
			this.splitContainer4.SplitterDistance = 152;
			this.splitContainer4.TabIndex = 0;
			this.splitContainer4.TabStop = false;
			// 
			// RegexModeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer4);
			this.Name = "RegexModeControl";
			this.Size = new System.Drawing.Size(592, 320);
			this.Load += new System.EventHandler(this.RegexModeControl_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			this.splitContainer4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.TextBox inputText;
		private System.Windows.Forms.TextBox patternText;
		private System.Windows.Forms.TextBox replaceText;
		private System.Windows.Forms.TextBox resultText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox regexMode;
		private System.Windows.Forms.CheckedListBox regexOptions;
		private System.Windows.Forms.Button startButton;
	}
}

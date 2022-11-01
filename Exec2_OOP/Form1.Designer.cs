namespace Exec2_OOP
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.titleLabel = new System.Windows.Forms.Label();
			this.inputLabel = new System.Windows.Forms.Label();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.newGameButton = new System.Windows.Forms.Button();
			this.tryButton = new System.Windows.Forms.Button();
			this.tryTextBox = new System.Windows.Forms.TextBox();
			this.answerLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.titleLabel.Location = new System.Drawing.Point(73, 25);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(242, 31);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "1 A 2 B 猜 數 字 遊 戲";
			// 
			// inputLabel
			// 
			this.inputLabel.AutoSize = true;
			this.inputLabel.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.inputLabel.Location = new System.Drawing.Point(79, 90);
			this.inputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(114, 19);
			this.inputLabel.TabIndex = 1;
			this.inputLabel.Text = "請輸入四位數字";
			this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// inputTextBox
			// 
			this.inputTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.inputTextBox.Location = new System.Drawing.Point(79, 118);
			this.inputTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(112, 29);
			this.inputTextBox.TabIndex = 2;
			this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// newGameButton
			// 
			this.newGameButton.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.newGameButton.Location = new System.Drawing.Point(212, 85);
			this.newGameButton.Margin = new System.Windows.Forms.Padding(2);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(96, 29);
			this.newGameButton.TabIndex = 3;
			this.newGameButton.Text = "新遊戲";
			this.newGameButton.UseVisualStyleBackColor = true;
			this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
			// 
			// tryButton
			// 
			this.tryButton.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tryButton.Location = new System.Drawing.Point(212, 118);
			this.tryButton.Margin = new System.Windows.Forms.Padding(2);
			this.tryButton.Name = "tryButton";
			this.tryButton.Size = new System.Drawing.Size(96, 26);
			this.tryButton.TabIndex = 4;
			this.tryButton.Text = "試試看";
			this.tryButton.UseVisualStyleBackColor = true;
			this.tryButton.Click += new System.EventHandler(this.tryButton_Click);
			// 
			// tryTextBox
			// 
			this.tryTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tryTextBox.Location = new System.Drawing.Point(79, 160);
			this.tryTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.tryTextBox.Multiline = true;
			this.tryTextBox.Name = "tryTextBox";
			this.tryTextBox.ReadOnly = true;
			this.tryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tryTextBox.Size = new System.Drawing.Size(231, 204);
			this.tryTextBox.TabIndex = 5;
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.answerLabel.Location = new System.Drawing.Point(78, 395);
			this.answerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(42, 21);
			this.answerLabel.TabIndex = 6;
			this.answerLabel.Text = "答案";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 451);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.tryTextBox);
			this.Controls.Add(this.tryButton);
			this.Controls.Add(this.newGameButton);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.inputLabel);
			this.Controls.Add(this.titleLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label inputLabel;
		private System.Windows.Forms.TextBox inputTextBox;
		private System.Windows.Forms.Button newGameButton;
		private System.Windows.Forms.Button tryButton;
		private System.Windows.Forms.TextBox tryTextBox;
		private System.Windows.Forms.Label answerLabel;
	}
}


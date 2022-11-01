namespace Exec2_OOP_Q2
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
			this.firstDiceTextBox = new System.Windows.Forms.TextBox();
			this.thirdDiceTextBox = new System.Windows.Forms.TextBox();
			this.secondDiceTextBox = new System.Windows.Forms.TextBox();
			this.fourthDiceTextBox = new System.Windows.Forms.TextBox();
			this.firstDiceLabel = new System.Windows.Forms.Label();
			this.secondDiceLabel = new System.Windows.Forms.Label();
			this.thirdDiceLabel = new System.Windows.Forms.Label();
			this.fourthDiceLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.throwButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// firstDiceTextBox
			// 
			this.firstDiceTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.firstDiceTextBox.Location = new System.Drawing.Point(66, 241);
			this.firstDiceTextBox.Multiline = true;
			this.firstDiceTextBox.Name = "firstDiceTextBox";
			this.firstDiceTextBox.ReadOnly = true;
			this.firstDiceTextBox.Size = new System.Drawing.Size(42, 42);
			this.firstDiceTextBox.TabIndex = 0;
			this.firstDiceTextBox.TabStop = false;
			this.firstDiceTextBox.Text = " ";
			this.firstDiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// thirdDiceTextBox
			// 
			this.thirdDiceTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.thirdDiceTextBox.Location = new System.Drawing.Point(258, 241);
			this.thirdDiceTextBox.Multiline = true;
			this.thirdDiceTextBox.Name = "thirdDiceTextBox";
			this.thirdDiceTextBox.ReadOnly = true;
			this.thirdDiceTextBox.Size = new System.Drawing.Size(42, 42);
			this.thirdDiceTextBox.TabIndex = 1;
			this.thirdDiceTextBox.TabStop = false;
			this.thirdDiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// secondDiceTextBox
			// 
			this.secondDiceTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.secondDiceTextBox.Location = new System.Drawing.Point(162, 241);
			this.secondDiceTextBox.Multiline = true;
			this.secondDiceTextBox.Name = "secondDiceTextBox";
			this.secondDiceTextBox.ReadOnly = true;
			this.secondDiceTextBox.Size = new System.Drawing.Size(42, 42);
			this.secondDiceTextBox.TabIndex = 2;
			this.secondDiceTextBox.TabStop = false;
			this.secondDiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// fourthDiceTextBox
			// 
			this.fourthDiceTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.fourthDiceTextBox.Location = new System.Drawing.Point(354, 241);
			this.fourthDiceTextBox.Multiline = true;
			this.fourthDiceTextBox.Name = "fourthDiceTextBox";
			this.fourthDiceTextBox.ReadOnly = true;
			this.fourthDiceTextBox.Size = new System.Drawing.Size(42, 42);
			this.fourthDiceTextBox.TabIndex = 3;
			this.fourthDiceTextBox.TabStop = false;
			this.fourthDiceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// firstDiceLabel
			// 
			this.firstDiceLabel.AutoSize = true;
			this.firstDiceLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.firstDiceLabel.Location = new System.Drawing.Point(68, 199);
			this.firstDiceLabel.Name = "firstDiceLabel";
			this.firstDiceLabel.Size = new System.Drawing.Size(39, 38);
			this.firstDiceLabel.TabIndex = 4;
			this.firstDiceLabel.Text = "骰子\r\nA";
			this.firstDiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// secondDiceLabel
			// 
			this.secondDiceLabel.AutoSize = true;
			this.secondDiceLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.secondDiceLabel.Location = new System.Drawing.Point(164, 199);
			this.secondDiceLabel.Name = "secondDiceLabel";
			this.secondDiceLabel.Size = new System.Drawing.Size(39, 38);
			this.secondDiceLabel.TabIndex = 5;
			this.secondDiceLabel.Text = "骰子\r\nB";
			this.secondDiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// thirdDiceLabel
			// 
			this.thirdDiceLabel.AutoSize = true;
			this.thirdDiceLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.thirdDiceLabel.Location = new System.Drawing.Point(260, 199);
			this.thirdDiceLabel.Name = "thirdDiceLabel";
			this.thirdDiceLabel.Size = new System.Drawing.Size(39, 38);
			this.thirdDiceLabel.TabIndex = 6;
			this.thirdDiceLabel.Text = "骰子\r\nC";
			this.thirdDiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fourthDiceLabel
			// 
			this.fourthDiceLabel.AutoSize = true;
			this.fourthDiceLabel.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.fourthDiceLabel.Location = new System.Drawing.Point(356, 203);
			this.fourthDiceLabel.Name = "fourthDiceLabel";
			this.fourthDiceLabel.Size = new System.Drawing.Size(39, 30);
			this.fourthDiceLabel.TabIndex = 7;
			this.fourthDiceLabel.Text = "骰子\r\nD";
			this.fourthDiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.titleLabel.Location = new System.Drawing.Point(165, 54);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(128, 31);
			this.titleLabel.TabIndex = 8;
			this.titleLabel.Text = "骰 子 遊 戲";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// throwButton
			// 
			this.throwButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.throwButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.throwButton.Location = new System.Drawing.Point(192, 119);
			this.throwButton.Name = "throwButton";
			this.throwButton.Size = new System.Drawing.Size(75, 34);
			this.throwButton.TabIndex = 9;
			this.throwButton.Text = "投骰子";
			this.throwButton.UseVisualStyleBackColor = true;
			this.throwButton.Click += new System.EventHandler(this.throwButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(145, 342);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(169, 26);
			this.resultLabel.TabIndex = 10;
			this.resultLabel.Text = "本次的答案是 10";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(472, 481);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.throwButton);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.fourthDiceLabel);
			this.Controls.Add(this.thirdDiceLabel);
			this.Controls.Add(this.secondDiceLabel);
			this.Controls.Add(this.firstDiceLabel);
			this.Controls.Add(this.fourthDiceTextBox);
			this.Controls.Add(this.secondDiceTextBox);
			this.Controls.Add(this.thirdDiceTextBox);
			this.Controls.Add(this.firstDiceTextBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstDiceTextBox;
		private System.Windows.Forms.TextBox thirdDiceTextBox;
		private System.Windows.Forms.TextBox secondDiceTextBox;
		private System.Windows.Forms.TextBox fourthDiceTextBox;
		private System.Windows.Forms.Label firstDiceLabel;
		private System.Windows.Forms.Label secondDiceLabel;
		private System.Windows.Forms.Label thirdDiceLabel;
		private System.Windows.Forms.Label fourthDiceLabel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Button throwButton;
		private System.Windows.Forms.Label resultLabel;
	}
}


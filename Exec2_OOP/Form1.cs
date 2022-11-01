using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_OOP
{
	public partial class Form1 : Form
	{
		private GuessNumber game;
		public Form1()
		{
			InitializeComponent();
			game = new GuessNumber();
			game.newGame();
			answerLabel.Text = String.Empty;
		}

		private void newGameButton_Click(object sender, EventArgs e)
		{
			game.newGame();

			/* 偷看答案
			int result = 0;
			int multi = 1;

			for (int i = game.answer.Length - 1; i > 0; i--)
			{
				result += game.answer[i] * multi;
				multi *= 10;
			}

			answerLabel.Text = result.ToString("D4");
			*/
		}

		private void tryButton_Click(object sender, EventArgs e)
		{
			string input = inputTextBox.Text;
			int guessNumber = GetInputNumber(input);

			var result = game.Guess(guessNumber.ToString());
			if (result.isSucess == true)
			{
				MessageBox.Show("您答對了！");
				tryTextBox.Text = $"{guessNumber:4D} -> {result.Hint}\r\n";
				answerLabel.Text = $"答案是{guessNumber:4D}，\r\n您總共猜了{game.count}次。";
			
}
			else
			{
				MessageBox.Show("您答錯了！");
				tryTextBox.Text = $"{guessNumber:4D} -> {result.Hint}\r\n";
			}
		}

		public int GetInputNumber(string input)
		{
			input = this.inputTextBox.Text;
			return Check(input);
		}

		public int Check(string input)
		{
			if (string.IsNullOrEmpty(input)) throw new Exception($"您沒有填入任何數字");
			bool isInt = int.TryParse(input, out int number);
			return (input.Length == 4) ? throw new Exception($"數字長度須為四") : isInt ? number : throw new Exception($"僅可填入數字");
		}

	}

	public class GuessNumber
	{
		private int[] answer;
		public int a = 0;
		public int b = 0;
		public int count = 0;

		public void newGame()
		{

			//生成陣列
			int[] answerNumber = new int[4];

			//產生隨機數
			Random random = new Random(Guid.NewGuid().GetHashCode());

			//驗證
			for (int i = 0; i < answerNumber.Length; i++)
			{
				answerNumber[i] = random.Next(0, 10); //可以0開頭

				for (int j = 0; j < answerNumber.Length; j++)
				{
					while (answerNumber[i] == answerNumber[j])
					{
						j = 0;
						answerNumber[i] = random.Next(0, 10);
					}
				}
			}

			this.answer = answerNumber;
		}

		public GuessResult Guess(string input)
		{
			a = 0;
			b = 0;
			count++;

			int[] inputarray = new int[4];

			for (int i = 0; i < input.Length; i++)
			{
				inputarray[i] = int.Parse(input[i].ToString());
			}

			for (int j = 0; j < input.Length; j++)
			{
				for (int k = 0; k < j; k++)
				{
					if (inputarray[j] == this.answer[k])
					{
						if (j == k)
						{
							a++;
						}
						else
						{
							b++;
						}
					}
				}
			}

			if (a == 4)
			{
				return GuessResult.Sucess(Hint);
			}

			return GuessResult.Failed(Hint);
		}

		public string Hint
		{
			get => $"{a}A{b}B";
		}	

	}

	public class GuessResult
	{
		public static GuessResult Sucess(string message)
		{
			return new GuessResult { isSucess = true, Hint = message };
		}
		public static GuessResult Failed(string message)
		{
			return new GuessResult { isSucess = false, Hint = message };
		}
		public bool isFailed
		{
			get => !isSucess;
		}

		public bool isSucess { get; set; }

		public string Hint { get; set; }

	}

}

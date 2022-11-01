using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_OOP_Q2
{
	public partial class Form1 : Form
	{
		private Dice game;
		public Form1()
		{
			InitializeComponent();
			game = new Dice();
			resultLabel.Text = string.Empty;
		}

		private void throwButton_Click(object sender, EventArgs e)
		{
			game = new Dice();
			game.newGame();

			firstDiceTextBox.Text = game.answer[0].ToString();
			secondDiceTextBox.Text = game.answer[1].ToString();
			thirdDiceTextBox.Text = game.answer[2].ToString();
			fourthDiceTextBox.Text = game.answer[3].ToString();

			int result = game.CountResult();
			resultLabel.Text = $"本次得到的點數是 {result}";

		}
	}

	public class Dice
	{
		public int[] answer;

		public void newGame()
		{
			int[] result = new int[4];

			Random random = new Random(Guid.NewGuid().GetHashCode());

			for (int i = 0; i < result.Length; i++)
			{
				result[i] = random.Next(1, 7);

				for (int k = 0; k < result.Length; k++)
				{
					while (result.Length == result.Distinct().Count())
					{
						k = 0;
						result[i] = random.Next(1, 7);
					}
				}
			}

			this.answer = result;
		}

		public int CountResult()
		{
			Array.Sort(answer);
			return answer[2] + answer[3];
		}
	}
}

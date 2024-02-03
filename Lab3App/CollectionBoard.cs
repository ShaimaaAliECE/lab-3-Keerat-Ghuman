using System;
namespace Lab3App
{
	internal class CollectionBoard
	{
		private int TotalScore { get; set; }
		private int TotalValue { get; set; }

		public void UpdateTotalScore(int score)
		{
			TotalScore += score;
            Console.WriteLine($"Total Score is updated to: {TotalScore}");
        }

		public void UpdateTotalValue(int value)
		{
			TotalValue += value;
            Console.WriteLine($"Total Value is updated to: {TotalValue}");
        }

	}
}


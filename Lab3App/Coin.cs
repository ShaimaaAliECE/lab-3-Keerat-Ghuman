using System;
namespace Lab3App
{
	internal class Coin : Treasure
	{
		public int Value { get; set; }
		public Coin(string description, int score, int value) : base(description, score) {
			Value = value;
		}
        public override void UpdateTotalValue()
		{
			CBoard.UpdateTotalValue(Value);
		}

        public override void Display()
        {
			Console.WriteLine($"Coin {Description} is displayed");
        }


    }
}


using System;
namespace Lab3App
{
	internal class Diamond : Treasure
	{
		public int Value { get; set; }
        public Diamond(string description, int score) : base(description, score) { }

		public override void Display()
		{
			Console.WriteLine($"Diamond {Description} is displayed");
		}

        public override void UpdateTotalValue()
        {
			CBoard.UpdateTotalValue(Value);
        }

    }
}


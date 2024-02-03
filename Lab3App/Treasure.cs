using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab3App
{
	internal abstract class Treasure : Collectable
	{
        public int Score { get; set; }
        protected Treasure(string description, int score)
        {
            this.Description = description;
            this.Score = score;
        }

        public void UpdateTotalScore()
        {
            CBoard.UpdateTotalScore(Score);
        }

        public abstract void UpdateTotalValue();
        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            UpdateTotalScore();
            if(this is Coin)
            {
                CBoard.UpdateTotalValue((this as Coin).Value);
            }
        }
    }
}


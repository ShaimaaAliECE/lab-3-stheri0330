 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        protected Treasure(string description,int score) 
        { 
            this.Description = description;
            this.Score = score;
        }
        public int Score { get; set; }

        public void UpdateTotalScore() 
        {
            Board.UpdateTotalScore(Score);
        }
   
        public abstract void UpdateTotalValue();

        public override void AddMe(List<Collectable> list) 
        { 
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Cpngrats!!!!");
            UpdateTotalScore();
            if (this is Coin) 
            {
                UpdateTotalScore();
                Board.UpdateTotalValue((this as Coin).Value);            
            }

        }
    }
}

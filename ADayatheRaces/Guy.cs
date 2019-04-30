using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayatheRaces
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels ()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet()
        {
            MyBet = new Bet
            {
                Amount = 0,
                Bettor = this,
                Dog = 1
            };
        }

        public bool PlaceBet (int BetAmount, int DogToWin)
        {
            if(Cash >= BetAmount && BetAmount >= 5 && BetAmount <= 15)
            {
                MyBet = new Bet { Amount = BetAmount, Bettor = this, Dog = DogToWin };
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect (int Winner)
        {
            Cash += MyBet.PayOut(Winner+1);
            ClearBet();
            UpdateLabels();
        }
    }
}

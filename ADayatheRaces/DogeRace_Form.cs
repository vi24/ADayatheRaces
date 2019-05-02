using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayatheRaces
{
    public partial class DogeRace_Form : Form
    {
        public Greyhound[] GreyhoundArray;
        public Guy[] Guys;
        private Guy _currentGuy;
        private bool _gameover;
        public const int Racetrack_Length = 470;
        public const int Starting_Position = 12;

        public DogeRace_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random randomizer = new Random();
            GreyhoundArray = new Greyhound[4];
            GreyhoundArray[0] = new Greyhound
            {
                Location = 0,
                RacetrackLength = Racetrack_Length,
                MyPictureBox = picDog1,
                Randomizer = randomizer,
                StartingPosition = Starting_Position
            };
            GreyhoundArray[1] = new Greyhound
            {
                Location = 0,
                RacetrackLength = Racetrack_Length,
                MyPictureBox = picDog2,
                Randomizer = randomizer,
                StartingPosition = Starting_Position
            };
            GreyhoundArray[2] = new Greyhound
            {
                Location = 0,
                RacetrackLength = Racetrack_Length,
                MyPictureBox = picDog3,
                Randomizer = randomizer,
                StartingPosition = Starting_Position
            };
            GreyhoundArray[3] = new Greyhound
            {
                Location = 0,
                RacetrackLength = Racetrack_Length,
                MyPictureBox = picDog4,
                Randomizer = randomizer,
                StartingPosition = Starting_Position
            };
            Guys = new Guy[3];
            Guys[0] = new Guy { Cash = 50, Name = "Joe", MyLabel = joeBetLabel, MyRadioButton = joeRadioButton };
            Guys[1] = new Guy { Cash = 75, Name = "Bob", MyLabel = bobBetLabel, MyRadioButton = bobRadioButton };
            Guys[2] = new Guy { Cash = 45, Name = "AI", MyLabel = aiBetLabel, MyRadioButton = aIRadioButton };
            Guys[0].MyBet = new Bet { Amount = 0, Dog = 1, Bettor = Guys[0] };
            Guys[1].MyBet = new Bet { Amount = 0, Dog = 1, Bettor = Guys[1] };
            Guys[2].MyBet = new Bet { Amount = 0, Dog = 1, Bettor = Guys[2] };
            for (int i = 0; i < Guys.Length; i++)
            {
                Guys[i].UpdateLabels();
            }
            minimumBetLabel.Text = "Miniumum bet: " + betNumericUpDown.Minimum.ToString() + " bucks";
            timer1.Interval = 500;
        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentGuy = Guys[0];
            guyName.Text = _currentGuy.Name;
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentGuy = Guys[1];
            guyName.Text = _currentGuy.Name;
        }

        private void AIRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentGuy = Guys[2];
            guyName.Text = _currentGuy.Name;
        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            bettingParlor.Enabled = false;
            timer1.Start();
            _gameover = false;
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            _currentGuy.PlaceBet((int)betNumericUpDown.Value, (int)dogNumberNumericUpDown.Value);
            _currentGuy.UpdateLabels();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (!_gameover && GreyhoundArray[i].Run())
                {
                    _gameover = true;
                    MessageBox.Show("Dog " + (i + 1) + " won the race");
                    timer1.Stop();
                    for (int j = 0; j < Guys.Length; j++)
                    {
                        Guys[j].Collect(i);
                    }
                    for (int k = 0; k < GreyhoundArray.Length; k++)
                    {
                        GreyhoundArray[k].TakeStartingPosition();
                    }
                }
            }
            if (_gameover)
            {
                bettingParlor.Enabled = true;
            }
        }
    }
}

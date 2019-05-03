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
        public Greyhound[] _greyhoundArray;
        public Guy[] _guys;
        private Guy _currentGuy;
        private bool _gameover;
        private Random _randomizer;
        public const int RACETRACK_LENGTH = 470;
        public const int STARTING_POSITION = 12;

        public DogeRace_Form()
        {
            InitializeComponent();
            _randomizer = new Random();
            _greyhoundArray = new Greyhound[4];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _greyhoundArray[0] = new Greyhound
            {
                Location = 0,
                RacetrackLength = RACETRACK_LENGTH,
                MyPictureBox = picDog1,
                Randomizer = _randomizer,
                StartingPosition = STARTING_POSITION
            };
            _greyhoundArray[1] = new Greyhound
            {
                Location = 0,
                RacetrackLength = RACETRACK_LENGTH,
                MyPictureBox = picDog2,
                Randomizer = _randomizer,
                StartingPosition = STARTING_POSITION
            };
            _greyhoundArray[2] = new Greyhound
            {
                Location = 0,
                RacetrackLength = RACETRACK_LENGTH,
                MyPictureBox = picDog3,
                Randomizer = _randomizer,
                StartingPosition = STARTING_POSITION
            };
            _greyhoundArray[3] = new Greyhound
            {
                Location = 0,
                RacetrackLength = RACETRACK_LENGTH,
                MyPictureBox = picDog4,
                Randomizer = _randomizer,
                StartingPosition = STARTING_POSITION
            };
            _guys = new Guy[3];
            _guys[0] = new Guy { Cash = 50, Name = "Joe", MyLabel = joeBetLabel, MyRadioButton = joeRadioButton };
            _guys[1] = new Guy { Cash = 75, Name = "Bob", MyLabel = bobBetLabel, MyRadioButton = bobRadioButton };
            _guys[2] = new Guy { Cash = 45, Name = "AI", MyLabel = aiBetLabel, MyRadioButton = aIRadioButton };
            _guys[0].MyBet = new Bet { Amount = 0, Dog = 1, Bettor = _guys[0] };
            _guys[1].MyBet = new Bet { Amount = 0, Dog = 1, Bettor = _guys[1] };
            _guys[2].MyBet = new Bet { Amount = 0, Dog = 1, Bettor = _guys[2] };
            for (int i = 0; i < _guys.Length; i++)
            {
                _guys[i].UpdateLabels();
            }
            minimumBetLabel.Text = "Miniumum bet: " + betNumericUpDown.Minimum.ToString() + " bucks";
            timer1.Interval = 500;
        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentGuy = _guys[0];
            guyName.Text = _currentGuy.Name;
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentGuy = _guys[1];
            guyName.Text = _currentGuy.Name;
        }

        private void AIRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _currentGuy = _guys[2];
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
            for (int i = 0; i < _greyhoundArray.Length; i++)
            {
                if (!_gameover && _greyhoundArray[i].Run())
                {
                    _gameover = true;
                    MessageBox.Show("Dog " + (i + 1) + " won the race");
                    timer1.Stop();
                    for (int j = 0; j < _guys.Length; j++)
                    {
                        _guys[j].Collect(i);
                    }
                    for (int k = 0; k < _greyhoundArray.Length; k++)
                    {
                        _greyhoundArray[k].TakeStartingPosition();
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

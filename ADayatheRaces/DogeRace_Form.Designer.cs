namespace ADayatheRaces
{
    partial class DogeRace_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.aIRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.guyName = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.bettingParlor = new System.Windows.Forms.GroupBox();
            this.dogNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bucksOnDog = new System.Windows.Forms.Label();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.aiBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.Bets = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picDog4 = new System.Windows.Forms.PictureBox();
            this.picDog3 = new System.Windows.Forms.PictureBox();
            this.picDog2 = new System.Windows.Forms.PictureBox();
            this.picDog1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(6, 46);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 5;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.JoeRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(6, 69);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 6;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.BobRadioButton_CheckedChanged);
            // 
            // aIRadioButton
            // 
            this.aIRadioButton.AutoSize = true;
            this.aIRadioButton.Location = new System.Drawing.Point(6, 93);
            this.aIRadioButton.Name = "aIRadioButton";
            this.aIRadioButton.Size = new System.Drawing.Size(93, 17);
            this.aIRadioButton.TabIndex = 7;
            this.aIRadioButton.TabStop = true;
            this.aIRadioButton.Text = "aIRadioButton";
            this.aIRadioButton.UseVisualStyleBackColor = true;
            this.aIRadioButton.CheckedChanged += new System.EventHandler(this.AIRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(6, 30);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(104, 13);
            this.minimumBetLabel.TabIndex = 8;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // guyName
            // 
            this.guyName.AutoSize = true;
            this.guyName.Location = new System.Drawing.Point(3, 130);
            this.guyName.Name = "guyName";
            this.guyName.Size = new System.Drawing.Size(33, 13);
            this.guyName.TabIndex = 10;
            this.guyName.Text = "name";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(416, 46);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(124, 63);
            this.raceButton.TabIndex = 11;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // bettingParlor
            // 
            this.bettingParlor.Controls.Add(this.dogNumberNumericUpDown);
            this.bettingParlor.Controls.Add(this.bucksOnDog);
            this.bettingParlor.Controls.Add(this.betNumericUpDown);
            this.bettingParlor.Controls.Add(this.betButton);
            this.bettingParlor.Controls.Add(this.aiBetLabel);
            this.bettingParlor.Controls.Add(this.bobBetLabel);
            this.bettingParlor.Controls.Add(this.joeBetLabel);
            this.bettingParlor.Controls.Add(this.Bets);
            this.bettingParlor.Controls.Add(this.raceButton);
            this.bettingParlor.Controls.Add(this.guyName);
            this.bettingParlor.Controls.Add(this.minimumBetLabel);
            this.bettingParlor.Controls.Add(this.joeRadioButton);
            this.bettingParlor.Controls.Add(this.bobRadioButton);
            this.bettingParlor.Controls.Add(this.aIRadioButton);
            this.bettingParlor.Location = new System.Drawing.Point(12, 210);
            this.bettingParlor.Name = "bettingParlor";
            this.bettingParlor.Size = new System.Drawing.Size(571, 156);
            this.bettingParlor.TabIndex = 12;
            this.bettingParlor.TabStop = false;
            this.bettingParlor.Text = "Betting Parlor";
            // 
            // dogNumberNumericUpDown
            // 
            this.dogNumberNumericUpDown.Location = new System.Drawing.Point(291, 128);
            this.dogNumberNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumberNumericUpDown.Name = "dogNumberNumericUpDown";
            this.dogNumberNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.dogNumberNumericUpDown.TabIndex = 19;
            this.dogNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bucksOnDog
            // 
            this.bucksOnDog.AutoSize = true;
            this.bucksOnDog.Location = new System.Drawing.Point(181, 130);
            this.bucksOnDog.Name = "bucksOnDog";
            this.bucksOnDog.Size = new System.Drawing.Size(110, 13);
            this.bucksOnDog.TabIndex = 18;
            this.bucksOnDog.Text = "bucks on dog number";
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(128, 128);
            this.betNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.betNumericUpDown.TabIndex = 17;
            this.betNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(47, 125);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 16;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // aiBetLabel
            // 
            this.aiBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aiBetLabel.Location = new System.Drawing.Point(199, 95);
            this.aiBetLabel.Name = "aiBetLabel";
            this.aiBetLabel.Size = new System.Drawing.Size(197, 23);
            this.aiBetLabel.TabIndex = 15;
            this.aiBetLabel.Text = "aiBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(199, 71);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(197, 23);
            this.bobBetLabel.TabIndex = 14;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(199, 48);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(197, 23);
            this.joeBetLabel.TabIndex = 13;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // Bets
            // 
            this.Bets.AutoSize = true;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.Location = new System.Drawing.Point(199, 30);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(32, 13);
            this.Bets.TabIndex = 12;
            this.Bets.Text = "Bets";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // picDog4
            // 
            this.picDog4.Image = global::ADayatheRaces.Properties.Resources.dog__1_;
            this.picDog4.Location = new System.Drawing.Point(12, 159);
            this.picDog4.Name = "picDog4";
            this.picDog4.Size = new System.Drawing.Size(75, 20);
            this.picDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDog4.TabIndex = 4;
            this.picDog4.TabStop = false;
            // 
            // picDog3
            // 
            this.picDog3.Image = global::ADayatheRaces.Properties.Resources.dog__1_;
            this.picDog3.Location = new System.Drawing.Point(12, 107);
            this.picDog3.Name = "picDog3";
            this.picDog3.Size = new System.Drawing.Size(75, 20);
            this.picDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDog3.TabIndex = 3;
            this.picDog3.TabStop = false;
            // 
            // picDog2
            // 
            this.picDog2.Image = global::ADayatheRaces.Properties.Resources.dog__1_;
            this.picDog2.Location = new System.Drawing.Point(12, 51);
            this.picDog2.Name = "picDog2";
            this.picDog2.Size = new System.Drawing.Size(75, 20);
            this.picDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDog2.TabIndex = 2;
            this.picDog2.TabStop = false;
            // 
            // picDog1
            // 
            this.picDog1.Image = global::ADayatheRaces.Properties.Resources.dog__1_;
            this.picDog1.Location = new System.Drawing.Point(12, 12);
            this.picDog1.Name = "picDog1";
            this.picDog1.Size = new System.Drawing.Size(75, 20);
            this.picDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDog1.TabIndex = 1;
            this.picDog1.TabStop = false;
            // 
            // background
            // 
            this.background.Image = global::ADayatheRaces.Properties.Resources.racetrack__1_;
            this.background.Location = new System.Drawing.Point(-2, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(598, 204);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // DogeRace_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 378);
            this.Controls.Add(this.bettingParlor);
            this.Controls.Add(this.picDog4);
            this.Controls.Add(this.picDog3);
            this.Controls.Add(this.picDog2);
            this.Controls.Add(this.picDog1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DogeRace_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bettingParlor.ResumeLayout(false);
            this.bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox picDog1;
        private System.Windows.Forms.PictureBox picDog2;
        private System.Windows.Forms.PictureBox picDog3;
        private System.Windows.Forms.PictureBox picDog4;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton aIRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label guyName;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.GroupBox bettingParlor;
        private System.Windows.Forms.Label Bets;
        private System.Windows.Forms.Label aiBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.NumericUpDown betNumericUpDown;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label bucksOnDog;
        private System.Windows.Forms.NumericUpDown dogNumberNumericUpDown;
        private System.Windows.Forms.Timer timer1;
    }
}


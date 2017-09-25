using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TroaPrices
{
    public partial class Hej : Form
    {
        public Hej()
        {
            InitializeComponent();

        }


        //jeg var en retard da jeg navngav den her.
        //Bør hedde noget i stil med "trackbarPrizeChange" Prize payout ændres og leftover credit beregnes når trackbarens nuværende værdi ændres af brugeren.
        private void Wut(object sender, EventArgs e)
        {


            FourNilPrizes.Text = FourNilTB.Value.ToString();
            ThreeOnePrizes.Text = ThreeOneTB.Value.ToString();
            ThreeDrawPrizes.Text = ThreeDrawTB.Value.ToString();
            TwoDrawPrizes.Text = TwoDrawTB.Value.ToString();

            CalculateLeftoverCredit();
        }

        private void SuggestPrizes(object sender, EventArgs e)
        {
            PrizeDistribution();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        //Import af standings
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                int fournil = 0;
                int threeone = 0;
                int threedraw = 0;
                int twodraw = 0;
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    string[] pieces = text.Split('\n');
                    ParticipantCountText.Text = (pieces.Length - 3).ToString();
                    foreach (var foo in pieces)
                    {
                        if (foo.Contains("MatchPoints=\"12\""))
                            fournil++;
                        if (foo.Contains("MatchPoints=\"10\""))
                            threedraw++;
                        if (foo.Contains("MatchPoints=\"9\""))
                            threeone++;
                        if (foo.Contains("MatchPoints=\"7\""))
                            twodraw++;
                    }
                    FourNil.Text = fournil.ToString();
                    ThreeDraw.Text = threedraw.ToString();
                    ThreeOne.Text = threeone.ToString();
                    TwoDraw.Text = twodraw.ToString();
                    //Kalder det samme some som suggest prizes
                    PrizeDistribution();
                }
                catch (IOException)
                {
                    MessageBox.Show("Something went wrong Keepo", "WutFace",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        

        private void SetTrackbars()
        {
            try
            {
                if (int.Parse(TotalPrizes.Text) > 0)
                {
                    //Twodraw
                    int value;
                    int value2;
                    int totalprizes;
                    if (int.TryParse(ParticipantCountText.Text, out value) &&
                        int.TryParse(PrizePoolText.Text, out value))
                        totalprizes = int.Parse(ParticipantCountText.Text)*int.Parse(PrizePoolText.Text);
                    else totalprizes = 0;
                    if (int.TryParse(TwoDraw.Text, out value) && value != 0)
                        TwoDrawTB.Maximum = totalprizes/value;
                    else
                    {
                        TwoDrawTB.Maximum = 0;
                    }
                    if (int.TryParse(TwoDraw.Text, out value))
                        TwoDrawTB.Value = int.Parse(TwoDrawPrizes.Text);
                    else TwoDrawTB.Value = 0;

                    //3-1 og 3-0-1
                    if (int.TryParse(ThreeOne.Text, out value) && int.TryParse(ThreeDraw.Text, out value2) &&
                        value + value2 != 0)
                    {
                        ThreeOneTB.Maximum = int.Parse(TotalPrizes.Text)/
                                             (int.Parse(ThreeOne.Text) + int.Parse(ThreeDraw.Text));
                        if (int.Parse(ThreeDraw.Text) != 0)
                            ThreeDrawTB.Maximum = ThreeOneTB.Maximum;
                        if (int.Parse(ThreeDraw.Text) == 0)
                            ThreeDrawTB.Maximum = 1;
                        if (int.Parse(ThreeOne.Text) == 0)
                            ThreeOneTB.Maximum = 1;
                    }

                    //3-1 er tom
                    if (!int.TryParse(ThreeOne.Text, out value) && int.TryParse(ThreeDraw.Text, out value))
                    {
                        if (value == 0)
                        {
                            ThreeOneTB.Maximum = 1;
                            ThreeDrawTB.Maximum = 1;
                        }
                        else
                        {
                            ThreeOneTB.Maximum = 1;
                            ThreeDrawTB.Maximum = totalprizes/value;
                        }

                    }

                    //3-0-1 er tom
                    if (!int.TryParse(ThreeDraw.Text, out value) && int.TryParse(ThreeOne.Text, out value))
                    {
                        if (value == 0)
                        {
                            ThreeOneTB.Maximum = 1;
                            ThreeDrawTB.Maximum = 1;
                        }
                        else
                        {
                            ThreeDrawTB.Maximum = 1;
                            ThreeOneTB.Maximum = totalprizes/value;
                        }
                    }
                    //Begge er tomme
                    if (!int.TryParse(ThreeDraw.Text, out value) && !int.TryParse(ThreeOne.Text, out value))
                    {
                        ThreeOneTB.Maximum = 1;
                        ThreeDrawTB.Maximum = 1;
                    }
                    if (!int.TryParse(ThreeOne.Text, out value) || ThreeOne.Text == "0")
                        ThreeOneTB.Value = 0;
                    else ThreeOneTB.Value = int.Parse(ThreeOnePrizes.Text);

                    if (!int.TryParse(ThreeDraw.Text, out value) || ThreeDraw.Text == "0")
                        ThreeDrawTB.Value = 0;
                    else ThreeDrawTB.Value = int.Parse(ThreeOnePrizes.Text);





                    if (int.TryParse(FourNil.Text, out value) && 0 != Int32.Parse(FourNil.Text))
                    {
                        //Trackbars maximum sættes
                        FourNilTB.Maximum = totalprizes/int.Parse(FourNil.Text);

                        FourNilTB.Value = int.Parse(FourNilPrizes.Text);
                    }
                    else
                    {
                        FourNilTB.Maximum = 1;
                        FourNilTB.Value = 0;
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                MessageBox.Show("One of the trackbars value is higher than it's possible maximum. Something here doesen't add up.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateLeftoverCredit()
        {
            int fournil;
            int threeone;
            int threedraw;
            int twodraw;
            int value;
            if (int.TryParse(FourNil.Text, out value))
                fournil = value;
            else fournil = 0;

            if (int.TryParse(ThreeOne.Text, out value))
                threeone = value;
            else threeone = 0;

            if (int.TryParse(ThreeDraw.Text, out value))
                threedraw = value;
            else threedraw = 0;

            if (int.TryParse(TwoDraw.Text, out value))
                twodraw = value;
            else twodraw = 0;
            LeftOverCredit.Text =
            (int.Parse(TotalPrizes.Text) - FourNilTB.Value * fournil - ThreeOneTB.Value * threeone -
             ThreeDrawTB.Value * threedraw - TwoDrawTB.Value * twodraw).ToString();
        }

       

        private void ResetAllTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "0";
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            ResetAllTextBoxes();
        }

        private void ResetPrizes(object sender, EventArgs e)
        {
            FourNilPrizes.Text = "0";
            ThreeDrawPrizes.Text = "0";
            ThreeOnePrizes.Text = "0";
            TwoDrawPrizes.Text = "0";
            CalculateLeftoverCredit();
        }
        //Alternative to previous "algorithm"
        private void PrizeDistribution()
        {
            //Først beregnes total prizes
            //ValueI er bare en throwaway variabel der bruges af try.parse
            int valueI;
            int totalprizes;

            //hvis textfelterne er fyldt ud beregnes en værdi ud fra dem, ellers er den bare 0.
            if (int.TryParse(ParticipantCountText.Text, out valueI) && int.TryParse(PrizePoolText.Text, out valueI))
                totalprizes = int.Parse(ParticipantCountText.Text) * int.Parse(PrizePoolText.Text);
            else totalprizes = 0;

            TotalPrizes.Text = totalprizes.ToString();


            
            double valueD;  // Value er en throwaway variabel for doubles der bruges af try.parse
            double Payout = 0; //summen af prizes der er beregnet til udbetaling indtil videre
            double fournil = 0; //Prizes til 4-0
            int fournilint = 0; //Prizes for 4-0 converted til int, da vi kun giver prizes i heltal
            double threex = 0; //prizes der deles ud til 3-x
            int fournilCount = 0; // antal 4-0'ere
            int threexCount = 0; // antal 3-x'ere

            if (int.TryParse(FourNil.Text, out valueI)) // tjekker om antallet af 4-0'ere er tastet ind, hvis det er så er assignes det til 4-0count
                fournilCount = valueI;
            threexCount = AmountOfThreeX(); // antallet af 3-x'ere beregnes af en hjælper funktion

            if(double.TryParse(TotalPrizes.Text, out valueD)) // hvis totalprizes er fyldt udkan vi beregne prizes.
            { 
                while (valueD>Payout) // for hver 1guld 3-x får, så får 4-0 1.5guld
                {
                    threex++;
                    fournil = fournil + 1.5;
                    Payout = threex*threexCount + fournil*fournilCount;
                    if (Payout == 0) break;
                }
            }
            fournilint = Convert.ToInt32(fournil)-1; //vi skal bruge værdien som int, så den convertes, og så trækkes 1 fra for at den ikke rundes op for højt.
            if (int.TryParse(ThreeOne.Text, out valueI) && valueI != 0) // alle prizes tildeles som nødvendigt, eller sættes til 0 hvis der er 0 med den score/feltet er tomt
                ThreeOnePrizes.Text = threex.ToString();
            else ThreeOnePrizes.Text = "0";
            if (int.TryParse(ThreeDraw.Text, out valueI) && valueI != 0)
                ThreeDrawPrizes.Text = threex.ToString();
            else ThreeDrawPrizes.Text = "0";
            if (fournilCount > 0)
                FourNilPrizes.Text = fournilint.ToString();
            else FourNilPrizes.Text = "0";

            SetTrackbars();
            CalculateLeftoverCredit();
        }

        private int AmountOfThreeX()
        {
            int value = 0;
            int count = 0;
            if(int.TryParse(ThreeDraw.Text, out value));
                count = value + count;
            if(int.TryParse(ThreeOne.Text, out value))
                count = value + count;
            return count;
        }
    }
}
namespace TroaPrices
{
    partial class Hej
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hej));
            this.FourNilTB = new System.Windows.Forms.TrackBar();
            this.ThreeOneTB = new System.Windows.Forms.TrackBar();
            this.ThreeOnePrizes = new System.Windows.Forms.TextBox();
            this.FourNil = new System.Windows.Forms.TextBox();
            this.ThreeOne = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FourNilPrizes = new System.Windows.Forms.TextBox();
            this.TotalPrizes = new System.Windows.Forms.Label();
            this.PricePerParticipant = new System.Windows.Forms.Label();
            this.PrizePoolText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ParticipantCountText = new System.Windows.Forms.TextBox();
            this.LeftOverCredit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TwoDraw = new System.Windows.Forms.TextBox();
            this.ThreeDraw = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ThreeDrawPrizes = new System.Windows.Forms.TextBox();
            this.ThreeDrawTB = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.TwoDrawPrizes = new System.Windows.Forms.TextBox();
            this.TwoDrawTB = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ResetBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FourNilTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeOneTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeDrawTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoDrawTB)).BeginInit();
            this.SuspendLayout();
            // 
            // FourNilTB
            // 
            this.FourNilTB.Location = new System.Drawing.Point(197, 53);
            this.FourNilTB.Name = "FourNilTB";
            this.FourNilTB.Size = new System.Drawing.Size(354, 45);
            this.FourNilTB.TabIndex = 11;
            this.FourNilTB.Scroll += new System.EventHandler(this.Wut);
            // 
            // ThreeOneTB
            // 
            this.ThreeOneTB.Location = new System.Drawing.Point(198, 155);
            this.ThreeOneTB.Name = "ThreeOneTB";
            this.ThreeOneTB.Size = new System.Drawing.Size(354, 45);
            this.ThreeOneTB.TabIndex = 13;
            this.ThreeOneTB.Scroll += new System.EventHandler(this.Wut);
            // 
            // ThreeOnePrizes
            // 
            this.ThreeOnePrizes.Location = new System.Drawing.Point(558, 155);
            this.ThreeOnePrizes.Name = "ThreeOnePrizes";
            this.ThreeOnePrizes.ReadOnly = true;
            this.ThreeOnePrizes.Size = new System.Drawing.Size(50, 20);
            this.ThreeOnePrizes.TabIndex = 9;
            this.ThreeOnePrizes.Text = "0";
            // 
            // FourNil
            // 
            this.FourNil.Location = new System.Drawing.Point(142, 53);
            this.FourNil.Name = "FourNil";
            this.FourNil.Size = new System.Drawing.Size(37, 20);
            this.FourNil.TabIndex = 2;
            this.FourNil.Text = "0";
            this.FourNil.TextChanged += new System.EventHandler(this.SuggestPrizes);
            // 
            // ThreeOne
            // 
            this.ThreeOne.Location = new System.Drawing.Point(142, 155);
            this.ThreeOne.Name = "ThreeOne";
            this.ThreeOne.Size = new System.Drawing.Size(37, 20);
            this.ThreeOne.TabIndex = 4;
            this.ThreeOne.Text = "0";
            this.ThreeOne.TextChanged += new System.EventHandler(this.SuggestPrizes);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Import Standings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of 4-0\'s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of 3-1\'s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Leftover Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "4-0 prizes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "3-0-1 prizes";
            // 
            // FourNilPrizes
            // 
            this.FourNilPrizes.Location = new System.Drawing.Point(557, 53);
            this.FourNilPrizes.Name = "FourNilPrizes";
            this.FourNilPrizes.ReadOnly = true;
            this.FourNilPrizes.Size = new System.Drawing.Size(50, 20);
            this.FourNilPrizes.TabIndex = 7;
            this.FourNilPrizes.Text = "0";
            // 
            // TotalPrizes
            // 
            this.TotalPrizes.AutoSize = true;
            this.TotalPrizes.Location = new System.Drawing.Point(552, 17);
            this.TotalPrizes.Name = "TotalPrizes";
            this.TotalPrizes.Size = new System.Drawing.Size(0, 13);
            this.TotalPrizes.TabIndex = 17;
            this.TotalPrizes.TextChanged += new System.EventHandler(this.ResetPrizes);
            // 
            // PricePerParticipant
            // 
            this.PricePerParticipant.AutoSize = true;
            this.PricePerParticipant.Location = new System.Drawing.Point(224, 17);
            this.PricePerParticipant.Name = "PricePerParticipant";
            this.PricePerParticipant.Size = new System.Drawing.Size(119, 13);
            this.PricePerParticipant.TabIndex = 18;
            this.PricePerParticipant.Text = "Prize Pool pr Participant";
            // 
            // PrizePoolText
            // 
            this.PrizePoolText.BackColor = System.Drawing.SystemColors.Window;
            this.PrizePoolText.Location = new System.Drawing.Point(349, 14);
            this.PrizePoolText.Name = "PrizePoolText";
            this.PrizePoolText.Size = new System.Drawing.Size(39, 20);
            this.PrizePoolText.TabIndex = 6;
            this.PrizePoolText.Text = "25";
            this.PrizePoolText.TextChanged += new System.EventHandler(this.SuggestPrizes);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Number of Participants";
            // 
            // ParticipantCountText
            // 
            this.ParticipantCountText.Location = new System.Drawing.Point(142, 14);
            this.ParticipantCountText.Name = "ParticipantCountText";
            this.ParticipantCountText.Size = new System.Drawing.Size(37, 20);
            this.ParticipantCountText.TabIndex = 1;
            this.ParticipantCountText.Text = "0";
            this.ParticipantCountText.TextChanged += new System.EventHandler(this.SuggestPrizes);
            // 
            // LeftOverCredit
            // 
            this.LeftOverCredit.AutoSize = true;
            this.LeftOverCredit.Location = new System.Drawing.Point(574, 254);
            this.LeftOverCredit.Name = "LeftOverCredit";
            this.LeftOverCredit.Size = new System.Drawing.Size(0, 13);
            this.LeftOverCredit.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Number of 2-1-1\'s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Number of 3-0-1\'s";
            // 
            // TwoDraw
            // 
            this.TwoDraw.Location = new System.Drawing.Point(142, 209);
            this.TwoDraw.Name = "TwoDraw";
            this.TwoDraw.Size = new System.Drawing.Size(37, 20);
            this.TwoDraw.TabIndex = 5;
            this.TwoDraw.Text = "0";
            this.TwoDraw.TextChanged += new System.EventHandler(this.SuggestPrizes);
            // 
            // ThreeDraw
            // 
            this.ThreeDraw.Location = new System.Drawing.Point(142, 104);
            this.ThreeDraw.Name = "ThreeDraw";
            this.ThreeDraw.Size = new System.Drawing.Size(37, 20);
            this.ThreeDraw.TabIndex = 3;
            this.ThreeDraw.Text = "0";
            this.ThreeDraw.TextChanged += new System.EventHandler(this.SuggestPrizes);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "3-1 prizes";
            // 
            // ThreeDrawPrizes
            // 
            this.ThreeDrawPrizes.Location = new System.Drawing.Point(558, 104);
            this.ThreeDrawPrizes.Name = "ThreeDrawPrizes";
            this.ThreeDrawPrizes.ReadOnly = true;
            this.ThreeDrawPrizes.Size = new System.Drawing.Size(50, 20);
            this.ThreeDrawPrizes.TabIndex = 8;
            this.ThreeDrawPrizes.Text = "0";
            // 
            // ThreeDrawTB
            // 
            this.ThreeDrawTB.Location = new System.Drawing.Point(198, 104);
            this.ThreeDrawTB.Name = "ThreeDrawTB";
            this.ThreeDrawTB.Size = new System.Drawing.Size(354, 45);
            this.ThreeDrawTB.TabIndex = 12;
            this.ThreeDrawTB.Scroll += new System.EventHandler(this.Wut);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(552, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "2-1-1 prizes";
            // 
            // TwoDrawPrizes
            // 
            this.TwoDrawPrizes.Location = new System.Drawing.Point(558, 206);
            this.TwoDrawPrizes.Name = "TwoDrawPrizes";
            this.TwoDrawPrizes.ReadOnly = true;
            this.TwoDrawPrizes.Size = new System.Drawing.Size(50, 20);
            this.TwoDrawPrizes.TabIndex = 10;
            this.TwoDrawPrizes.Text = "0";
            // 
            // TwoDrawTB
            // 
            this.TwoDrawTB.Location = new System.Drawing.Point(198, 206);
            this.TwoDrawTB.Name = "TwoDrawTB";
            this.TwoDrawTB.Size = new System.Drawing.Size(354, 45);
            this.TwoDrawTB.TabIndex = 14;
            this.TwoDrawTB.Scroll += new System.EventHandler(this.Wut);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ResetBTN
            // 
            this.ResetBTN.Location = new System.Drawing.Point(120, 245);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(72, 23);
            this.ResetBTN.TabIndex = 33;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.Reset);
            // 
            // Hej
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 278);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TwoDrawPrizes);
            this.Controls.Add(this.TwoDrawTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ThreeDrawPrizes);
            this.Controls.Add(this.ThreeDrawTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TwoDraw);
            this.Controls.Add(this.ThreeDraw);
            this.Controls.Add(this.LeftOverCredit);
            this.Controls.Add(this.ParticipantCountText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PrizePoolText);
            this.Controls.Add(this.PricePerParticipant);
            this.Controls.Add(this.TotalPrizes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ThreeOne);
            this.Controls.Add(this.FourNil);
            this.Controls.Add(this.ThreeOnePrizes);
            this.Controls.Add(this.ThreeOneTB);
            this.Controls.Add(this.FourNilPrizes);
            this.Controls.Add(this.FourNilTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hej";
            this.Text = "Troa Prizes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FourNilTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeOneTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeDrawTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoDrawTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar FourNilTB;
        private System.Windows.Forms.TrackBar ThreeOneTB;
        private System.Windows.Forms.TextBox ThreeOnePrizes;
        private System.Windows.Forms.TextBox FourNil;
        private System.Windows.Forms.TextBox ThreeOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FourNilPrizes;
        private System.Windows.Forms.Label TotalPrizes;
        private System.Windows.Forms.Label PricePerParticipant;
        private System.Windows.Forms.TextBox PrizePoolText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ParticipantCountText;
        private System.Windows.Forms.Label LeftOverCredit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TwoDraw;
        private System.Windows.Forms.TextBox ThreeDraw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ThreeDrawPrizes;
        private System.Windows.Forms.TrackBar ThreeDrawTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TwoDrawPrizes;
        private System.Windows.Forms.TrackBar TwoDrawTB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ResetBTN;
    }
}


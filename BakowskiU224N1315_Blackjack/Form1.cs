using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakowskiU224N1315_Blackjack
{

    public partial class Form1 : Form
    {
        const int CARDS_IN_HAND_MAX = 21;
        List<PictureBox> playerDeck = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeGui();
        }

        private void initializeGui()
        {
            for (int index = 0; index <= CARDS_IN_HAND_MAX; index++)
            {
                var playerCard = new PictureBox();
                //playerCard.Image = global::BakowskiU224N1315_Blackjack.Properties.Resources._2c;
                playerCard.Size = new System.Drawing.Size(73, 93);
                playerCard.Location = new System.Drawing.Point((index + 1)/ 6*82, index % 6*22);
                playerCard.Location = new System.Drawing.Point(6+index%6 * playerCard.Size.Width,16+ index / 6* playerCard.Size.Height);
                playerCard.Name = "picPlayerCard"+index.ToString();
                this.fraPlayerHand.Controls.Add(playerCard);

                var dealerCard = new PictureBox();
                //dealerCard.Image = global::BakowskiU224N1315_Blackjack.Properties.Resources._2c;
                dealerCard.Size = new System.Drawing.Size(73, 93);
                dealerCard.Location = new System.Drawing.Point((index+1) / 6 * 82, index % 6 * 22);
                dealerCard.Location = new System.Drawing.Point(6 + index % 6 * dealerCard.Size.Width, 16 + index / 6 * dealerCard.Size.Height);
                dealerCard.Name = "picPlayerCard" + index.ToString();
                this.fraPlayerHand.Controls.Add(playerCard);
                this.fraDealerHand.Controls.Add(dealerCard);
            }
        }
    }
}

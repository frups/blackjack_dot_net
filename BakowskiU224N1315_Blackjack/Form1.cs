using BakowskiU224N1315_Blackjack.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakowskiU224N1315_Blackjack
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        const int CARDS_IN_HAND_MAX = 21;
        int[] playerDeck = new int[21];//arrays for storing values with cards id of drawed cards
        int[] dealerDeck = new int[21];//arrays for storing values with cards id of drawed cards
        int playerCardsCounter = 0;
        int dealerCardsCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeGui();
            initializeGame();
        }

        private void initializeGui()//method for preparing layout of player and dealer hands in gui (21 can be drawed maximum)
        {
            for (int index = 0; index <= CARDS_IN_HAND_MAX; index++)
            {
                var playerCard = new PictureBox();
                //playerCard.Image = global::BakowskiU224N1315_Blackjack.Properties.Resources._2c;
                playerCard.Size = new System.Drawing.Size(73, 93);
                playerCard.Location = new System.Drawing.Point((index + 1) / 6 * 82, index % 6 * 22);
                playerCard.Location = new System.Drawing.Point(6 + index % 6 * playerCard.Size.Width, 16 + index / 6 * playerCard.Size.Height);
                playerCard.Name = "picPlayerCard" + index.ToString();
                this.fraPlayerHand.Controls.Add(playerCard);

                var dealerCard = new PictureBox();
                //dealerCard.Image = global::BakowskiU224N1315_Blackjack.Properties.Resources._2c;
                dealerCard.Size = new System.Drawing.Size(73, 93);
                dealerCard.Location = new System.Drawing.Point((index + 1) / 6 * 82, index % 6 * 22);
                dealerCard.Location = new System.Drawing.Point(6 + index % 6 * dealerCard.Size.Width, 16 + index / 6 * dealerCard.Size.Height);
                dealerCard.Name = "picDealerCard" + index.ToString();
                this.fraPlayerHand.Controls.Add(playerCard);
                this.fraDealerHand.Controls.Add(dealerCard);
            }
        }

        private void initializeGame()//method which draws two cards for player and one card for dealer
        {
            twistCardForPlayer();
            twistCardForPlayer();
            twistCardForDealer();
        }

        private int drawCardId()
        {
            return rnd.Next(0, 52);
        }
        private void twistCardForPlayer()
        {
            playerDeck[playerCardsCounter] = drawCardId();//saving card id to deck
            int index = fraPlayerHand.Controls.GetChildIndex(fraPlayerHand.Controls.Find(("picPlayerCard") + playerCardsCounter.ToString(), true).First());
            fraPlayerHand.Controls[index].BackgroundImage = getResourceBasedOnCardId(playerDeck[playerCardsCounter]);
            playerCardsCounter++;
        }

        private void twistCardForDealer()
        {
            dealerDeck[dealerCardsCounter] = drawCardId();//saving card id to deck
            int index = fraDealerHand.Controls.GetChildIndex(fraDealerHand.Controls.Find(("picDealerCard") + dealerCardsCounter.ToString(), true).First());
            fraDealerHand.Controls[index].BackgroundImage = getResourceBasedOnCardId(dealerDeck[dealerCardsCounter]);
            dealerCardsCounter++;
        }


        private Bitmap getResourceBasedOnCardId(int cardId)
        {
            ResourceManager MyResourceClass = new ResourceManager(typeof(Resources));

            ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            int i = 0;
            foreach (DictionaryEntry entry in resourceSet)
            {
                if (i++ == cardId) return (Bitmap)entry.Value;
            }
            return null;
        }

        private void btnTwist_Click(object sender, EventArgs e)
        {
            twistCardForPlayer();
        }
    }
}

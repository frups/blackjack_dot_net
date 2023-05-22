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
        int[] playerDeck = new int[CARDS_IN_HAND_MAX];//arrays for storing values with cards id of drawed cards
        int[] dealerDeck = new int[CARDS_IN_HAND_MAX];//arrays for storing values with cards id of drawed cards
        int playerCardsCounter = 0;
        int dealerCardsCounter = 0;
        int playerResult = 0;
        int dealerResult = 0;
        int playerAccount = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        private void initializeGui()//method for preparing layout of player and dealer hands in gui (21 can be drawed maximum)
        {
            lblPlayerAccount.Text = playerAccount.ToString();
            this.fraPlayerHand.Controls.Clear();
            this.fraDealerHand.Controls.Clear();
            for (int index = 0; index <= CARDS_IN_HAND_MAX; index++)
            {
                var playerCard = new PictureBox();
                //playerCard.Image = global::BakowskiU224N1315_Blackjack.Properties.Resources._2c;
                playerCard.Size = new System.Drawing.Size(73, 93);
                playerCard.Location = new System.Drawing.Point(6 + index % 6 * playerCard.Size.Width, 16 + index / 6 * playerCard.Size.Height);
                playerCard.Name = "picPlayerCard" + index.ToString();
                this.fraPlayerHand.Controls.Add(playerCard);

                var dealerCard = new PictureBox();
                //dealerCard.Image = global::BakowskiU224N1315_Blackjack.Properties.Resources._2c;
                dealerCard.Size = new System.Drawing.Size(73, 93);
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
            if (playerCardsCounter < CARDS_IN_HAND_MAX)
            {
                playerDeck[playerCardsCounter] = drawCardId();//saving card id to deck
                //int index = fraPlayerHand.Controls.GetChildIndex(fraPlayerHand.Controls.Find(("picPlayerCard") + playerCardsCounter.ToString(), true).First());
                fraPlayerHand.Controls[playerCardsCounter].BackgroundImage = getResourceBasedOnCardId(playerDeck[playerCardsCounter]);
                playerCardsCounter++;
            }
            updatePlayerResult();
        }

        private void twistCardForDealer()
        {
            if (dealerCardsCounter < CARDS_IN_HAND_MAX)
            {
                dealerDeck[dealerCardsCounter] = drawCardId();//saving card id to deck
                int index = fraDealerHand.Controls.GetChildIndex(fraDealerHand.Controls.Find(("picDealerCard") + dealerCardsCounter.ToString(), true).First());
                fraDealerHand.Controls[index].BackgroundImage = getResourceBasedOnCardId(dealerDeck[dealerCardsCounter]);
                dealerCardsCounter++;
            }
            updateDealerResult();
        }


        private Bitmap getResourceBasedOnCardId(int cardId)
        {
            ResourceManager MyResourceClass = new ResourceManager(typeof(Resources));

            ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            int i = 0;
            foreach (DictionaryEntry entry in resourceSet)
            {
                if (i++ == 52-cardId) return (Bitmap)entry.Value;
            }
            return null;
        }

        private void updatePlayerResult()
        {
            int newResult = 0;
            foreach (int card in playerDeck)
            {
                newResult+=getCardValueById(card);
            }
            playerResult = newResult;
            lblPlayerScore.Text = playerResult.ToString();
        }
        private void updateDealerResult()
        {
            int newResult = 0;
            foreach (int card in dealerDeck)
            {
                newResult += getCardValueById(card);
            }
            dealerResult = newResult;
            lblDealerScore.Text = dealerResult.ToString();
        }

        private int getCardValueById(int cardId)
        {
            if (cardId == 0) return 1;//ace
            if (cardId >= 1 && cardId <= 4) return 6;
            if (cardId >= 5 && cardId <= 8) return 7;
            if (cardId >= 9 && cardId <= 12) return 4;
            if (cardId >= 13 && cardId <= 16) return 5;
            if (cardId >= 17 && cardId <= 20) return 2;
            if (cardId >= 21 && cardId <= 24) return 3;
            if (cardId >= 25 && cardId <= 28) return 8;
            if (cardId >= 29 && cardId <= 32) return 9;
            if (cardId >= 33 && cardId <= 49) return 10;
            if (cardId >= 50 && cardId <= 53) return 1;//ace
            if (cardId == 53) return 0;//Joker
            else return 0;//Value not found
        }

        private void dealerTurn()
        {
            while (dealerResult<=17)
            {
                System.Threading.Thread.Sleep(100);
                twistCardForDealer();
                if(dealerResult>21)
                {
                    MessageBox.Show("Dealer bust. Player won the hand");
                    resetGame();
                    break;
                }
            }

            if (dealerResult > playerResult)
            {
                MessageBox.Show("Player loose");
                resetGame();
            }
            else if (playerResult > dealerResult)
            {
                MessageBox.Show("Player won");
                resetGame();
            }
            else
            {
                MessageBox.Show("Draw");
                resetGame();
            }
        }
        private void btnTwist_Click(object sender, EventArgs e)
        {
            twistCardForPlayer();
            if (playerResult > 21)
            {
                MessageBox.Show("Player bust. Hand is over");
                resetGame();
            }
        }

        private void resetGame()
        {
            btnTwist.Enabled = true;
            playerDeck = new int[CARDS_IN_HAND_MAX];//arrays for storing values with cards id of drawed cards
            dealerDeck = new int[CARDS_IN_HAND_MAX];//arrays for storing values with cards id of drawed cards
            for(int i = 0;i< CARDS_IN_HAND_MAX;i++)
            {
                playerDeck[i] = -1;
                dealerDeck[i] = -1;
            }
            playerCardsCounter = 0;
            dealerCardsCounter = 0;
            playerResult = 0;
            dealerResult = 0;
            initializeGui();
            initializeGame();
        }

        private void btnStick_Click(object sender, EventArgs e)
        {
            btnTwist.Enabled = false;
            dealerTurn();

        }
    }
}

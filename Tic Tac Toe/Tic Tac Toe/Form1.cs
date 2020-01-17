using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int PlayerXWins = 0;
        public int PlayerOWins = 0;
        public int Draws = 0;
        public int turns = 0;
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turns % 2 == 0)
            {
                button.BackgroundImage = ((Image)(Properties.Resources.mark));
                button.BackgroundImageLayout = ImageLayout.Stretch;
                turns++;
                if (CheckWiner() == 1)
                {
                    PlayerOWins++;
                    MessageBox.Show("Player with mark O wins !");
                }
                else if (CheckWiner() == 2)
                {
                    PlayerXWins++;
                    MessageBox.Show("Player with mark X wins !");
                }
                else if (turns == 9)
                {
                    MessageBox.Show("Draw !");
                }
                button.Enabled = false;
            }
            else
            {
                button.BackgroundImage = ((Image)(Properties.Resources.circle));
                button.BackgroundImageLayout = ImageLayout.Stretch;
                turns++;
                if (CheckWiner() == 1)
                {
                    PlayerOWins++;
                    MessageBox.Show("Player with mark O wins !");
                }
                else if (CheckWiner() == 2)
                {
                    PlayerXWins++;
                    MessageBox.Show("Player with mark X wins !");
                }
                else if (turns == 9)
                {
                    MessageBox.Show("Draw !");
                }
                button.Enabled = false;
            }
        }
         
        private int CheckWiner()
        {
            if (B00.BackgroundImage == B01.BackgroundImage && B01.BackgroundImage == B02.BackgroundImage)
            {
                if (B00.BackgroundImage == Properties.Resources.circle)
                {
                    return 1;
                }
                else if (B00.BackgroundImage == Properties.Resources.mark)
                {
                    return 2;
                }
            }
            else if (B10.BackgroundImage == B11.BackgroundImage && B11.BackgroundImage == B12.BackgroundImage)
            {
                if (B10.BackgroundImage == Properties.Resources.circle)
                {
                    return 1;
                }
                else if (B10.BackgroundImage == Properties.Resources.mark)
                {
                    return 2;
                }
            }
            else if (B20.BackgroundImage == B21.BackgroundImage && B21.BackgroundImage == B22.BackgroundImage)
            {
                if (B20.BackgroundImage == Properties.Resources.circle)
                {
                    return 1;
                }
                else if (B20.BackgroundImage == Properties.Resources.mark)
                {
                    return 2;
                }
            }
            else if (B00.BackgroundImage == B10.BackgroundImage && B10.BackgroundImage == B20.BackgroundImage)
            {
                if (B00.BackgroundImage == Properties.Resources.circle)
                {
                    return 1;
                }
                else if (B00.BackgroundImage == Properties.Resources.mark)
                {
                    return 2;
                }
            }
            else if (B01.BackgroundImage == B11.BackgroundImage && B11.BackgroundImage == B21.BackgroundImage)
            {
                if (B01.BackgroundImage == Properties.Resources.circle)
                {
                    return 1;
                }
                else if (B01.BackgroundImage == Properties.Resources.mark)
                {
                    return 2;
                }
            }
            else if (B02.BackgroundImage == B12.Image && B12.BackgroundImage == B22.BackgroundImage)
            {
                if (B02.BackgroundImage == Properties.Resources.circle)
                {
                    return 1;
                }
                else if (B02.BackgroundImage == Properties.Resources.mark)
                {
                    return 2;
                }
            }
            else if (B00.BackgroundImage == B11.BackgroundImage && B11.BackgroundImage == B22.BackgroundImage)
            {
                if (B00.BackgroundImage == Properties.Resources.circle)
                {
                    return 1;
                }
                else if (B00.BackgroundImage == Properties.Resources.mark)
                {
                    return 2;
                }
            }
            else if (B02.BackgroundImage == B11.Image && B11.BackgroundImage == B20.BackgroundImage)
            {
                if (B02.BackgroundImage == Properties.Resources.circle)
                {
                    return 1;
                }
                else if (B02.BackgroundImage == Properties.Resources.mark)
                {
                    return 2;
                }
            }
                return 3;
        }

        public enum TypeOfBox
        {
            Cross,
            Circle
        }
        public class tictactoePosision : Button
        {
            public TypeOfBox elementes { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeServer
{
    public partial class ChooseXO : Form
    {
        public static string playerChoice;
        typeOfGame test;
        public ChooseXO(typeOfGame t1)
        {
            test = t1;
            InitializeComponent();
        }

        private void ChooseXO_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseX_Click(object sender, EventArgs e)
        {
            playerChoice = "X";
            Play p1 = new Play(test, playerChoice);
            p1.Show();
            this.Hide();
        }

        private void btnChooseO_Click(object sender, EventArgs e)
        {
            playerChoice = "O";
            Play p1 = new Play(test, playerChoice);
            p1.Show();
            this.Hide();
        }

        private void btnChooseX_Click_1(object sender, EventArgs e)
        {
            playerChoice = "X";
            Play p1 = new Play(test, playerChoice);
            p1.Show();
            this.Hide();
        }

        private void btnChooseO_Click_1(object sender, EventArgs e)
        {

            playerChoice = "O";
            Play p1 = new Play(test, playerChoice);
            p1.Show();
            this.Hide();
        }
    }
}

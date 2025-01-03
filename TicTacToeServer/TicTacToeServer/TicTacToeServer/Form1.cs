using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public enum typeOfGame
    {
        playvscpu, playvsfriend, playonline

    }
    public partial class Form1 : Form
    {
        public static int ptNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlayCpu_Click(object sender, EventArgs e)
        {
            typeOfGame type = typeOfGame.playvscpu;
            this.Hide();
            ChooseXO cobj = new ChooseXO(type);
            cobj.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayFriend_Click(object sender, EventArgs e)
        {
            typeOfGame type = typeOfGame.playvsfriend;
            this.Hide();
            Play p1 = new Play(type);
            p1.Show();
        }

        private void btnPlayFriend_Click_1(object sender, System.EventArgs e)
        {  
            if (!string.IsNullOrEmpty(tBoxPortNum.Text))
            {
               
                if (int.TryParse(tBoxPortNum.Text, out ptNum))
                {
                    if (ptNum > 1024)
                    {
                        typeOfGame type = typeOfGame.playvsfriend;
                        this.Hide();
                        Play p1 = new Play(type);
                        p1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Use Port not in the range of 1-1023");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a port number!");
            }
        }

        private void btnPlayCpu_Click_1(object sender, System.EventArgs e)
        {
            typeOfGame type = typeOfGame.playvscpu;
            this.Hide();
            ChooseXO cobj = new ChooseXO(type);
            cobj.ShowDialog();
        }
    }
}


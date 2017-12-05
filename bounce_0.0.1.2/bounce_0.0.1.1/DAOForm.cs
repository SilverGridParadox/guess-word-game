using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bounce_0._0._1._1
{
    public partial class DAOForm : Form
    {
        DAO Users;


        public DAOForm()
        {
            Users = new DAO(@"D:\stuff\data.cfg");
            InitializeComponent();
        }




        private void DAOForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            regpanel.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Users.Login(loginLogin.Text, passwordLogin.Text))
            {
                Thread game = new Thread(new ThreadStart(gameStart));
                game.Start();
            }
            else
            {
                MessageBox.Show("Uncorrect Password");
            }
        }

        private void gameStart()
        {
            Application.Run(new GameWindow());
        }

        private void confirmRegist_Click(object sender, EventArgs e)
        {
            Users.Register(reglogin.Text, regpass.Text);
        }
    }
}

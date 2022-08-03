using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="admin" && txtPassword.Text=="admin")
            {
                new Form2().Show();
                this.Hide();

            }

            else
            {
                if (txtUserName.Text != "admin" && txtPassword.Text != "admin")
                {
                    MessageBox.Show("Usuario e senha incorretos, tente novamente");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }

                if (txtUserName.Text != "admin" && txtPassword.Text == "admin")
                {
                    MessageBox.Show("Usuario incorreto, insira novamente");
                    txtUserName.Clear();
                    txtUserName.Focus();
                }

                if (txtPassword.Text != "admin" && txtUserName.Text == "admin")
                {
                    MessageBox.Show("Senha incorreta, insira novamente");
                    txtPassword.Clear();
                    txtPassword.Focus();                  
                }
            }
        }

        private void limparCampos (object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void txtSair (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void iconExit (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword(object sender, EventArgs e)
        {

        }
    }
}

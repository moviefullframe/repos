using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authorization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form message = new Form();
            MessageBox.Show("Ваш логин:" + tbLogin.Text + "\nВаш пароль:" + tbPass.Text);
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            KeysComb(e, tbLogin.Text);
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            KeysComb(e, tbPass.Text);
        }
        private void KeysComb(KeyEventArgs e, String tb)
        {
            if (e.Alt && e.KeyCode == Keys.J)
            {
                MessageBox.Show(tb);
            }


        }
    }
}

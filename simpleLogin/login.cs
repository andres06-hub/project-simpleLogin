using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            //QUEMADO
            String user = "andres@mail.com";
            String pass = "123456";

            //OBTENGO los datos
            String userName = "";
            String password = "";
            try
            { 
                userName = txtUsername.Text.ToString();
                password = txtPasswork.Text.ToString();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("ERROR :: DATOS NULOS");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("ERROR :: Casting ");
            }

            //VALIDAR datos
            if(userName.Length > 0)
            {
                if(userName == user)
                {
                    if(password == pass)
                    {
                        Console.WriteLine("Login successful");
                    }
                }
                Console.WriteLine("Invalid Credentials!");
            }


        }
    }
}

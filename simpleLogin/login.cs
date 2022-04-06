using System;
using System.Collections;
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
            //Iniciamos
            iniciar();
        }

        private void iniciar()
        {
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
            ArrayList resultsLogin = validatedData(userName, password);
            //Obtener datos de la lista
            Boolean status = (bool)resultsLogin[0];
            String message = (String)resultsLogin[1];
            Console.WriteLine(message);
            //Validar resultsLogin
            if (status)
            {
                //True
                /**
                 Login Successful
                 */
                //Mostramos la ventana Register
                this.Hide();
                //Show Windows Register
                showRegister();
            }
            else
            {
                //False
            }
        }


        private ArrayList validatedData(String userName, String password)
        {

            //QUEMADO
            String user = "andres@mail.com";
            String pass = "123456";

            String message = "";

            //Array
            ArrayList listResulst = new ArrayList();

            //VALIDAR datos
            if (userName.Length > 0)
            {
                if(password.Length > 0)
                {
                    if (userName == user)
                    {
                        if (password == pass)
                        {
                            message = "Login successful";
                            MessageBox.Show(message, "", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                            listResulst.Add(true);
                            listResulst.Add(message);
                            return listResulst;
                        }
                        //Datos que retornamos
                        message = "Invalid Credentials";
                        MessageBox.Show(message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        listResulst.Add(false);
                        listResulst.Add(message);
                        return listResulst;
                    }
                    message = "Invalid Credentials!";
                    MessageBox.Show(message, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    listResulst.Add(false);
                    listResulst.Add(message);
                    return listResulst;
                }
                //Data null
                message = "Data Null";
                MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listResulst.Add(false);
                listResulst.Add(message);
                return listResulst;
            }
            //Invalid datos
            message = "Data Null";
            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listResulst.Add(false);
            listResulst.Add(message);
            return listResulst;
        }

        private void showRegister()
        {
            //Instanciamos la clase
            Register viewRegister = new Register();
            viewRegister.Show();
        }
    }
}

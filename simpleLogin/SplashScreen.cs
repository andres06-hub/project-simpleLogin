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
    public partial class SplashScreen : Form
    {

        public SplashScreen()
        {
            //Mostrar elementos
            InitializeComponent();
            //Mostrar progreso
            showProcess();
            // Se espera
         
            //Mostrar ventana login
            //showLogin();


                     
        }

        private void showProcess()
        {
            Action action = new Action(async () => {

                progressBar1.Maximum = 100;
                progressBar1.Minimum = 0;

                progressBar1.Value = 10;
                await Task.Delay(TimeSpan.FromSeconds(1));
                progressBar1.Value = 40;
                await Task.Delay(TimeSpan.FromSeconds(1));
                progressBar1.Value = 100;

                // Se espera
                await Task.Delay(TimeSpan.FromSeconds(2));
                //Se ocualta la ventana
                this.Hide();
                //Mostrar ventana login
                showLogin();
            });

            this.Shown += new EventHandler((sender, e) => {
                BeginInvoke(action);
            });

            
        }

        private void showLogin()
        {

            Login login = new Login();
            login.Show();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void showButton()
        {

        }

        private void SplashScreen_Load_1(object sender, EventArgs e)
        {

        }
    }
}

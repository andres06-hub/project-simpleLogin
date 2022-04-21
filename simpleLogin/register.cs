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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCantiHijos_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Manejar errores, Provider
            //NameEmpleado
            nameEmpleadoErrorProvider = new System.Windows.Forms.ErrorProvider();
            nameEmpleadoErrorProvider.SetIconAlignment(this.textBoxNameEmple, ErrorIconAlignment.MiddleRight);
            nameEmpleadoErrorProvider.SetIconPadding(this.textBoxNameEmple, 2);
            nameEmpleadoErrorProvider.BlinkRate = 1000;
            nameEmpleadoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;

            //Cantidad Hijos
            cantidadHijosErrorProvider = new System.Windows.Forms.ErrorProvider();
            cantidadHijosErrorProvider.SetIconAlignment(this.textBoxCantiHijos, ErrorIconAlignment.MiddleRight);
            cantidadHijosErrorProvider.SetIconPadding(this.textBoxCantiHijos, 2);
            cantidadHijosErrorProvider.BlinkRate = 100;
            cantidadHijosErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;

            //Sueldo basico
            sueldoBasicoErrorProvider = new System.Windows.Forms.ErrorProvider();
            sueldoBasicoErrorProvider.SetIconAlignment(this.textBoxSueldoBasic, ErrorIconAlignment.MiddleRight);
            sueldoBasicoErrorProvider.SetIconPadding(this.textBoxSueldoBasic, 2);
            sueldoBasicoErrorProvider.BlinkRate = 1000;
            sueldoBasicoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;


            //Obtenemos los datos

            if ((!isNameValid()))
            {
                //si no es valido
                nameEmpleadoErrorProvider.SetError(textBoxNameEmple, "ERROR Name");
            }
            else if(!isAmountSonsValid())
            {
                //Si no es valido
                cantidadHijosErrorProvider.SetError(textBoxCantiHijos, "ERROR Amount");
            }
            else if (!isSalaryValid())
            {
                //si no es valido
                sueldoBasicoErrorProvider.SetError(textBoxSueldoBasic, "ERROR salary");
            }
            else
            {

            }
        }

        //GET and VALIDATED data
        private Boolean isNameValid()
        {
            String nombreEmpleado = textBoxNameEmple.Text;
            if (!(nombreEmpleado.Length > 0))
            {
                return false;
            }
            return true;
        }
        private Boolean isAmountSonsValid()
        {
            //Creamos la vaiable de referencia
            int num;
            //Tratamos
            return int.TryParse(textBoxCantiHijos.Text, out num);
        }
        private Boolean isSalaryValid()
        {
            //creamos variable de referencia
            double salary;
            //Tratamos
            return double.TryParse(textBoxSueldoBasic.Text, out salary);
        }

    }
}

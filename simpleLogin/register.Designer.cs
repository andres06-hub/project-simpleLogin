
namespace simpleLogin
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ErrorProvider nameEmpleadoErrorProvider;
        private System.Windows.Forms.ErrorProvider cantidadHijosErrorProvider;
        private System.Windows.Forms.ErrorProvider sueldoBasicoErrorProvider;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSueldoBasic = new System.Windows.Forms.TextBox();
            this.lblNombreEmple = new System.Windows.Forms.Label();
            this.lblCantiHijos = new System.Windows.Forms.Label();
            this.lblSueldoBasico = new System.Windows.Forms.Label();
            this.textBoxNameEmple = new System.Windows.Forms.TextBox();
            this.textBoxCantiHijos = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtnM = new System.Windows.Forms.RadioButton();
            this.radioBtnT = new System.Windows.Forms.RadioButton();
            this.radioBtnF = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.checkNoSocio = new System.Windows.Forms.CheckBox();
            this.checkSaludo = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.04546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.95454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxSueldoBasic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNombreEmple, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCantiHijos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSueldoBasico, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNameEmple, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCantiHijos, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(69, 167);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 113);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxSueldoBasic
            // 
            this.textBoxSueldoBasic.Location = new System.Drawing.Point(121, 84);
            this.textBoxSueldoBasic.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxSueldoBasic.Name = "textBoxSueldoBasic";
            this.textBoxSueldoBasic.Size = new System.Drawing.Size(154, 20);
            this.textBoxSueldoBasic.TabIndex = 5;
            // 
            // lblNombreEmple
            // 
            this.lblNombreEmple.AutoSize = true;
            this.lblNombreEmple.Location = new System.Drawing.Point(15, 15);
            this.lblNombreEmple.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.lblNombreEmple.Name = "lblNombreEmple";
            this.lblNombreEmple.Size = new System.Drawing.Size(94, 13);
            this.lblNombreEmple.TabIndex = 0;
            this.lblNombreEmple.Text = "Nombre Empleado";
            // 
            // lblCantiHijos
            // 
            this.lblCantiHijos.AutoSize = true;
            this.lblCantiHijos.Location = new System.Drawing.Point(15, 52);
            this.lblCantiHijos.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.lblCantiHijos.Name = "lblCantiHijos";
            this.lblCantiHijos.Size = new System.Drawing.Size(90, 13);
            this.lblCantiHijos.TabIndex = 1;
            this.lblCantiHijos.Text = "Cantidad de Hijos";
            this.lblCantiHijos.Click += new System.EventHandler(this.lblCantiHijos_Click);
            // 
            // lblSueldoBasico
            // 
            this.lblSueldoBasico.AutoSize = true;
            this.lblSueldoBasico.Location = new System.Drawing.Point(15, 89);
            this.lblSueldoBasico.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.lblSueldoBasico.Name = "lblSueldoBasico";
            this.lblSueldoBasico.Size = new System.Drawing.Size(75, 13);
            this.lblSueldoBasico.TabIndex = 2;
            this.lblSueldoBasico.Text = "Sueldo Básico";
            // 
            // textBoxNameEmple
            // 
            this.textBoxNameEmple.Location = new System.Drawing.Point(121, 10);
            this.textBoxNameEmple.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxNameEmple.Name = "textBoxNameEmple";
            this.textBoxNameEmple.Size = new System.Drawing.Size(154, 20);
            this.textBoxNameEmple.TabIndex = 3;
            // 
            // textBoxCantiHijos
            // 
            this.textBoxCantiHijos.Location = new System.Drawing.Point(121, 47);
            this.textBoxCantiHijos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxCantiHijos.Name = "textBoxCantiHijos";
            this.textBoxCantiHijos.Size = new System.Drawing.Size(154, 20);
            this.textBoxCantiHijos.TabIndex = 4;
            this.textBoxCantiHijos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxSexo.Location = new System.Drawing.Point(100, 362);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(225, 77);
            this.groupBoxSexo.TabIndex = 1;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            this.groupBoxSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.13274F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.86726F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Controls.Add(this.radioBtnM, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioBtnT, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioBtnF, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(164, 26);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // radioBtnM
            // 
            this.radioBtnM.AutoSize = true;
            this.radioBtnM.Location = new System.Drawing.Point(53, 3);
            this.radioBtnM.Name = "radioBtnM";
            this.radioBtnM.Size = new System.Drawing.Size(34, 17);
            this.radioBtnM.TabIndex = 1;
            this.radioBtnM.TabStop = true;
            this.radioBtnM.Text = "M";
            this.radioBtnM.UseVisualStyleBackColor = true;
            // 
            // radioBtnT
            // 
            this.radioBtnT.AutoSize = true;
            this.radioBtnT.Location = new System.Drawing.Point(114, 3);
            this.radioBtnT.Name = "radioBtnT";
            this.radioBtnT.Size = new System.Drawing.Size(32, 17);
            this.radioBtnT.TabIndex = 2;
            this.radioBtnT.TabStop = true;
            this.radioBtnT.Text = "T";
            this.radioBtnT.UseVisualStyleBackColor = true;
            // 
            // radioBtnF
            // 
            this.radioBtnF.AutoSize = true;
            this.radioBtnF.Location = new System.Drawing.Point(3, 3);
            this.radioBtnF.Name = "radioBtnF";
            this.radioBtnF.Size = new System.Drawing.Size(31, 17);
            this.radioBtnF.TabIndex = 0;
            this.radioBtnF.TabStop = true;
            this.radioBtnF.Text = "F";
            this.radioBtnF.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(347, 416);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(76, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.richTextBox1);
            this.groupBoxResultados.Controls.Add(this.label1);
            this.groupBoxResultados.Location = new System.Drawing.Point(69, 470);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(354, 143);
            this.groupBoxResultados.TabIndex = 3;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 124);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(250, 653);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(348, 653);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // checkNoSocio
            // 
            this.checkNoSocio.AutoSize = true;
            this.checkNoSocio.Location = new System.Drawing.Point(100, 307);
            this.checkNoSocio.Name = "checkNoSocio";
            this.checkNoSocio.Size = new System.Drawing.Size(130, 17);
            this.checkNoSocio.TabIndex = 7;
            this.checkNoSocio.Text = "No socio de Sindicato";
            this.checkNoSocio.UseVisualStyleBackColor = true;
            // 
            // checkSaludo
            // 
            this.checkSaludo.AutoSize = true;
            this.checkSaludo.Location = new System.Drawing.Point(100, 331);
            this.checkSaludo.Name = "checkSaludo";
            this.checkSaludo.Size = new System.Drawing.Size(59, 17);
            this.checkSaludo.TabIndex = 8;
            this.checkSaludo.Text = "Saludo";
            this.checkSaludo.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 701);
            this.Controls.Add(this.checkSaludo);
            this.Controls.Add(this.checkNoSocio);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.register_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxSexo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNombreEmple;
        private System.Windows.Forms.Label lblCantiHijos;
        private System.Windows.Forms.Label lblSueldoBasico;
        private System.Windows.Forms.TextBox textBoxSueldoBasic;
        private System.Windows.Forms.TextBox textBoxNameEmple;
        private System.Windows.Forms.TextBox textBoxCantiHijos;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.RadioButton radioBtnT;
        private System.Windows.Forms.RadioButton radioBtnM;
        private System.Windows.Forms.RadioButton radioBtnF;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkNoSocio;
        private System.Windows.Forms.CheckBox checkSaludo;
    }
}
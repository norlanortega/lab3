using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        ArrayList listaPersonas = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Persona miCobalorador1 = new Persona();

                miCobalorador1.Id = 1;
                miCobalorador1.Nombre = "Juan";
                miCobalorador1.Apellido = "Pérez";
                miCobalorador1.correo = "juan.perez@example.com";
                miCobalorador1.FechaNA = new DateTime(1990, 5, 15);
                miCobalorador1.Salario = 50000;

            listaPersonas.Add(miCobalorador1);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                errorProvider1.SetError(txtId, "El campo ID no puede estar vacío.");
                txtId.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtId, "");
            }


            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "El campo Nombre no puede estar vacío.");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }


            if (txtApellido.Text == "")
            {
                errorProvider1.SetError(txtApellido, "El campo Apellido no puede estar vacío.");
                txtApellido.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellido, "");
            }


            if (Utilidades.EscorreoValido(txtCorreo.Text) == false)
            {
                errorProvider1.SetError(txtCorreo, "ingrese un correo valido");
                txtCorreo.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }

            decimal salario;
            if ( !decimal.TryParse(txtSalario.Text, out salario))
            {
                errorProvider1.SetError(txtSalario, "El campo Salario no puede estar vacío.");
                txtSalario.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalario, "");
            }

            Persona micolaborador1 = new Persona();
            micolaborador1.Id = int.Parse(txtId.Text);
            micolaborador1.Nombre = txtNombre.Text;
            micolaborador1.Apellido = txtApellido.Text;
            micolaborador1.correo = txtCorreo.Text;
            micolaborador1.FechaNA = dtpFechaNac.Value;
            micolaborador1.Salario = salario;
            listaPersonas.Add(micolaborador1);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaPersonas;


        }

    }
}

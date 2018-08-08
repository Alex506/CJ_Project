using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        Formu info = new Formu();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                info.NombreCompleto = txtNombre.Text;
                info.PrimerApellido = txtApellido.Text;
                info.SegundoApellido = txtSegundoApellido.Text;
                info.TelefonoHabitacion = txtHabitacion.Text;
                info.TelefonoCelular = txtCelular.Text;
                info.EstadoCivil = cbxEstado.SelectedText;
                info.Provincia = cbxProvincias.SelectedText;
                info.Canton = cbxCantones.SelectedText;
                info.Distrito = cbxDistritos.SelectedText;
                info.OtrasSeñas = txtSeñas.Text;
                info.NombreConyuge = txtNombreC.Text;
                info.LugarTrabajo = txtTrabajo.Text;
                info.Salario = txtSalario.Text;
                info.NombreFamiliar = txtNombreF.Text;
                info.Direccion = txtDireccion.Text;
                info.Telefono = txtTelefono.Text;

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtSegundoApellido.Text) || string.IsNullOrEmpty(txtHabitacion.Text) ||
                    string.IsNullOrEmpty(txtCelular.Text) || cbxEstado.SelectedIndex == -1 || cbxProvincias.SelectedIndex == -1 || cbxCantones.SelectedIndex == -1 || cbxDistritos.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(txtSeñas.Text) || string.IsNullOrEmpty(txtNombreC.Text) || string.IsNullOrEmpty(txtTrabajo.Text) || string.IsNullOrEmpty(txtSalario.Text) || string.IsNullOrEmpty(txtNombreF.Text) ||
                    string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Es necesario llenar el formulario de forma completa ");
                }
                else
                {
                    tabControl1.SelectedTab = tabPage2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                info.Patrono = txtPatrono.Text;
                if (rbtnSi.Checked)
                {
                    info.Propiedad = true;
                }
                else
                {
                    info.Propiedad = false;
                }
                info.Oficina = txtOficina.Text;
                info.puestoActual = txtPuesto.Text;
                info.TelefonoTrabajo = txtTel.Text;
                info.SalarioNominal = txtBruto.Text;
                info.SalarioNeta = txtNeto.Text;
                info.FechaIngreso = fecha.Value;

                if (string.IsNullOrEmpty(txtPatrono.Text) || string.IsNullOrEmpty(txtPuesto.Text) || string.IsNullOrEmpty(txtTel.Text) || string.IsNullOrEmpty(txtBruto.Text) || string.IsNullOrEmpty(txtNeto.Text) ||
                    (rbtnSi.Checked == false && rbtnNo.Checked == false))
                {
                    MessageBox.Show("Es necesario llenar el formulario de manera completa ");
                }
                else
                {
                    tabControl1.SelectedTab = tabPage3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    }


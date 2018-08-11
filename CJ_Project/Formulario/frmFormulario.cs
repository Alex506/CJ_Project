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
    public partial class frmFormulario : Form
    {
        Formu info = new Formu();
        public frmFormulario()
        {

            InitializeComponent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
        private void sig_Click(object sender, EventArgs e)
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

        private void frmFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo);
            if (dr.ToString().Equals("Yes"))
            {
                this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                info.MontoSolicitado = txtMonto.Text;
                info.Plazo = txtPlazo.Text;
                info.Interes = txtInteres.Text;
                info.TipoCredito = cbxTipoCredito.SelectedText;
                if (string.IsNullOrEmpty(txtMonto.Text) || string.IsNullOrEmpty(txtPlazo.Text) || string.IsNullOrEmpty(txtInteres.Text) || cbxTipoCredito.SelectedIndex == -1)
                {
                    MessageBox.Show("Es necesario llenar el formulario de manera completa ");
                }
                else
                {
                    tabControl1.SelectedTab = tabPage4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        
    }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                info.PrimerApellido1 = txtPrimerA.Text;
                info.SegundoApellido1 = txtSegundoA.Text;
                info.NombreCompleto1 = txtNombreCom.Text;
                info.Cedula1 = txtCed.Text;
                info.EstadoCivil1 = cbxEstadoF1.SelectedText;
                info.Puesto1 = txtPuestoF1.Text;
                info.Patrono1 = txtPatronoF1.Text;
                info.TelefonoHabitacion1 = txtTelefonoF1.Text;
                info.TelefonoOficina1 = txtTelOficinaF1.Text;
                info.TelefonoCelular1 = txtCelF1.Text;
                info.Provincia1 = cbxProvinciaF1.SelectedText;
                info.Canton1 = cbxCantonF1.SelectedText;
                info.Distrito1 = cbxDistritoF1.SelectedText;
                info.OtraSena1 = txtSenasF1.Text;
                info.SalarioBruto1 = txtBrutoF1.Text;
                info.SalarioNeto1 = txtNetoF1.Text;
                info.FechaIngreso1 = fecha1.Value;
                if (rbtnSiF1.Checked)
                {
                    info.Propiedad1 = true;

                }
                else
                {
                    info.Propiedad1 = false;
                }
                if (string.IsNullOrEmpty(txtPrimerA.Text) || string.IsNullOrEmpty(txtSegundoA.Text) || string.IsNullOrEmpty(txtNombreCom.Text) || string.IsNullOrEmpty(txtCed.Text) || cbxEstadoF1.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(txtPuestoF1.Text) || string.IsNullOrEmpty(txtPatronoF1.Text) || string.IsNullOrEmpty(txtTelefonoF1.Text) || string.IsNullOrEmpty(txtTelOficinaF1.Text) ||
                    string.IsNullOrEmpty(txtCelF1.Text) || cbxProvinciaF1.SelectedIndex == -1 || cbxCantonF1.SelectedIndex == -1 || cbxDistritoF1.SelectedIndex == -1 || string.IsNullOrEmpty(txtSenasF1.Text) ||
                    string.IsNullOrEmpty(txtBrutoF1.Text) || string.IsNullOrEmpty(txtNetoF1.Text) || (rbtnSiF1.Checked == false && rbtnNoF1.Checked == false))
                {
                    MessageBox.Show("Es necesario llenar el formulario de manera completa ");
                }
                else
                {
                    tabControl1.SelectedTab = tabPage5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                info.PrimerApellido2 = txtPrimerAF2.Text;
                info.SegundoApellido2 = txtSegundoAF2.Text;
                info.NombreCompleto2 = txtNombreComF2.Text;
                info.Cedula2 = txtCedF2.Text;
                info.EstadoCivil2 = cbxEstadoF2.SelectedText;
                info.Puesto2 = txtPuestoF2.Text;
                info.Patrono2 = txtPatronoF2.Text;
                info.TelefonoHabitacion2 = txtTelefonoF2.Text;
                info.TelefonoOficina2 = txtTelOF2.Text;
                info.TelefonoCelular2 = txtCelF2.Text;
                info.Provincia2 = cbxProvinciaF2.SelectedText;
                info.Canton2 = cbxCantonF2.SelectedText;
                info.Distrito2 = cbxDistritoF2.SelectedText;
                info.OtraSena2 = txtSeñasF2.Text;
                info.SalarioBruto2 = txtBrutoF2.Text;
                info.SalarioNeto2 = txtNetoF2.Text;
                info.FechaIngreso2 = fecha2.Value;

                if (rbtnSiF2.Checked)
                {
                    info.Propiedad2 = true;

                }
                else
                {
                    info.Propiedad2 = false;
                }
                if (string.IsNullOrEmpty(txtPrimerAF2.Text) || string.IsNullOrEmpty(txtSegundoAF2.Text) || string.IsNullOrEmpty(txtNombreComF2.Text) || string.IsNullOrEmpty(txtCedF2.Text) || cbxEstadoF2.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(txtPuestoF2.Text) || string.IsNullOrEmpty(txtPatronoF2.Text) || string.IsNullOrEmpty(txtTelefonoF2.Text) || string.IsNullOrEmpty(txtTelOF2.Text) ||
                    string.IsNullOrEmpty(txtCelF2.Text) || cbxProvinciaF2.SelectedIndex == -1 || cbxCantonF2.SelectedIndex == -1 || cbxDistritoF2.SelectedIndex == -1 || string.IsNullOrEmpty(txtSeñasF2.Text) ||
                    string.IsNullOrEmpty(txtBrutoF2.Text) || string.IsNullOrEmpty(txtNetoF2.Text) || (rbtnSiF1.Checked == false && rbtnNoF1.Checked == false))
                {
                    MessageBox.Show("Es necesario llenar el formulario de manera completa ");
                }
                else
                {
                    tabControl1.SelectedTab = tabPage6;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

  


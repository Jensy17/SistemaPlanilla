using SistemaPlanilla.BLL.Common;
using SistemaPlanilla.DAL.Common;
using SistemaPlanilla.Entity.Entidades;
using SistemaPlanilla.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPlanilla.UI.Formularios.Seguridad
{
    public partial class FrmConfiguracionConexion : Form
    {
        public FrmConfiguracionConexion()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            errorIcon.Clear();

            bool valido = true;

            if (!ValidationHelper.Requerido(txtServidor, errorIcon, "Ingrese el nombre del servidor"))
                valido = false;
            if (!ValidationHelper.Requerido(txtBaseDatos, errorIcon, "Ingrese el nombre de la base de datos"))
                valido = false;
            if (!ValidationHelper.Requerido(txtUsuarioSql, errorIcon, "Ingrese el nombre del Usuario"))
                valido = false;
            if (!ValidationHelper.Requerido(txtClave, errorIcon, "Ingrese la contraseña correcta"))
                valido = false;
            return valido;
        }
        private void panelDB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureCerrar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Cancelar();
        }

        private async void btnProbar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            ConexionBLL conexionBLL = new();

            bool ok = await conexionBLL.ProbarConexion(
                txtServidor.Text.Trim(),
                txtBaseDatos.Text.Trim(),
                txtUsuarioSql.Text.Trim(),
                txtClave.Text);

            if (ok)
            {
                MessageBox.Show("Conexión exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = true;
                txtServidor.Enabled = false;
                txtBaseDatos.Enabled = false;
                txtUsuarioSql.Enabled = false;
                txtClave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al conectar a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = false;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ConexionEntity config = new()
            {
                Servidor = txtServidor.Text.Trim(),
                BaseDatos = txtBaseDatos.Text.Trim(),
                UsuarioSql = txtUsuarioSql.Text.Trim(),
                Password = txtClave.Text.Trim()
            };

            ConfiguracionDAL dal = new();

            bool resultado = dal.Guardar(config);

            if (!resultado)
            {
                MessageBox.Show("No fue posible guardar la configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Configuración guardada correctamente", "Configuración Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfiguracionConexion_Shown(object sender, EventArgs e)
        {
            RedondearControles.RedondearControl(this, 25);
            RedondearControles.RedondearControl(panel1, 25);
            RedondearControles.RedondearControl(panelServidor, 25);
            RedondearControles.RedondearControl(panelDB, 25);
            RedondearControles.RedondearControl(panelUser, 25);
            RedondearControles.RedondearControl(panelPass, 25);
        }
    }
}

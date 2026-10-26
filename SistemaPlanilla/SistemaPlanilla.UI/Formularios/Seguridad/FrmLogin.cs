using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SistemaPlanilla.UI.Formularios.Seguridad
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerPassword_Click(object sender, EventArgs e)
        {

        }

        private void disenoLabel10_Click(object sender, EventArgs e)
        {

        }

        private void disenoTablelayoutpanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void disenoTablelayoutpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            RedondearControles.RedondearControl(this, 25);
            RedondearControles.RedondearControl(panelUsuario, 25);
            RedondearControles.RedondearControl(panelConfirmacion, 25);
            RedondearControles.RedondearControl(panelPassword, 25);
            RedondearControles.RedondearControl(disenoTablelayoutpanel3, 25);
            RedondearControles.RedondearControl(disenoTablelayoutpanel1, 25);
        }

        private void pictureCerrar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void EstablecerPasswordVisible(bool visible)
        {
            // PasswordChar también debe limpiarse: desactivar UseSystemPasswordChar
            // no muestra el texto si el Designer dejó una máscara explícita.
            txtPassword.PasswordChar = txtConfirmacion.PasswordChar = '\0';
            txtPassword.UseSystemPasswordChar = txtConfirmacion.UseSystemPasswordChar = !visible;
            btnVerPassword.IconChar = visible ? FontAwesome.Sharp.IconChar.Eye : FontAwesome.Sharp.IconChar.EyeSlash;
            //btnVerPassword.IconColor = visible ? AcentoAcceso : TemaNomina.Secundario;
            //btnVerPassword.BackColor = visible ? TemaNomina.Fondo : Color.White;
            btnVerPassword.AccessibleName = visible ? "Ocultar contraseña" : "Mostrar contraseña";
        }

        private void btnVerPassword_Click_1(object sender, EventArgs e)
        {
            EstablecerPasswordVisible(txtPassword.UseSystemPasswordChar);
        }
    }
}

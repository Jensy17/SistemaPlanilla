using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaPlanilla.UI.Formularios.Empresa;
using SistemaPlanilla.UI.Helpers;
using SistemaPlanilla.UI.Formularios.Colaboradores;

namespace SistemaPlanilla.UI.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private Form? formularioActivo;
        private bool _cerrandoSesion = false;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void iconAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            //Form AbrirFormulario = new FrmEmpresa();
            //AbrirFormulario.Show();
            NavegacionHelper.AbrirFormulario(new FrmEmpresa(), panelContenedor, ref formularioActivo, btnEmpresa);
        }

        #region Sidebar
        private void btnSalir_Click(object sender, EventArgs e)
        {
            SesionHelper.CerrarSesion(this);
        }

        #endregion

        #region Métodos
        public void CerrarSesion()
        {
            _cerrandoSesion = true;
            DialogResult = DialogResult.Retry;
            Close();
        }
        #endregion

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cerrandoSesion)
                return;

            DialogResult respuesta = MessageBox.Show("¿Seguro que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                e.Cancel = true;
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmColaboradores(), panelContenedor, ref formularioActivo, btnColaboradores);
        }
    }
}

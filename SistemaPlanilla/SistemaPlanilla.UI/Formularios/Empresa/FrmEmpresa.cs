using SistemaPlanilla.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPlanilla.UI.Formularios.Empresa
{
    public partial class FrmEmpresa : Form
    {
        private Form? formularioActivo;
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NavegacionHelper.AbrirFormulario(new FrmAgregarEmpresa(), panel1, ref formularioActivo, btnAdd);

        }

        private void disenoFlowlayoutpanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void disenoButton8_Click(object sender, EventArgs e)
        {
            //PaginaActual = 1;

            //await MostrarDatosAsync(PaginaActual, TamPagina, txtBuscar.Text);
        }
    }
}

using SistemaPlanilla.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPlanilla.BLL
{
    public class SistemaBLL
    {
        private readonly SistemaDAL _sistemaDAL;

        public SistemaBLL()
        {
            _sistemaDAL = new SistemaDAL();
        }

        public async Task CrearAdministradorInicialAsync()
        {
            await _sistemaDAL.CrearAdministradorInicialAsync();
        }
    }
}

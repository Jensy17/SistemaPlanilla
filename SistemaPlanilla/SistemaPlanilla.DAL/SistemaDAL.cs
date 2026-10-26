using Microsoft.Data.SqlClient;
using SistemaPlanilla.DAL.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaPlanilla.DAL
{
    public class SistemaDAL
    {
        public async Task CrearAdministradorInicialAsync()
        {
            try
            {
                using SqlConnection cn = Conexion.ObtenerConexion();
                using SqlCommand cmd = new ("SP_CrearAdministradorInicial", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                await cn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

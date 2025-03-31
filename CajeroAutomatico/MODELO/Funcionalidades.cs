using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.MODELO
{
    internal class Funcionalidades
    {

        ConexionDB conexionDB = new ConexionDB();
        public void Retirar(TextBox txbValorIngresado)
        {
            using(SqlConnection conexion = conexionDB.AbrirConexion())
            {
                string QuerySelect = "select Saldo From CUENTAS where IdUsuario = @idusuario";

                int IdUsuario = 123456;
                int SaldoUsuario = 0;

                using (SqlCommand ComandoSelect = new SqlCommand(QuerySelect,conexion))
                {
                    ComandoSelect.Parameters.AddWithValue("@idusuario", IdUsuario);
                    object valor = ComandoSelect.ExecuteScalar();

                    if( valor != null)
                    {
                        SaldoUsuario = Convert.ToInt32(valor);
                    }
                }

                int ValorIngresado = Convert.ToInt32(txbValorIngresado.Text);

                int NuevoSaldo = SaldoUsuario - ValorIngresado;


                string QueryUpdate = "UPDATE CUENTAS SET Saldo = @NuevoSaldo WHERE IdUsuario = @IdUsuario";

                using(SqlCommand ComandoUpdate = new SqlCommand(QueryUpdate, conexion))
                {
                    ComandoUpdate.Parameters.AddWithValue("@NuevoSaldo", NuevoSaldo);
                    ComandoUpdate.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                    ComandoUpdate.ExecuteNonQuery();
                }
            }
        }
        /*
         ya se ejecuta la consulta y funcina correctamente
         HACE FALTA:
           verificar si el saldo a retirar es valido
           añadir mensaje de que fue exitoso el retiro(no como boton si no como texto en un label)
        */
    }
}

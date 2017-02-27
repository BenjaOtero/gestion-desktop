using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public static class MercadoLibreDAL
    {

        public static DataSet GetData()
        {
            MySqlConnection SqlConnection1;
            MySqlDataAdapter SqlDataAdapter1;
            MySqlCommand SqlSelectCommand1;
            SqlConnection1 = DALBase.GetConnection();
            SqlDataAdapter1 = new MySqlDataAdapter();
            SqlSelectCommand1 = new MySqlCommand("MlDatos_Listar", SqlConnection1);
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1;
            SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
            DataSet datos = new DataSet();
            SqlDataAdapter1.Fill(datos);
            SqlConnection1.Close();
            return datos;
        }

    }
}

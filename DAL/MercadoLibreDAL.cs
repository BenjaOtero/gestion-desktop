using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public static class MercadoLibreDAL
    {

        public static string GetAccessToken()
        {
            MySqlConnection SqlConnection1;
            MySqlDataAdapter SqlDataAdapter1;
            MySqlCommand SqlSelectCommand1;
            SqlConnection1 = DALBase.GetConnection();
            SqlDataAdapter1 = new MySqlDataAdapter();
            SqlSelectCommand1 = new MySqlCommand("MercadoLibreAccessToken_Listar", SqlConnection1);
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1;
            SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
            DataTable datos = new DataTable();
            SqlDataAdapter1.Fill(datos);
            SqlConnection1.Close();
            string access_token = datos.Rows[0]["access_token"].ToString();
            return access_token;
        }

        public static DataSet GetData()
        {
            MySqlConnection SqlConnection1;
            MySqlDataAdapter SqlDataAdapter1;
            MySqlCommand SqlSelectCommand1;
            SqlConnection1 = DALBase.GetConnection();
            SqlDataAdapter1 = new MySqlDataAdapter();
            SqlSelectCommand1 = new MySqlCommand("MercadoLibreDatos_Listar", SqlConnection1);
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1;
            SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
            DataSet datos = new DataSet();
            SqlDataAdapter1.Fill(datos);
            SqlConnection1.Close();
            return datos;
        }

        public static DataTable GetDataPublicar()
        {
            MySqlConnection SqlConnection1;
            MySqlDataAdapter SqlDataAdapter1;
            MySqlCommand SqlSelectCommand1;
            SqlConnection1 = DALBase.GetConnection();
            SqlDataAdapter1 = new MySqlDataAdapter();
            SqlSelectCommand1 = new MySqlCommand("MercadoLibre_Publicar", SqlConnection1);
            SqlDataAdapter1.SelectCommand = SqlSelectCommand1;
            SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
            DataTable datos = new DataTable();
            SqlDataAdapter1.Fill(datos);
            SqlConnection1.Close();
            return datos;
        }
    }
}

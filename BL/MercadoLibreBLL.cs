using System.Data;

namespace BL
{
    public static class MercadoLibreBLL
    {

        public static DataSet GetData()
        {
            DataSet datos = DAL.MercadoLibreDAL.GetData();
            return datos;
        }

        public static DataTable GetDataPublicar()
        {
            DataTable datos = DAL.MercadoLibreDAL.GetDataPublicar();
            return datos;
        }
    }
}

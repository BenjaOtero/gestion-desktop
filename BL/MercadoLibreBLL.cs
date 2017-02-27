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

    }
}

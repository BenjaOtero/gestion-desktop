using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockVentas.Mercado_Libre
{
    class create_read_json
    {
    }

    public class PublicarVariacion
    {
        public string title { get; set; }
        public string category_id { get; set; }
        public double price { get; set; }
        public string currency_id { get; set; }
        public string buying_mode { get; set; }
        public string listing_type_id { get; set; }
        public string condition { get; set; }
        public string description { get; set; }
        public List<variations> variations { get; set; }
    }

    public class variations
    {
        public List<attribute_combinations> attribute_combinations { get; set; }
        public int price { get; set; }
        public int available_quantity { get; set; }
        public List<string> picture_ids { get; set; }
        public object seller_custom_field { get; set; }
    }

    public class attribute_combinations
    {
        public string id { get; set; }
        public string value_id { get; set; }
    }
}

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
        public List<Picture> pictures { get; set; }
        public List<variations> variations { get; set; }
    }

    public class Picture
    {
        public string id { get; set; }
        public string source { get; set; }
        public string secure_url { get; set; }
        public string size { get; set; }
        public string max_size { get; set; }
        public string quality { get; set; }
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

    //////////////////////////////////////


  /*  public class PublicarItemRoot
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string title { get; set; }
        public object subtitle { get; set; }
        public int seller_id { get; set; }
        public string category_id { get; set; }
        public object official_store_id { get; set; }
        public int price { get; set; }
        public int base_price { get; set; }
        public object original_price { get; set; }
        public string currency_id { get; set; }
        public int initial_quantity { get; set; }
        public int available_quantity { get; set; }
        public int sold_quantity { get; set; }
        public string buying_mode { get; set; }
        public string listing_type_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime stop_time { get; set; }
        public string condition { get; set; }
        public string permalink { get; set; }
        public string thumbnail { get; set; }
        public string secure_thumbnail { get; set; }
        public Picture[] pictures { get; set; }
        public object video_id { get; set; }
        public Description[] descriptions { get; set; }
        public bool accepts_mercadopago { get; set; }
        public object[] non_mercado_pago_payment_methods { get; set; }
        public Shipping shipping { get; set; }
        public string international_delivery_mode { get; set; }
        public Seller_Address seller_address { get; set; }
        public object seller_contact { get; set; }
        public Location location { get; set; }
        public Geolocation geolocation { get; set; }
        public object[] coverage_areas { get; set; }
        public Attribute[] attributes { get; set; }
        public object[] warnings { get; set; }
        public string listing_source { get; set; }
        public Variation[] variations { get; set; }
        public string status { get; set; }
        public object[] sub_status { get; set; }
        public string[] tags { get; set; }
        public object warranty { get; set; }
        public object catalog_product_id { get; set; }
        public string domain_id { get; set; }
        public object parent_item_id { get; set; }
        public object differential_pricing { get; set; }
        public object[] deal_ids { get; set; }
        public bool automatic_relist { get; set; }
        public DateTime date_created { get; set; }
        public DateTime last_updated { get; set; }
    }

    public class Shipping
    {
        public string mode { get; set; }
        public bool local_pick_up { get; set; }
        public bool free_shipping { get; set; }
        public object methods { get; set; }
        public object dimensions { get; set; }
        public object[] tags { get; set; }
        public string logistic_type { get; set; }
    }

    public class Seller_Address
    {
        public int id { get; set; }
        public string comment { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Country country { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public Search_Location search_location { get; set; }
    }

    public class City
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class State
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Country
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Search_Location
    {
        public Neighborhood neighborhood { get; set; }
        public City1 city { get; set; }
        public State1 state { get; set; }
    }

    public class Neighborhood
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class City1
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class State1
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Location
    {
    }

    public class Geolocation
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

    public class Picture
    {
        public string id { get; set; }
        public string url { get; set; }
        public string secure_url { get; set; }
        public string size { get; set; }
        public string max_size { get; set; }
        public string quality { get; set; }
    }

    public class Description
    {
        public string id { get; set; }
    }

    public class Attribute
    {
        public string id { get; set; }
        public string name { get; set; }
        public string value_id { get; set; }
        public string value_name { get; set; }
        public string attribute_group_id { get; set; }
        public string attribute_group_name { get; set; }
    }

    public class Variation
    {
        public long id { get; set; }
        public Attribute_Combinations[] attribute_combinations { get; set; }
        public int price { get; set; }
        public int available_quantity { get; set; }
        public int sold_quantity { get; set; }
        public string[] picture_ids { get; set; }
        public object seller_custom_field { get; set; }
        public object catalog_product_id { get; set; }
    }

    public class Attribute_Combinations
    {
        public string id { get; set; }
        public string name { get; set; }
        public string value_id { get; set; }
        public string value_name { get; set; }
    }*/

}

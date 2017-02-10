using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Drawing.Text;
using System.Web;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using MercadoLibre.SDK;
using HttpParamsUtility;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;

namespace StockVentas.Mercado_Libre
{
    public partial class frmPublicar : Form
    {
        string mAuthURL;
        MeliApiService meli;

        public frmPublicar()
        {
            InitializeComponent();
        }

        private void frmPublicar_Load(object sender, EventArgs e)
        {
            meli = new MeliApiService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mAuthURL = meli.GetAuthUrl(577247158873150, MercadoLibre.SDK.Meta.MeliSite.Argentina, "https://trendsistemas.com/ml_response.php");
            Uri myUri = new Uri(mAuthURL);
            System.Diagnostics.Process.Start(@mAuthURL);
            meli.Credentials = new MercadoLibre.SDK.MeliCredentials(MercadoLibre.SDK.Meta.MeliSite.Argentina, 577247158873150, "lTGAzLn0QBkr7yrQWPc4yb88sPwnVksS");
            //APP_USR-577247158873150-012817-cd7e2cade3e89b6863bbf9452df3319d__E_G__-241962277
        }

        private void btnAccessToken_Click(object sender, EventArgs e)
        {
            meli.AuthorizeAsync(textBox1.Text, "https://trendsistemas.com/ml_response.php");
            //  GetVariacion();
            GetCategoriasRopa(); 
        }

        async void GetCategoriasRopa()
        {
            var childrens = await meli.GetAsync<RootobjectSub>("/categories/MLA1430");
            lstCategoriasRopa.DataSource = childrens.children_categories.ToArray();
            lstCategoriasRopa.ValueMember = "id";
            lstCategoriasRopa.DisplayMember = "name";
        }

        private void lstCategories_DoubleClick(object sender, EventArgs e)
        {
            GetSubcategorias1();
        }

        private void lstSubcategorias1_DoubleClick(object sender, EventArgs e)
        {
            GetSubcategorias2();
        }

        private void lstSubcategorias2_DoubleClick(object sender, EventArgs e)
        {
            GetSubcategorias3();
        }

        private void lstSubcategorias3_DoubleClick(object sender, EventArgs e)
        {
            GetSubcategorias4();
        }

        private void lstSubcategorias4_DoubleClick(object sender, EventArgs e)
        {

        }

        async void GetSubcategorias1()
        {
            var childrens = await meli.GetAsync<RootobjectSub>("/categories/" + lstCategoriasRopa.SelectedValue.ToString());

            lstSubcategorias1.DataSource = childrens.children_categories.ToArray();
            lstSubcategorias1.ValueMember = "id";
            lstSubcategorias1.DisplayMember = "name";
        }

        async void GetSubcategorias2()
        {
            var childrens = await meli.GetAsync<RootobjectSub>("/categories/" + lstSubcategorias1.SelectedValue.ToString());

            lstSubcategorias2.DataSource = childrens.children_categories.ToArray();
            lstSubcategorias2.ValueMember = "id";
            lstSubcategorias2.DisplayMember = "name";
        }

        async void GetSubcategorias3()
        {
            var childrens = await meli.GetAsync<RootobjectSub>("/categories/" + lstSubcategorias2.SelectedValue.ToString());
            if (childrens.children_categories.ToArray().Count() > 0)
            {
                lstSubcategorias3.DataSource = childrens.children_categories.ToArray();
                lstSubcategorias3.ValueMember = "id";
                lstSubcategorias3.DisplayMember = "name";
            }
            else
            {

            }
        }

        async void GetSubcategorias4()
        {
            var childrens = await meli.GetAsync<RootobjectSub>("/categories/" + lstSubcategorias3.SelectedValue.ToString());
            if (childrens.children_categories.ToArray().Count() > 0)
            {
                lstSubcategorias4.DataSource = childrens.children_categories.ToArray();
                lstSubcategorias4.ValueMember = "id";
                lstSubcategorias4.DisplayMember = "name";
            }
            else
            {

            }
        }

        //por ahora no se usa el metodo porque el soft es solo para ropa y zapatos
        async void GetCategoriesGenerales()
        {
            var categories = await meli.GetAsync<Categories[]>("/sites/MLA/categories");
            lstCategoriasRopa.DataSource = categories;
            lstCategoriasRopa.ValueMember = "id";
            lstCategoriasRopa.DisplayMember = "name";
            lstCategoriasRopa.SelectedItem = -1;
        }

        async void GetVariacion()
        {
            var p = new HttpParams().Add("access_token", "APP_USR-577247158873150-012709-17a3d094660926e5af83db3bf9f8c92e__G_K__-241962277")
            .Add("you can chain", "the method calls");
            //users/{USER_ID}/items/search
            var articulos = await meli.GetAsync("users/241962277,/items/search");
            var variaciones = await meli.GetAsync<Variation[]>("items/MLA651764557/variations");
            foreach (var variacion in variaciones)
            {
                var variacionAtomica = variacion.attribute_combinations.ToList();
                string color;
                string talle;
                int color_talle = 0;
                foreach (var variacionSubAtomica in variacionAtomica)
                {
                    if (color_talle == 0)
                    {
                        color = variacionSubAtomica.value_name;
                        color_talle++;
                    }
                    else
                    {
                        talle = variacionSubAtomica.value_name;
                    }
                }
            }

            // var variacion =  variaciones[0].attribute_combinations.ToList();

            /*  var variaciones = await meli.GetAsync("items/MLA649205015", p);
              if (variaciones.IsSuccessStatusCode)
              {
                  //  string jsonstring = await variaciones.Content.ReadAsStringAsync();                
              }
              var categories = await meli.GetAsync("/sites/MLB/categories");*/
        }

        private void btnCreateJson_Click(object sender, EventArgs e)
        {
          /*  PublicarVariacion publicarVariacion = new PublicarVariacion();
            publicarVariacion.title = "Articulo automatizado";
            publicarVariacion.category_id = "MLA370641";
            publicarVariacion.price = 10000;
            publicarVariacion.currency_id = "ARS";
            publicarVariacion.buying_mode = "buy_it_now";
            publicarVariacion.listing_type_id = "bronze";
            publicarVariacion.condition = "new";
            publicarVariacion.description = "Item de test - no ofertar -";
            publicarVariacion.variations = new List<variations>{
                            new variations() {
                            attribute_combinations = new List<attribute_combinations> {
                                new attribute_combinations() {id = "83000", value_id = "92028" },
                                new attribute_combinations() {id = "73002", value_id = "82071" }
                          },
                            picture_ids = new List<string> { "https://trendsistemas.com/ml_images/050003.jpg", "https://trendsistemas.com/ml_images/050004.jpg"},
                            seller_custom_field = "050001",
                            available_quantity = 2,
                            price = 10
                          },
                            new variations() {
                            attribute_combinations = new List<attribute_combinations> {
                                new attribute_combinations() {id = "83000", value_id = "92028" },
                                new attribute_combinations() {id = "73002", value_id = "82069" }
                          },
                            picture_ids = new List<string> { "https://trendsistemas.com/ml_images/050003.jpg", "https://trendsistemas.com/ml_images/050004.jpg"},
                            seller_custom_field = "050001",
                            available_quantity = 2,
                            price = 10
                          }
                      };
            string json = new JavaScriptSerializer().Serialize(publicarVariacion);*/
        }

    }

    /// <Clases>
    /// //////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
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
    }


    public class Rootobject
    {
        public Categories[] Property1 { get; set; }
    }

    public class Categories
    {
        public string id { get; set; }
        public string name { get; set; }
    }




    public class RootobjectSub
    {
        public string id { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public string permalink { get; set; }
        public int total_items_in_this_category { get; set; }
        public Path_From_Root[] path_from_root { get; set; }
        public Children_Categories[] children_categories { get; set; }
        public string attribute_types { get; set; }
        public Settings settings { get; set; }
        public object meta_categ_id { get; set; }
        public bool attributable { get; set; }
    }

    public class Settings
    {
        public bool adult_content { get; set; }
        public bool buying_allowed { get; set; }
        public string[] buying_modes { get; set; }
        public string coverage_areas { get; set; }
        public string[] currencies { get; set; }
        public bool fragile { get; set; }
        public string immediate_payment { get; set; }
        public string[] item_conditions { get; set; }
        public bool items_reviews_allowed { get; set; }
        public bool listing_allowed { get; set; }
        public int max_description_length { get; set; }
        public int max_pictures_per_item { get; set; }
        public int max_pictures_per_item_var { get; set; }
        public int max_sub_title_length { get; set; }
        public int max_title_length { get; set; }
        public object maximum_price { get; set; }
        public object minimum_price { get; set; }
        public object mirror_category { get; set; }
        public object mirror_master_category { get; set; }
        public object[] mirror_slave_categories { get; set; }
        public string price { get; set; }
        public object[] restrictions { get; set; }
        public bool rounded_address { get; set; }
        public string seller_contact { get; set; }
        public string[] shipping_modes { get; set; }
        public string[] shipping_options { get; set; }
        public string shipping_profile { get; set; }
        public bool show_contact_information { get; set; }
        public string simple_shipping { get; set; }
        public string stock { get; set; }
        public object sub_vertical { get; set; }
        public object[] tags { get; set; }
        public object vertical { get; set; }
        public string vip_subdomain { get; set; }
    }

    public class Path_From_Root
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Children_Categories
    {
        public string id { get; set; }
        public string name { get; set; }
        public int total_items_in_this_category { get; set; }
    }
}

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
    public partial class frmLogin : Form
    {
        string mAuthURL;
        MeliApiService meli;
        string access;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmPublicar_Load(object sender, EventArgs e)
        {
            meli = new MeliApiService();
            this.CenterToScreen();
            System.Drawing.Icon ico = Properties.Resources.icono_app;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mAuthURL = meli.GetAuthUrl(577247158873150, MercadoLibre.SDK.Meta.MeliSite.Argentina, "https://trendsistemas.com/ml_response.php");
            Uri myUri = new Uri(mAuthURL);
            System.Diagnostics.Process.Start(@mAuthURL);
            
        }

        private void btnAccessToken_Click(object sender, EventArgs e)
        {
            GetAccessToken();
        }


        async void GetAccessToken()
        {
            meli.Credentials = new MercadoLibre.SDK.MeliCredentials(MercadoLibre.SDK.Meta.MeliSite.Argentina, 577247158873150, "lTGAzLn0QBkr7yrQWPc4yb88sPwnVksS");
            await meli.AuthorizeAsync(textBox1.Text, "https://trendsistemas.com/ml_response.php");
            access = meli.Credentials.AccessToken;
            MessageBox.Show(access);
        }

        async void GetAccessTokenCopia()
        {
            meli.Credentials = new MercadoLibre.SDK.MeliCredentials(MercadoLibre.SDK.Meta.MeliSite.Argentina, 577247158873150, "lTGAzLn0QBkr7yrQWPc4yb88sPwnVksS");
            await meli.AuthorizeAsync(textBox1.Text, "https://trendsistemas.com/ml_response.php");
            access = meli.Credentials.AccessToken;
            MessageBox.Show(access);
        }

        void RefreshToken()
        {
            meli.Credentials.TokensChanged += (sender, args) => { doSomethingWithNewTokenValues(args.Info); };
            meli.AuthorizeAsync(textBox1.Text, "https://trendsistemas.com/ml_response.php");
        }

        void doSomethingWithNewTokenValues(MercadoLibre.SDK.Models.TokenResponse e)
        {

        }

    }

    }
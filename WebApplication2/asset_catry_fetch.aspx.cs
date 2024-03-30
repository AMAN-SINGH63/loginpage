using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class asset_catry_fetch : System.Web.UI.Page
    {
   

        protected void Page_Load(object sender, EventArgs e)
        {
            Catagory_bind();
        }

        void Catagory_bind()
        {

            string extra1 = "";
            string extra2 = "";
            string extra3 = "";
            string extra4 = "";
            string extra5 = "";

            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["connectiontype"].ToString() == "sql")
            {
                string[] ParametersArray = { extra1, extra2, extra3, extra4, extra5 };

                WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
                ds = cmd.DynamicBindProcedure("drp_catg", ParametersArray);


            }
            drpitemcatg.DataSource = ds;
            drpitemcatg.DataTextField = "catg_name";
            drpitemcatg.DataValueField = "catg_id";

            drpitemcatg.DataBind();
            drpitemcatg.Items.Insert(0, new ListItem("--Please Select--", ""));

        }

        public class gridedata
        {
            public string Category_name { get; set; }
            public string Sub_category { get; set; }

            public string item_name { get; set; }

        }
        [WebMethod]

        public static List<gridedata> fetch_catg( string catg ,string extra1, string extra2)
        {


            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["connectiontype"].ToString() == "sql")
            {
                string[] ParametersArray = { catg, extra1, extra2 };

                WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
                ds = cmd.DynamicBindProcedure("asset_drp_catgry_fetch", ParametersArray);


            }
            List<gridedata> record = new List<gridedata>();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

            {
                gridedata row = new gridedata();

                row.Category_name = ds.Tables[0].Rows[i]["catg_name"].ToString();
                row.Sub_category = ds.Tables[0].Rows[i]["sub_catg_name"].ToString();
                row.item_name = ds.Tables[0].Rows[i]["Item Name"].ToString();

                record.Add(row);



            }


            return record;
        }



    }
}
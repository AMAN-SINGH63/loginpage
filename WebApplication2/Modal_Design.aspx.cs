using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Modal_Design : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public class gridedata
        {
            public string Category_name { get; set; }
            public string Sub_category { get; set; }

            public string item_name { get; set; }
        }

        [WebMethod]
        public static List<gridedata> Fetch_Record(string extra1, string extra2)
        {

          


            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["connectiontype"].ToString() == "sql")
            {
                string[] ParametersArray = { extra1, extra2 };

                WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
                ds = cmd.DynamicBindProcedure("fetch_item_name", ParametersArray);


            }
            List<gridedata> record = new List<gridedata>();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

            {
                gridedata row = new gridedata();

                row.Category_name = ds.Tables[0].Rows[i]["catg_name"].ToString();
                row.Sub_category = ds.Tables[0].Rows[i]["sub_catg_name"].ToString();
                row.item_name = ds.Tables[0].Rows[i]["item_name"].ToString();

                record.Add(row);



            }
            

            return record;
        }
    
    }
}
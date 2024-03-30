using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class asset_recieve_rpt : System.Web.UI.Page
    {
        public object GridViewStudent { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {
                Catagory_bind();

                BindGridView();
            }

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
            drpitemcatg.Items.Insert(0, new ListItem("--Please Select--", "0"));

        }

        protected void btnserch_Click(object sender, EventArgs e)
        {

            string catg = drpitemcatg.SelectedValue;
            string subctg = drpsubcatg.SelectedValue;

            string itemnme = txtitemdesc.Text;

            string destination = drpdestination.SelectedValue;


            if (catg == "0")
            {
                catg = "";       
            }

            if(subctg == "0")
            {
                subctg = "";
            }


            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.open('asset_item_receive_view2.aspx?catg=" + catg + "&subctg=" + subctg +
                   "&itemnme=" + itemnme + "&destination=" + destination + "', '_blank', 'toolbar = yes, scrollbars = yes, resizable = yes'); ", true); 

            return;




            //DataSet ds = new DataSet();

            //if (ConfigurationSettings.AppSettings["connectiontype"].ToString() == "sql")
            //{
            //    string[] ParametersArray = {catg,subctg,itemnme};

            //    WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
            //    ds = cmd.DynamicBindProcedure("asset_recieve_rpt", ParametersArray);


            //}

            //else
            //{

            //}


        }

        protected void drpitemcatg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = drpitemcatg.SelectedValue;

            string extra1 = "";
            string extra2 = "";
            string extra3 = "";
            string extra4 = "";
            string extra5 = "";

            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["connectiontype"].ToString() == "sql")
            {
                string[] ParametersArray = { id, extra1, extra2, extra3, extra4, extra5 };

                WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
                ds = cmd.DynamicBindProcedure("drp_sub", ParametersArray);

            }
            drpsubcatg.DataSource = ds;
            drpsubcatg.DataTextField = "sub_catg_name";
            drpsubcatg.DataValueField = "sub_catg_id";

            drpsubcatg.DataBind();
            drpsubcatg.Items.Insert(0, new ListItem("--Please Select--", "0"));

        }


        private void BindGridView()
        {
            string id = "";
            string drpcat = "";
            string drpsub = "";
            string item = "";

            string extra1 = "";
            string extra2 = "";
            string extra3 = "";
            string extra4 = "";
            string extra5 = "";


            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["connectiontype"].ToString() == "sql")
            {
                string[] ParametersArray = { id, drpcat, drpsub, item, extra1, extra2, extra3, extra4, extra5 };

                WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
                ds = cmd.DynamicBindProcedure("bind_gride_item", ParametersArray);

            }

            else
            {

            }

        }
    }
}
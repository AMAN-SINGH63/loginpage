using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace WebApplication2
{
    public partial class inventry_master_page : System.Web.UI.Page
    {
        public string appversion;

        [Obsolete]
        protected void Page_Load(object sender, EventArgs e)
        {
            appversion = ConfigurationSettings.AppSettings["applnversionnumber"].ToString();

            if (!Page.IsPostBack)
            {
                Catagory_bind();

                BindGridView();
            }

            btnupdate.Visible = true;

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



        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (drpitemcatg.SelectedValue == "0")
            {
                Response.Write("<script>alert('Please enter catagory')</script>");
                return;
            }

            if (drpsubcatg.SelectedValue == "0")
            {
                Response.Write("<script>alert('Please enter subcatory')</script>");
                return;
            }

            if(txtitemdesc.Text == "")
            {
                Response.Write("<script>alert('please enter item')</script>");
                return;
            }


            string drpcat = drpitemcatg.SelectedValue;
            string drpsub = drpsubcatg.SelectedValue;
            string item = txtitemdesc.Text;

            string extra1 = "";
            string extra2 = "";
            string extra3 = "";
            string extra4 = "";
            string extra5 = "";

            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["connectiontype"].ToString() == "sql")
            {
                string[] ParametersArray = { drpcat,drpsub,item,extra1, extra2, extra3, extra4, extra5 };

                WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
                ds = cmd.DynamicBindProcedure("item_save", ParametersArray);

            }

            else
            {

            }

            Response.Write("<script LANGUAGE='JavaScript' >alert('Record Inserted successfully...!')</script>");



            drpitemcatg.SelectedValue = "0";
            drpsubcatg.SelectedValue = "0";
            txtitemdesc.Text = "";


            BindGridView();

            btnupdate.Visible = false;






        }

        protected void btncancel_Click(object sender, EventArgs e)
        {

            drpitemcatg.SelectedValue = "0";
            drpsubcatg.Items.Clear();
            txtitemdesc.Text = "";


            btnsave.Visible = true;
            btncancel.Visible = true;


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
                string[] ParametersArray = { id,extra1, extra2, extra3, extra4, extra5 };

                WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
                ds = cmd.DynamicBindProcedure("drp_sub", ParametersArray);


            }
            drpsubcatg.DataSource = ds;
            drpsubcatg.DataTextField = "sub_catg_name";
            drpsubcatg.DataValueField = "sub_catg_id";

            drpsubcatg.DataBind();
            drpsubcatg.Items.Insert(0, new ListItem("--Please Select--", "0"));








        }

        protected void btnupdate_Click(object sender, EventArgs e)// 
        {
            if (drpitemcatg.SelectedValue == "0")
            {
                Response.Write("<script>alert('Please enter catagory')</script>");
                return;
            }

            if (drpsubcatg.SelectedValue == "0")
            {
                Response.Write("<script>alert('Please enter subcatory')</script>");
                return;
            }

            if (txtitemdesc.Text == "")
            {
                Response.Write("<script>alert('please enter item')</script>");
                return;
            }

            string uniqe = uniqeid.Value;            

            string drpcat = drpitemcatg.SelectedValue;
            string drpsub = drpsubcatg.SelectedValue;
            string item = txtitemdesc.Text;

            string extra1 = "";
            string extra2 = "";
            string extra3 = "";
            string extra4 = "";
            string extra5 = "";

            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["connectiontype"].ToString() == "sql")
            {
                string[] ParametersArray = { uniqe, drpcat, drpsub, item, extra1, extra2, extra3, extra4, extra5 };

                WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
                ds = cmd.DynamicBindProcedure("item_update", ParametersArray);

            }

            else
            {

            }
            Response.Write("<script LANGUAGE='JavaScript' >alert('Record updated successfully...!')</script>");



            drpitemcatg.SelectedValue = "0";
            drpsubcatg.Items.Clear();
            txtitemdesc.Text = "";



            BindGridView();

            btnupdate.Visible = false;
            btnsave.Visible = true;



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
                string[] ParametersArray = { id,drpcat, drpsub, item, extra1, extra2, extra3, extra4, extra5 };

                WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
                ds = cmd.DynamicBindProcedure("bind_gride_item", ParametersArray);

            }

            else
            {

            }

            GridViewStudent.DataSource = ds;
            GridViewStudent.DataBind();

        }


        protected void GridViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

            drpitemcatg.SelectedValue = GridViewStudent.SelectedRow.Cells[4].Text; 

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




            drpsubcatg.SelectedValue = GridViewStudent.SelectedRow.Cells[5].Text;
            txtitemdesc.Text = GridViewStudent.SelectedRow.Cells[3].Text;
            uniqeid.Value = GridViewStudent.SelectedRow.Cells[6].Text;

            btnsave.Visible = false;
            btnupdate.Visible = true;
         
          

            BindGridView();


        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class asset_item_receive_view2 : System.Web.UI.Page
    {

        string catg = "";
        string subctg = "";
        string itemnme = "";
        string destination = "";

        protected void Page_Load(object sender, EventArgs e)
        
        {
            catg = (Request.QueryString["catg"].ToString());

            subctg = (Request.QueryString["subctg"].ToString());

            itemnme = (Request.QueryString["itemnme"].ToString());

            destination = (Request.QueryString["destination"].ToString());







            report();


        }

        public void report()
        {

            StringBuilder tbl = new StringBuilder();
            string[] paramarr = { catg, subctg, itemnme };

            DataSet ds = new DataSet();
            WebApplication2.App_Code.Sql.Common cmd = new WebApplication2.App_Code.Sql.Common();
            ds = cmd.DynamicBindProcedure("asset_recieve_rpt", paramarr);

         

                if (ds.Tables[0].Rows.Count > 0)
                


                if (destination == "exc")/// this is for print in sreen or excel formate 
                {
                    Response.Clear();
                    Response.ClearContent();
                    Response.Charset = "UTF-8";
                    Response.ContentType = "text/csv";
                    Response.AppendHeader("content-disposition", "attachment; filename=Ex.xls");
                }

                /// this is for table show

                int columncount = ds.Tables[0].Columns.Count;
                    int column1 = columncount / 3;

                    tbl.Append("<table style='width:100%;font-family:Verdana;font-size:12px;' cellspacing='0' cellpadding='0' >");


                    tbl.Append("<tr>");
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        if (j == 0)
                        {
                            tbl.Append("<td style='width:5%;border-top: 1px solid;border-bottom: 1px solid;border-left: 1px solid;border-right: 1px solid;text-align:center;font-weight:bold;background-color:#D6EAF8;'>");
                            tbl.Append(ds.Tables[0].Columns[j].ColumnName.ToString());
                            tbl.Append("</td>");
                        }
                        else
                        {
                            tbl.Append("<td style='border-top: 1px solid;border-bottom: 1px solid;border-right: 1px solid;text-align:center;font-weight:bold;background-color:#D6EAF8;'>");
                            tbl.Append(ds.Tables[0].Columns[j].ColumnName.ToString());
                            tbl.Append("</td>");
                        }
                    }
                    tbl.Append("</tr>");
                    int sr_no = 1;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        tbl.Append("<tr>");
                        for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                        {
                            if (j == 0)
                            {
                                tbl.Append("<td style='border-bottom: 1px solid;border-left: 1px solid;border-right: 1px solid;text-align:left;padding-left:2px;'>");
                                tbl.Append(sr_no);
                                sr_no += 1;
                                //tbl.Append(ds.Tables[0].Rows[i].ItemArray[j].ToString());
                                tbl.Append("</td>");
                            }
                            else
                            {
                                tbl.Append("<td style='border-bottom: 1px solid;border-right: 1px solid;text-align:left;padding-left:2px;'>");
                                tbl.Append(ds.Tables[0].Rows[i].ItemArray[j].ToString());
                                tbl.Append("</td>");
                            }

                        }
                        tbl.Append("</tr>");
                    }





                    tbl.Append("</table>");
                    rpt.InnerHtml = tbl.ToString();
                    
                }



            }


        }




    

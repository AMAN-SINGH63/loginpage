<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="asset_recieve_rpt.aspx.cs" Inherits="WebApplication2.asset_recieve_rpt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report</title>
</head>
<body>
    
    <script src="js/common.js"></script>
    <script src="js/jquery.min.js"></script>
    <script src="js/assest_reciev_rert.js"></script>
    <link href="css/bootstrap_process.css" rel="stylesheet" />


    <form id="form1" runat="server" class="form-horizontal">


        <div class="container" style="padding-top: 8px;">

            <fieldset>


                <legend>Item Master Form</legend>

                <div class="col-md-12 col-sm-12 col-lg-12">
                    <div class="row">
                        <div class="col-md-2 col-sm-2 col-lg-2">
                            <label>Catagory</label>
                        </div>
                             <div class="col-md-4 col-sm-4 col-lg-4">
                            <asp:DropDownList ID="drpitemcatg" runat="server" class="form-control" Width="100%" AutoPostBack="true" OnSelectedIndexChanged="drpitemcatg_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>

                        <div class="col-md-2 col-sm-2 col-lg-2">
                            <label>Subcategory</label>
                        </div>

                        <div class="col-md-4 col-md-4 col-md-4">
                            <asp:DropDownList ID="drpsubcatg" runat="server" CssClass="form-control" Width="100%"></asp:DropDownList>

                        </div>

              
                    </div>

                </div>

                  <div class="col-md-12 col-sm-12 col-lg-12" style="margin-top: 3px;">
                    <div class="row">

                        <div class="col-md-2 col-sm-2 col-lg-2">
                            <label>Item Name<font color="red">*</font></label>
                        </div>
                        <div class="col-md-10 col-sm-10 col-lg-10">
                            <asp:TextBox ID="txtitemdesc" runat="server" placeholder="Item Description" class="form-control" MaxLength="500" autocomplete="off"></asp:TextBox>
                        </div>
                    </div>
                </div>


                  
                <div class="col-md-12 col-sm-12 col-lg-12" style="margin-top: 3px;">
                    <div class="row">
                        <div class="col-md-2 col-sm-2 col-lg-2">
                            <label for="lbldestination">Destination</label>
                        </div>
                        <div class="col-md-4 col-sm-4 col-lg-4">
                            <asp:DropDownList ID="drpdestination" runat="server" class="form-control" MaxLength="100">
                                <asp:ListItem Value="ons" Selected="True">Screen</asp:ListItem>
                                <asp:ListItem Value="exc">Excel</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                    </div>
                </div>



                <div class="col-md-12 text-center">
                      <asp:Button runat="server" ID="btnserch" Text="search" OnClick="btnserch_Click" />
                  
                    </div> 





                  <%--  <div style="padding: 10px; margin: 0px;" class="col-md-12 col-sm-12 col-lg-12">
                    <asp:GridView ID="GridViewStudent" runat="server" OnSelectedIndexChanged="GridViewStudent_SelectedIndexChanged"
                        
                        AutoGenerateColumns="False"
                        

                        GridLines="None"
                        AllowPaging="false"
                        CssClass="mGrid"
                        PagerStyle-CssClass="pgr"
                        AlternatingRowStyle-CssClass="alt">
                        <Columns>

                            <asp:CommandField HeaderText="update" ShowSelectButton="true" ItemStyle-Width="5%" />


                            <asp:BoundField ItemStyle-Width="20%" DataField="catg_name" HeaderText="catogaryname" />
                            <asp:BoundField ItemStyle-Width="20%" DataField="sub_catg_name" HeaderText="subname" />
                            <asp:BoundField ItemStyle-Width="20%" DataField="item_name" HeaderText="itemname" />
                            <asp:BoundField ItemStyle-Width="2%" DataField="catg_id" HeaderText="#" />
                            <asp:BoundField ItemStyle-Width="2%" DataField="sub_catg_id" HeaderText="#" />
                            <asp:BoundField ItemStyle-Width="2%" DataField="id" HeaderText="#" />



                        </Columns>
                    </asp:GridView>
                       <asp:HiddenField ID="uniqeid" runat="server" />
                </div>--%>




            </fieldset>

        </div>
    </form>
</body>
</html>



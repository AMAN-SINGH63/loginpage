<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="asset_catry_fetch.aspx.cs" Inherits="WebApplication2.asset_catry_fetch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script src="js/common.js"></script>
     <script src="js/jquery.min.js"></script>
    <script src="js/asset_catagory_demo.js"></script>
    <link href="css/bootstrap_process.css" rel="stylesheet" />


    <form id="form1" runat="server" class="form-horizontal">

        <div class="container" style="padding-top: 8px;">
             <fieldset>

                     <div class="col-md-12 col-sm-12 col-lg-12">
                    <div class="row">
                        <div class="col-md-2 col-sm-2 col-lg-2">
                            <label>Catagory</label>
                        </div>
                             <div class="col-md-10 col-sm-10 col-lg-10">
                            <asp:DropDownList ID="drpitemcatg" runat="server" class="form-control" Width="100%">
                            </asp:DropDownList>
                        </div>

                       <div  class="col-md-12 text-center">

                         

                             <button type="button" onclick="fetching()">fetchhh</button>

                             
                       </div>

                         
                         <div id="showingta"></div>

              
                    </div>

                </div>



             </fieldset>



        </div>
    </form>
</body>
</html>

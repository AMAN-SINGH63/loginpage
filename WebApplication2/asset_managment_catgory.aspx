
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="asset_managment_catgory.aspx.cs" Inherits="WebApplication2.asset_managment_catgory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/common.js"></script>
    <script src="js/jquery.min.js"></script>
    <script src="js/asset_catagory_demo.js"></script>
    <link href="css/bootstrap_process.css" rel="stylesheet" />

  <%--  <style>
        tbody tr:nth-child(even) {
            background-color: lightgray;
            color: black;
        }
        tbody tr:nth-child(odd) {
            background-color: white;
            color: black;
        }
        
        #drpitemcatg {
            background-color: deepskyblue;
            color: red;
        }
    </style>

    --%>

    
    <style>

     body {
        background-color: #f5f5f5;
        font-family: Arial, sans-serif;
    }

    /* Style the container */
    .container {
        margin-top: 10px;
    }

    /* Style the fieldset */
    fieldset {
        background-color: #fff;
        border: 1px solid #ddd;
        padding: 20px;
        border-radius: 2px;
    }

    /* Style the label for "Category" */
    label {
       /* font-weight: bold;*/

       font-weight: lighter
    }

    /* Style the dropdown list */
    #drpitemcatg {
        background-color: #007bff;
        color: #fff;
    }

    /* Style the "Fetch" button */
    button {
        background-color: #28a745;
        color: #fff;
        border: none;
        padding: 10px 20px;
        border-radius: 5px;
        cursor: pointer;
    }

    /* Style the table */
    table {
        width: 100%;
        border-collapse: collapse;
        margin-top: 20px;
    }

    /* Style the table header row */
    th {
        background-color: #007bff;
        color: #fff;
    }

    /* Style the table rows alternately */
    tbody tr:nth-child(even) {
        background-color: #f2f2f2;
    }

    tbody tr:nth-child(odd) {
        background-color: #fff;
    }

    /* Style the table cell padding and border */
    td {
        padding: 8px;
        border: 1px solid #ddd;
    }
</style>






</head>
<body>
    <form id="form2" runat="server" class="form-horizontal">
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
                    </div>
                    <div class="col-md-12 text-center ">
                        <button type="button" onclick="btnfetch()">fetch</button>
                    </div>
                    <div id="show_table"></div>
                </div>
            </fieldset>
        </div>
    </form>
</body>
</html>






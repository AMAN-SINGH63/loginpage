$(document).ready(function () {


    // Get the modal
    var modal = document.getElementById("myModal");

    // Get the button that opens the modal
    var btn = document.getElementById("myBtn");

    // Get the <span> element that closes the modal
    var span = document.getElementsByClassName("close")[0];

    // When the user clicks the button, open the modal
    btn.onclick = function () {
        modal.style.display = "block";

        var obj = {};
        obj.extra1 = "";
        obj.extra2 = "";


        $.ajax({
            url: 'Modal_Design.aspx/Fetch_Record',
            data: JSON.stringify(obj),
            dataType: "json",
            type: "POST",
            async: false,
            contentType: "application/json; charset=utf-8",
            success: function (ds) {



                debugger;
                var record = ds.d;

                document.getElementById("footertotal").innerHTML = record.length;

                var table = "";

                table += "<table style='width:100%;' border='1'>";

                table += "<tr>";

                table += "<td>";
                table += "S. No.";
                table += "</td>";



                table += "<td>";
                table += "Category Name";
                table += "</td>";

                table += "<td>";
                table += "Sub Category";
                table += "</td>";

                table += "<td>";
                table += "Item Name";
                table += "</td>";

                table += "</tr>"

                for (var i = 0; i < record.length; i++) {

                    table += "<tr>";

                    table += "<td  style='width:10%;'>";


                    table += (1 + i);            //this logic for the show serial number in the table 
                    table += "</td>";

                    table += "<td>";
                    table += record[i]["Category_name"].toString();
                    table += "</td>";
                 
                    
                    table += "<td>";
                    table += record[i]["Sub_category"].toString();
                    table += "</td>";
              

                    table += "<td>";
                    table += record[i]["item_name"].toString();
                    table += "</td>";
                 
                    table += "</tr>";

                }

                table += "</table>";

                document.getElementById("showingta").innerHTML = table;


            },
            error: function (response) {
                alert(response.responseText);
                return false;
            },
            failure: function (response) {
                alert(response.responseText);
                return false;
            }
        });










    };

    // When the user clicks on <span> (x), close the modal
    span.onclick = function () {
        modal.style.display = "none";
    };
});







function fetching() {

    alert('this');
    var obj = {};
    obj.catg= document.getElementById("drpitemcatg").value;/// this way to value hold on the obj catagory this way for the basically java script 
    obj.extra1 = "";                                        ///same here
    obj.extra2 = "";                                        ///same here 

    /// ye object le ja rhe hai jisase ki obj ko check kra sake data base me 
    

    $.ajax({
        url: 'asset_catry_fetch.aspx/fetch_catg',
        data: JSON.stringify(obj),
        dataType: "json",
        type: "POST",
        async: false,
        contentType: "application/json; charset=utf-8",
        success: function (ds) {

            //alert('tyy');


            var recored = ds.d;

          /*  alert('now');*/

            var table = "";

            table += "<table style='width:100%;'border='3'>";


/*            alert('tryyyyy');*/

            table += "<tr>";

            table += "<td>";
            table += "S. No.";
            table += "</td>";


           /* alert('remark');*/

            //table += "<td onclick=\"alert('Clicked on Category: Categry');\">";
            //table += "Categry";
            //table += "</td>";




            table += "<td>";
            table += "Categry";
            table += "</td>";
            



          /*  alert('2');*/



            table += "<td>";
            table += "Subcategory";
            table += "</td>";


            //alert('3');

            table += "<td>";
            table += "Item Name";
            table += "</td>";


         /*   alert('4');*/


            for (var i = 0; i < recored.length; i++) {



                //alert('5');


                table += "<tr>";

                table += "<td  style='width:10%;'>";
               
                table += (1 + i);
                table += "</td>";


               /* alert('6');*/


                /// this is for alert show perticular column and perticular items name show 
                var category_name = recored[i]["Category_name"].toString();
                table += "<td onclick=\"alert('Clicked on Category: " + category_name + "');\">";
                table += category_name;
                table += "</td>";


                //table += "<td onclick=\"alert('Clicked on Category: Category_name');\">";
                //table += recored[i]["Category_name"].toString();
                //table += "</td>";


                
                var Sub_category = recored[i]["Sub_category"].toString();
                table += "<td onclick=\"alert('clicked on subcatagory: " + Sub_category + "');\">";
                table += Sub_category;
                table += "</td>";


                

               
                table += "<td style=background-color: green;'>";
                table += recored[i]["item_name"].toString();
                table += "</td>";

                //var item_name = recored[i]["item_name"].toString();
                //table += "<td class='item-cell' data-index='" + i + "'>";
                //table += item_name;
                //table += "</td>";







              /*  alert('9');*/

                table += "</tr>";

            }
            table += "</table>";



            document.getElementById("showingta").innerHTML = table;    /// this is show for the table in the load page
            
         

          


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



}
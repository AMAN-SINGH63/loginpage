
//function btnfetch(){
//    //alert('ok');

//    var obj = {};
//    obj.catg = document.getElementById("drpitemcatg").value;
//    obj.extra1 = "";
//    obj.extra2 = "";

//   /* alert('this');*/
//    $.ajax({
//        url: 'asset_managment_catgory.aspx/Asset',
//        data: JSON.stringify(obj),
//        dataType: "json",
//        type: "POST",
//        async: false,
//        contentType: "application/json; charset=utf-8",
//        success: function (ds) {


//            //alert('1');


//            var recored = ds.d;



//            var table = "";


//            table += "<table style='width:100%;'border='3'>";



           
//            table += "<tr>";

//          /*  alert('2');*/

//            table += "<td>";
//            table += "S. No.";
//            table += "</td>";

//          /*  alert('3');*/

//            table += "<td>";
//            table += "Categry";
//            table += "</td>";

//            //alert('4');

//            table += "<td>";
//            table += "Subcategory";
//            table += "</td>";

//           /* alert('5');*/


//            table += "<td>";
//            table += "Item Name";
//            table += "</td>";

//           /* alert('6');*/



//            for (var i = 0; i < recored.length; i++) {

                
              
//                table += "<tr>";


//                table += "<td  style='width:10%;'>";
//                table += (1 + i);
//                table += "</td>";


                

//                var category_name = recored[i]["Category_name"].toString();
//               /// table += "<td style='background-color: #99cc00;' onclick=\"alert('Clicked on Category: " + category_name + "');\">";
//                table += "<td  onclick=\"alert('Clicked on Category: " + category_name + "');\">";

//                table += category_name;
//                table += "</td>";

               


//                var Sub_category = recored[i]["Sub_category"].toString();
//               /// table += "<td style='background-color: #99cc00;' onclick=\"alert('Clicked on subcatg: " + Sub_category + "');\">";
//                table += "<td  onclick=\"alert('Clicked on subcatg: " + Sub_category + "');\">";
//                table += Sub_category;
//                table += "</td>";


//                var item_name = recored[i]["item_name"].toString();
//               /// table += "<td style='background-color: #99cc00;' onclick=\"alert('Clicked on item name: " + item_name + "');\">";

//                table += "<td  onclick=\"alert('Clicked on item_name: " + item_name + "');\">";
                

//                table += item_name;
//                table += "</td>";


//                table += "</tr>";


                    
//            }


//            table += "</table>";

//            document.getElementById("show_table").innerHTML = table;






//        },
//        error: function (response) {
//            alert(response.responseText);
//            return false;
//        },
//        failure: function (response) {
//            alert(response.responseText);
//            return false;
//        }
//    });













//        }






///-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


             ///    this is another way to styling the table in the load page its individual code for this styling 


///     this is click event when click the table perticular row color will be change 


function btnfetch() {
    var obj = {};
    obj.catg = document.getElementById("drpitemcatg").value;
    obj.extra1 = "";
    obj.extra2 = "";

    $.ajax({
        url: 'asset_managment_catgory.aspx/Asset',
        data: JSON.stringify(obj),
        dataType: "json",
        type: "POST",
        async: false,
        contentType: "application/json; charset=utf-8",
        success: function (ds) {
            var recored = ds.d;
            var table = "<table style='width:100%;' border='3'>";

            table += "<tr>";
            table += "<td>S. No.</td>";
            table += "<td>Category</td>";
            table += "<td>Subcategory</td>";
            table += "<td>Item Name</td>";
            table += "</tr>";

            for (var i = 0; i < recored.length; i++) {
                table += "<tr>";

                table += "<td style='width:10%;'>" + (1 + i) + "</td>";

                var category_name = recored[i]["Category_name"].toString();
                table += "<td onclick=\"changeColor(this); alert('Clicked on Category: " + category_name + "');\">" + category_name + "</td>";

                var Sub_category = recored[i]["Sub_category"].toString();
                table += "<td onclick=\"changeColor(this); alert('Clicked on subcatg: " + Sub_category + "');\">" + Sub_category + "</td>";

                var item_name = recored[i]["item_name"].toString();
                table += "<td onclick=\"changeColor(this); alert('Clicked on item name: " + item_name + "');\">" + item_name + "</td>";

                table += "</tr>";
            }

            table += "</table>";

            document.getElementById("show_table").innerHTML = table;
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
/// this is function which is created by me 
function changeColor(row) {
    // Toggle background color on click
    if (row.style.backgroundColor === '' || row.style.backgroundColor === 'white') {
        row.style.backgroundColor = 'green'; // Change to your desired color
    } else {
        row.style.backgroundColor = 'white';
    }
}
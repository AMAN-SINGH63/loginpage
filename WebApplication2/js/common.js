
/******  dispable rigt click on pages*********/
if (document.layers) {
    //Capture the MouseDown event.
    document.captureEvents(Event.MOUSEDOWN);
    //Disable the OnMouseDown event handler.
    document.onmousedown = function () {
        return false;
    };
}
else {
    //Disable the OnMouseUp event handler.
    document.onmouseup = function (e) {
        if (e != null && e.type == "mouseup") {
            //Check the Mouse Button which is clicked.
            if (e.which == 2 || e.which == 3) {
                //If the Button is middle or right then disable.
                return false;
            }
        }
    };
}

//Disable the Context Menu event.
document.oncontextmenu = function () {
    return false;
};











function EnterTab(evt, id) {
    var evt = (evt) ? evt : ((event) ? event : null);
    var node = (evt.target) ? evt.target : ((evt.srcElement) ? evt.srcElement : null);
    if ((evt.keyCode == 13) && (node.className != "btextlist") && ((node.type == "text") || (node.type == "select-one") || (node.type == "radio") || (node.type == "checkbox") || (node.type == "button"))) {
        getNextElement(node).focus();
        return false;
    }
}
function getNextElement(field) {
    var form = field.form;
    for (var e = 0; e < form.elements.length; e++) {
        if (field == form.elements[e]) {
            break;
        }
    }
    e++;
    while (form.elements[e % form.elements.length].type == "fieldset" || form.elements[e % form.elements.length].type == undefined || form.elements[e % form.elements.length].type == "hidden" || form.elements[e % form.elements.length].type == "invisible" || form.elements[e % form.elements.length].disabled == true) {
        e++;
    }
    return form.elements[e % form.elements.length];;
}




function isNumberKey(evt, element) {
    var charCode = (evt.which) ? evt.which : event.keyCode

    if (charCode > 31 && (charCode < 48 || charCode > 57) && !(charCode == 46 || charCode == 8 || charCode == 45)) {
        return false;
    }
    else {
        var len = document.getElementById(element).value.length;
        var index = document.getElementById(element).value.indexOf('.');
        if (index > 0 && charCode == 46) {
            return false;
        }
        //if (index > 0) {
        //    var CharAfterdot = (len + 1) - index;
        //    if (CharAfterdot > 3) {
        //        return false;
        //    }
        //}

    }
    return true;
}



function encryptvalxor(val) {
    var xorKey = 129;
    var result = "";
    for (i = 0; i < val.length; ++i) {
        result += String.fromCharCode(xorKey ^ val.charCodeAt(i));
    }
    return result;
}



function onfocusin_buttoncontrol(id) {
    document.getElementById(id).style.boxShadow = "1px 1px 1px 1px";
    return false;
}

function onfocusout_buttoncontrol(id) {
    document.getElementById(id).style.boxShadow = "0px 0px 0px 0px";
    return false;
}

//var specialKeys = new Array();
//specialKeys.push(8);  //Backspace
//specialKeys.push(9);  //Tab
//specialKeys.push(46); //Delete
//specialKeys.push(36); //Home
//specialKeys.push(35); //End
//specialKeys.push(37); //Left
//specialKeys.push(39); //Right
//specialKeys.push(33);//!
//specialKeys.push(35);//#
//specialKeys.push(36);//$
//specialKeys.push(37);//%
//specialKeys.push(40);//(
//specialKeys.push(41);//)
//specialKeys.push(43);//+
//specialKeys.push(44);//,
//specialKeys.push(45);//-
//specialKeys.push(46);//.
//specialKeys.push(47);///
//specialKeys.push(58);//:
//specialKeys.push(60);//<
//specialKeys.push(62);//>
//specialKeys.push(63);//?


//function IsAlphaNumeric(e) {

   


//    var keyCode = e.keyCode == 0 ? e.charCode : e.keyCode;
//    var ret = ((keyCode >= 48 && keyCode <= 57) || (keyCode >= 65 && keyCode <= 90) || keyCode == 32 || (keyCode >= 97 && keyCode <= 122) || (specialKeys.indexOf(e.keyCode) != -1 && e.charCode != e.keyCode));
//    //document.getElementById("error").style.display = ret ? "none" : "inline";
//    return ret;
//}



//function IsAlphaNumeric(controlid) {
//    // var iChars = "!`@#$%^&*()+=-[]\\\';,./{}|\":<>?~_";   
//    var iChars = "!@#$%^()+-[]\\\',./|\:<>?_";
//    var data = document.getElementById(controlid).value;
//    for (var i = 0; i < data.length; i++) {
//        if (iChars.indexOf(data.charAt(i)) != -1) {
//            alert("Your string has unwanted special characters.Please check input again.");
//            return false;
//        }

//    }

//}




var specialChars = "`^&*\\\';~<>[]";
var checkForSpecialChar = function (string) {
    for (i = 0; i < specialChars.length; i++) {
        if (string.indexOf(specialChars[i]) > -1) {
            return true
        }
    }
    return false;
}

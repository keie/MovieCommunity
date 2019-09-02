 function FieldRequerid() {
     
    var fields = document.getElementsByClassName("LoginInput");
    var field;
    var nFields = fields.length;
    var meter = 0;
    for (var f = 0; f < nFields; f++) {
        field = fields[f];
        if (field.value == "") {
            meter++;
            field.style.borderColor = "red";
        } else {
            field.style.removeProperty("border");
        }
    }
    return meter == 0;
}

 function Login() {
     if (FieldRequerid()) {
         alert('validaciones correctas');
     } 
}
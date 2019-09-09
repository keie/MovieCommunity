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

function AttachData() {
    var userName = document.getElementById("usernameInput").value;
    var password = document.getElementById("passwordInput").value;
    var data = [userName, password];
    alert(userName);
    SendText("Login/Login", Confirm, data);

}

function Confirm(message) {
    alert(message);
}

function Login() {
    if (FieldRequerid()) {
        AttachData();
     } 
}

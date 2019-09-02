function importScript(nombre) {
    var s = document.createElement("script");
    s.src = nombre;
    document.querySelector("head").appendChild(s);
}

importScript("./Login/Login");

function closePop() {
    document.getElementById('popUp').style.display = 'none';
}

function StartSession() {
    var str = "<div id='popupReg' style='  height:90px; width:90px;'>" +
                "<input type='text' placeholder='Username' class='LoginInput'/>" +
                "<input type='password' placeholder='password' class='LoginInput'/>" +
                
                "<a src='#'>¿Olvidaste la contraseña?</a>" +
                "<button id='btnReg' onclick='Login();'>INGRESAR</button>" +
              "</div >";
    document.getElementById('form').innerHTML = str;
    document.getElementById('popUp').style.display = 'block';
}


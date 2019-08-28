function closePop() {
    document.getElementById('popUp').style.display = 'none';
}

function StartSession() {
    var str = "<div id='popupReg' style='  height:90px; width:90px;'>" +
                "<input type='text' placeholder='Username'/>" +
                "<input type='password' placeholder='password'/>" +
                
                "<a src='#'>¿Olvidaste la contraseña?</a>" +
                "<button id='btnReg'>INGRESAR</button>" +
              "</div > ";
    document.getElementById('form').innerHTML = str;
    document.getElementById('popUp').style.display = 'block';
}


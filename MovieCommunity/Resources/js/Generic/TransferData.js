

var Get = function (url, callBackServer) {
    RequestServer("get", url, callBackServer);
}

var SendText = function (url, callBackServer, text) {
    RequestServer("post", url, callBackServer, text);
}

function RequestServer(methodUrl, url, callBackServer, text) {
    var xhr = new XMLHttpRequest();
    xhr.open(methodUrl, url);
    xhr.onreadystatechange = function () {
        if (xhr.status == 200 && xhr.readyState == 4) {
            callBackServer(xhr.response);
        }
    }
    if (methodUrl == "get") {
        xhr.send();
    } else {
        if (text != "" && text != null) {
            xhr.send(text);
        }
    }
}





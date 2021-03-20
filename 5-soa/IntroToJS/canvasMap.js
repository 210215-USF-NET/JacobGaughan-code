const canvas = document.getElementById("mapCanvas");
const ctx = canvas.getContext("2d");
const image = document.getElementById("mapOutput");
const downloadButton = document.getElementById('download-map');

var flag = false,
    prevX = 0,
    currX = 0,
    prevY = 0,
    currY = 0,
    dot_flag = false;

var x = "black",
    y = 2;

function loadFile(event) {
    var image = document.getElementById('mapOutput');
    image.src = URL.createObjectURL(event.target.files[0]);
    image.onload = drawImageActualSize;
};

function saveFile() {
    // var dataURL = canvas.toDataURL('image/png');
    // downloadButton.href = dataURL;

    var c = document.getElementById("mapCanvas");
    var d = c.toDataURL("image/png");
    var w = window.open('about:blank','image from canvas');
    w.document.write("<img src='"+d+"' alt='from canvas'/> <br> <a href=\"/canvas-practice.html\">Back to map</a>");
};

function drawImageActualSize() {
    let maxW = 1000;
    canvas.width = maxW;
    canvas.height = (image.height * maxW) / image.width;
    ctx.drawImage(image, 0, 0, canvas.width, canvas.height);
}

function init() {
    canvas.addEventListener(
        "mousemove",
        function (e) {
            findxy("move", e);
        },
        false
    );
    canvas.addEventListener(
        "mousedown",
        function (e) {
            findxy("down", e);
        },
        false
    );
    canvas.addEventListener(
        "mouseup",
        function (e) {
            findxy("up", e);
        },
        false
    );
    canvas.addEventListener(
        "mouseout",
        function (e) {
            findxy("out", e);
        },
        false
    );
}

function color(obj) {
    switch (obj.id) {
        case "green":
            x = "green";
            break;
        case "blue":
            x = "blue";
            break;
        case "red":
            x = "red";
            break;
        case "yellow":
            x = "yellow";
            break;
        case "orange":
            x = "orange";
            break;
        case "black":
            x = "black";
            break;
        case "white":
            x = "white";
            break;
    }
    if (x == "white") y = 14;
    else y = 2;
}

function draw() {
    ctx.beginPath();
    ctx.moveTo(prevX, prevY);
    ctx.lineTo(currX, currY);
    ctx.strokeStyle = x;
    ctx.lineWidth = y;
    ctx.stroke();
    ctx.closePath();
}

function eraseBoard() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    document.getElementById("canvasimg").style.display = "none";
}

function erase() {
    var m = confirm("Are you sure you want to clear?");
    if (m) {
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        document.getElementById("canvasimg").style.display = "none";
    }
}

function save() {
    document.getElementById("canvasimg").style.border = "2px solid";
    var dataURL = canvas.toDataURL();
    document.getElementById("canvasimg").src = dataURL;
    document.getElementById("canvasimg").style.display = "inline";
}

function findxy(res, e) {
    if (res == "down") {
        prevX = currX;
        prevY = currY;
        currX = e.clientX - canvas.offsetLeft;
        currY = e.clientY - canvas.offsetTop;

        flag = true;
        dot_flag = true;
        if (dot_flag) {
            ctx.beginPath();
            ctx.fillStyle = x;
            ctx.fillRect(currX, currY, 2, 2);
            ctx.closePath();
            dot_flag = false;
        }
    }
    if (res == "up" || res == "out") {
        flag = false;
    }
    if (res == "move") {
        if (flag) {
            prevX = currX;
            prevY = currY;
            currX = e.clientX - canvas.offsetLeft;
            currY = e.clientY - canvas.offsetTop;
            draw();
        }
    }
}

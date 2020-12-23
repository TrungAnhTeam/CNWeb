//an1
var ans1 = document.getElementById('anser1').innerHTML;
var km1 = true;

document.getElementById("A1").onclick = function () {
    if (km1) {
        document.getElementById("conten1").style.display = "block";
        km1 = false;
        if (ans1 == "1") {
            document.getElementById("A1").className = "btn btn-success";
        }
        else {
            document.getElementById("A1").className = "btn btn-danger";
            if (ans1 == "2")
                document.getElementById("B1").className = "btn btn-warning";
            if (ans1 == "3")
                document.getElementById("C1").className = "btn btn-warning";
            if (ans1 == "4")
                document.getElementById("D1").className = "btn btn-warning";
        }
    }
};
document.getElementById("B1").onclick = function () {
    if (km1) {
        document.getElementById("conten1").style.display = "block";
        km1 = false;
        if (ans1 == "2") {
            document.getElementById("B1").className = "btn btn-success";
        }
        else {
            document.getElementById("B1").className = "btn btn-danger";
            if (ans1 == "1")
                document.getElementById("A1").className = "btn btn-warning";
            if (ans1 == "3")
                document.getElementById("C1").className = "btn btn-warning";
            if (ans1 == "4")
                document.getElementById("D1").className = "btn btn-warning";
        }
    }
};
document.getElementById("C1").onclick = function () {
    if (km1) {
        document.getElementById("conten1").style.display = "block";
        km1 = false;
        if (ans1 == "3") {
            document.getElementById("C1").className = "btn btn-success";
        }
        else {
            document.getElementById("C1").className = "btn btn-danger";
            if (ans1 == "2")
                document.getElementById("B1").className = "btn btn-warning";
            if (ans1 == "1")
                document.getElementById("A1").className = "btn btn-warning";
            if (ans1 == "4")
                document.getElementById("D1").className = "btn btn-warning";
        }
    }
};
document.getElementById("D1").onclick = function () {
    if (km1) {
        document.getElementById("conten1").style.display = "block";
        km1 = false;
        if (ans1 == "4") {
            document.getElementById("D1").className = "btn btn-success";
        }
        else {
            document.getElementById("D1").className = "btn btn-danger";
            if (ans1 == "2")
                document.getElementById("B1").className = "btn btn-warning";
            if (ans1 == "3")
                document.getElementById("C1").className = "btn btn-warning";
            if (ans1 == "1")
                document.getElementById("A1").className = "btn btn-warning";
        }
    };
};


//an3

var ans3 = document.getElementById('anser3').innerHTML;
var km3 = true;
    
    document.getElementById("A3").onclick = function () {
        if (km3) {
            document.getElementById("conten3").style.display = "block";
            km3 = false;
            if (ans3 == "1") {
                document.getElementById("A3").className = "btn btn-success";
            }
            else {
                document.getElementById("A3").className = "btn btn-danger";
                if (ans3 == "2")
                    document.getElementById("B3").className = "btn btn-warning";
                if (ans3 == "3")
                    document.getElementById("C3").className = "btn btn-warning";
                if (ans3 == "4")
                    document.getElementById("D3").className = "btn btn-warning";
            }
        }
    };
    document.getElementById("B3").onclick = function () {
        if (km3) {
            document.getElementById("conten3").style.display = "block";
            km3 = false;
            if (ans3 == "2") {
                document.getElementById("B3").className = "btn btn-success";
            }
            else {
                document.getElementById("B3").className = "btn btn-danger";
                if (ans3 == "1")
                    document.getElementById("A3").className = "btn btn-warning";
                if (ans3 == "3")
                    document.getElementById("C3").className = "btn btn-warning";
                if (ans3 == "4")
                    document.getElementById("D3").className = "btn btn-warning";
            }
        }
    };
document.getElementById("C3").onclick = function () {
        if (km3) {
            doument.getElementById("conten3").style.display = "block";
            km3 = false;
            if (ans3 == "3") {
                document.getElementById("C3").className = "btn btn-success";
            }
            else {
                document.getElementById("C3").className = "btn btn-danger";
                if (ans3 == "2")
                    document.getElementById("B3").className = "btn btn-warning";
                if (ans3 == "1")
                    document.getElementById("A3").className = "btn btn-warning";
                if (ans3 == "4")
                    document.getElementById("D3").className = "btn btn-warning";
            }
        }
    };
document.getElementById("D3").onclick = function () {
    if (km3) {
                document.getElementById("conten3").style.display = "block";
                km3 = false;
                if (ans3 == "4") {
                    document.getElementById("D3").className = "btn btn-success";
                }
                else {
                    document.getElementById("D3").className = "btn btn-danger";
                    if (ans3 == "2")
                        document.getElementById("B3").className = "btn btn-warning";
                    if (ans3 == "3")
                        document.getElementById("C3").className = "btn btn-warning";
                    if (ans3 == "1")
                        document.getElementById("A3").className = "btn btn-warning";
                }
    };
};

//an2

var ans2 = document.getElementById('anser2').innerHTML;
var km2 = true;

document.getElementById("A2").onclick = function () {
    if (km2) {
        document.getElementById("conten2").style.display = "block";
        km2 = false;
        if (ans2 == "1") {
            document.getElementById("A2").className = "btn btn-success";
        }
        else {
            document.getElementById("A2").className = "btn btn-danger";
            if (ans2 == "2")
                document.getElementById("B2").className = "btn btn-warning";
            if (ans2 == "3")
                document.getElementById("C2").className = "btn btn-warning";
            if (ans2 == "4")
                document.getElementById("D2").className = "btn btn-warning";
        }
    }
};
document.getElementById("B2").onclick = function () {
    if (km2) {
        document.getElementById("conten2").style.display = "block";
        km2 = false;
        if (ans2 == "2") {
            document.getElementById("B2").className = "btn btn-success";
        }
        else {
            document.getElementById("B2").className = "btn btn-danger";
            if (ans2 == "1")
                document.getElementById("A2").className = "btn btn-warning";
            if (ans2 == "3")
                document.getElementById("C2").className = "btn btn-warning";
            if (ans2 == "4")
                document.getElementById("D2").className = "btn btn-warning";
        }
    }
};
document.getElementById("C2").onclick = function () {
    if (km2) {
        document.getElementById("conten2").style.display = "block";
        km2 = false;
        if (ans2 == "3") {
            document.getElementById("C2").className = "btn btn-success";
        }
        else {
            document.getElementById("C2").className = "btn btn-danger";
            if (ans2 == "2")
                document.getElementById("B2").className = "btn btn-warning";
            if (ans2 == "1")
                document.getElementById("A2").className = "btn btn-warning";
            if (ans2 == "4")
                document.getElementById("D2").className = "btn btn-warning";
        }
    }
};
document.getElementById("D2").onclick = function () {
    if (km2) {
        document.getElementById("conten2").style.display = "block";
        km2 = false;
        if (ans2 == "4") {
            document.getElementById("D2").className = "btn btn-success";
        }
        else {
            document.getElementById("D2").className = "btn btn-danger";
            if (ans2 == "2")
                document.getElementById("B2").className = "btn btn-warning";
            if (ans2 == "3")
                document.getElementById("C2").className = "btn btn-warning";
            if (ans2 == "1")
                document.getElementById("A2").className = "btn btn-warning";
        }
    };
};

//an4

var ans4 = document.getElementById('anser4').innerHTML;
var km4 = true;

document.getElementById("A4").onclick = function () {
    if (km4) {
        document.getElementById("conten4").style.display = "block";
        km4 = false;
        if (ans4 == "1") {
            document.getElementById("A4").className = "btn btn-success";
        }
        else {
            document.getElementById("A4").className = "btn btn-danger";
            if (ans4 == "2")
                document.getElementById("B4").className = "btn btn-warning";
            if (ans4 == "3")
                document.getElementById("C4").className = "btn btn-warning";
            if (ans4 == "4")
                document.getElementById("D4").className = "btn btn-warning";
        }
    }
};
document.getElementById("B4").onclick = function () {
    if (km4) {
        document.getElementById("conten4").style.display = "block";
        km4 = false;
        if (ans4 == "2") {
            document.getElementById("B4").className = "btn btn-success";
        }
        else {
            document.getElementById("B4").className = "btn btn-danger";
            if (ans4 == "1")
                document.getElementById("A4").className = "btn btn-warning";
            if (ans4 == "3")
                document.getElementById("C4").className = "btn btn-warning";
            if (ans4 == "4")
                document.getElementById("D4").className = "btn btn-warning";
        }
    }
};
document.getElementById("C4").onclick = function () {
    if (km4) {
        document.getElementById("conten4").style.display = "block";
        km4 = false;
        if (ans4 == "3") {
            document.getElementById("C4").className = "btn btn-success";
        }
        else {
            document.getElementById("C4").className = "btn btn-danger";
            if (ans4 == "2")
                document.getElementById("B4").className = "btn btn-warning";
            if (ans4 == "1")
                document.getElementById("A4").className = "btn btn-warning";
            if (ans4 == "4")
                document.getElementById("D4").className = "btn btn-warning";
        }
    }
};
document.getElementById("D4").onclick = function () {
    if (km4) {
        document.getElementById("conten4").style.display = "block";
        km4 = false;
        if (ans4 == "4") {
            document.getElementById("D4").className = "btn btn-success";
        }
        else {
            document.getElementById("D4").className = "btn btn-danger";
            if (ans4 == "2")
                document.getElementById("B4").className = "btn btn-warning";
            if (ans4 == "3")
                document.getElementById("C4").className = "btn btn-warning";
            if (ans4 == "1")
                document.getElementById("A4").className = "btn btn-warning";
        }
    };
};

//an5

var ans5 = document.getElementById('anser5').innerHTML;
var km5 = true;

document.getElementById("A5").onclick = function () {
    if (km5) {
        document.getElementById("conten5").style.display = "block";
        km5 = false;
        if (ans5 == "1") {
            document.getElementById("A5").className = "btn btn-success";
        }
        else {
            document.getElementById("A5").className = "btn btn-danger";
            if (ans5 == "2")
                document.getElementById("B5").className = "btn btn-warning";
            if (ans5 == "3")
                document.getElementById("C5").className = "btn btn-warning";
            if (ans5 == "4")
                document.getElementById("D5").className = "btn btn-warning";
        }
    }
};
document.getElementById("B5").onclick = function () {
    if (km5) {
        document.getElementById("conten5").style.display = "block";
        km5= false;
        if (ans5 == "2") {
            document.getElementById("B5").className = "btn btn-success";
        }
        else {
            document.getElementById("B5").className = "btn btn-danger";
            if (ans5 == "1")
                document.getElementById("A5").className = "btn btn-warning";
            if (ans5 == "3")
                document.getElementById("C5").className = "btn btn-warning";
            if (ans5 == "4")
                document.getElementById("D5").className = "btn btn-warning";
        }
    }
};
document.getElementById("C5").onclick = function () {
    if (km5) {
        document.getElementById("conten5").style.display = "block";
        km5 = false;
        if (ans5 == "3") {
            document.getElementById("C5").className = "btn btn-success";
        }
        else {
            document.getElementById("C5").className = "btn btn-danger";
            if (ans5 == "2")
                document.getElementById("B5").className = "btn btn-warning";
            if (ans5 == "1")
                document.getElementById("A5").className = "btn btn-warning";
            if (ans5 == "4")
                document.getElementById("D5").className = "btn btn-warning";
        }
    }
};
document.getElementById("D5").onclick = function () {
    if (km5) {
        document.getElementById("conten5").style.display = "block";
        km5 = false;
        if (ans5 == "4") {
            document.getElementById("D5").className = "btn btn-success";
        }
        else {
            document.getElementById("D5").className = "btn btn-danger";
            if (ans5 == "2")
                document.getElementById("B5").className = "btn btn-warning";
            if (ans5 == "3")
                document.getElementById("C5").className = "btn btn-warning";
            if (ans5 == "1")
                document.getElementById("A5").className = "btn btn-warning";
        }
    };
};

//an6

var ans6 = document.getElementById('anser6').innerHTML;
var km6 = true;

document.getElementById("A6").onclick = function () {
    if (km6) {
        document.getElementById("conten6").style.display = "block";
        km6 = false;
        if (ans6 == "1") {
            document.getElementById("A6").className = "btn btn-success";
        }
        else {
            document.getElementById("A6").className = "btn btn-danger";
            if (ans6 == "2")
                document.getElementById("B6").className = "btn btn-warning";
            if (ans6 == "3")
                document.getElementById("C6").className = "btn btn-warning";
            if (ans6 == "4")
                document.getElementById("D6").className = "btn btn-warning";
        }
    }
};
document.getElementById("B6").onclick = function () {
    if (km6) {
        document.getElementById("conten6").style.display = "block";
        km5 = false;
        if (ans6 == "2") {
            document.getElementById("B6").className = "btn btn-success";
        }
        else {
            document.getElementById("B6").className = "btn btn-danger";
            if (ans6 == "1")
                document.getElementById("A6").className = "btn btn-warning";
            if (ans6 == "3")
                document.getElementById("C6").className = "btn btn-warning";
            if (ans6 == "4")
                document.getElementById("D6").className = "btn btn-warning";
        }
    }
};
document.getElementById("C6").onclick = function () {
    if (km6) {
        document.getElementById("conten6").style.display = "block";
        km6 = false;
        if (ans6 == "3") {
            document.getElementById("C6").className = "btn btn-success";
        }
        else {
            document.getElementById("C6").className = "btn btn-danger";
            if (ans6 == "2")
                document.getElementById("B6").className = "btn btn-warning";
            if (ans6 == "1")
                document.getElementById("A6").className = "btn btn-warning";
            if (ans6 == "4")
                document.getElementById("D6").className = "btn btn-warning";
        }
    }
};
document.getElementById("D6").onclick = function () {
    if (km6) {
        document.getElementById("conten6").style.display = "block";
        km6 = false;
        if (ans6 == "4") {
            document.getElementById("D6").className = "btn btn-success";
        }
        else {
            document.getElementById("D6").className = "btn btn-danger";
            if (ans6 == "2")
                document.getElementById("B6").className = "btn btn-warning";
            if (ans6 == "3")
                document.getElementById("C6").className = "btn btn-warning";
            if (ans6 == "1")
                document.getElementById("A6").className = "btn btn-warning";
        }
    };
};

//an7


var ans7 = document.getElementById('anser7').innerHTML;
var km7 = true;

document.getElementById("A7").onclick = function () {
    if (km7) {
        document.getElementById("conten7").style.display = "block";
        km7 = false;
        if (ans7 == "1") {
            document.getElementById("A7").className = "btn btn-success";
        }
        else {
            document.getElementById("A7").className = "btn btn-danger";
            if (ans7 == "2")
                document.getElementById("B7").className = "btn btn-warning";
            if (ans7 == "3")
                document.getElementById("C7").className = "btn btn-warning";
            if (ans7 == "4")
                document.getElementById("D7").className = "btn btn-warning";
        }
    }
};
document.getElementById("B7").onclick = function () {
    if (km7) {
        document.getElementById("conten5").style.display = "block";
        km7 = false;
        if (ans7 == "2") {
            document.getElementById("B7").className = "btn btn-success";
        }
        else {
            document.getElementById("B7").className = "btn btn-danger";
            if (ans7 == "1")
                document.getElementById("A7").className = "btn btn-warning";
            if (ans7 == "3")
                document.getElementById("C7").className = "btn btn-warning";
            if (ans7 == "4")
                document.getElementById("D7").className = "btn btn-warning";
        }
    }
};
document.getElementById("C7").onclick = function () {
    if (km7) {
        document.getElementById("conten7").style.display = "block";
        km7 = false;
        if (ans7 == "3") {
            document.getElementById("C7").className = "btn btn-success";
        }
        else {
            document.getElementById("C7").className = "btn btn-danger";
            if (ans7 == "2")
                document.getElementById("B7").className = "btn btn-warning";
            if (ans7 == "1")
                document.getElementById("A7").className = "btn btn-warning";
            if (ans7 == "4")
                document.getElementById("D7").className = "btn btn-warning";
        }
    }
};
document.getElementById("D7").onclick = function () {
    if (km7) {
        document.getElementById("conten7").style.display = "block";
        km7 = false;
        if (ans7 == "4") {
            document.getElementById("D7").className = "btn btn-success";
        }
        else {
            document.getElementById("D7").className = "btn btn-danger";
            if (ans7 == "2")
                document.getElementById("B7").className = "btn btn-warning";
            if (ans7 == "3")
                document.getElementById("C7").className = "btn btn-warning";
            if (ans7 == "1")
                document.getElementById("A7").className = "btn btn-warning";
        }
    };
};

//an8

var ans8 = document.getElementById('anser8').innerHTML;
var km8 = true;

document.getElementById("A8").onclick = function () {
    if (km8) {
        document.getElementById("conten8").style.display = "block";
        km8 = false;
        if (ans8 == "1") {
            document.getElementById("A8").className = "btn btn-success";
        }
        else {
            document.getElementById("A8").className = "btn btn-danger";
            if (ans8 == "2")
                document.getElementById("B8").className = "btn btn-warning";
            if (ans8 == "3")
                document.getElementById("C8").className = "btn btn-warning";
            if (ans8 == "4")
                document.getElementById("D8").className = "btn btn-warning";
        }
    }
};
document.getElementById("B8").onclick = function () {
    if (km8) {
        document.getElementById("conten8").style.display = "block";
        km8 = false;
        if (ans8 == "2") {
            document.getElementById("B8").className = "btn btn-success";
        }
        else {
            document.getElementById("B8").className = "btn btn-danger";
            if (ans8 == "1")
                document.getElementById("A8").className = "btn btn-warning";
            if (ans8 == "3")
                document.getElementById("C8").className = "btn btn-warning";
            if (ans8 == "4")
                document.getElementById("D8").className = "btn btn-warning";
        }
    }
};
document.getElementById("C8").onclick = function () {
    if (km8) {
        document.getElementById("conten8").style.display = "block";
        km8 = false;
        if (ans8 == "3") {
            document.getElementById("C8").className = "btn btn-success";
        }
        else {
            document.getElementById("C8").className = "btn btn-danger";
            if (ans8== "2")
                document.getElementById("B8").className = "btn btn-warning";
            if (ans8 == "1")
                document.getElementById("A8").className = "btn btn-warning";
            if (ans8 == "4")
                document.getElementById("D8").className = "btn btn-warning";
        }
    }
};
document.getElementById("D8").onclick = function () {
    if (km8) {
        document.getElementById("conten8").style.display = "block";
        km8 = false;
        if (ans8== "4") {
            document.getElementById("D8").className = "btn btn-success";
        }
        else {
            document.getElementById("D8").className = "btn btn-danger";
            if (ans8 == "2")
                document.getElementById("B8").className = "btn btn-warning";
            if (ans8== "3")
                document.getElementById("C8").className = "btn btn-warning";
            if (ans8 == "1")
                document.getElementById("A9").className = "btn btn-warning";
        }
    };
};

//an9

var ans9 = document.getElementById('anser9').innerHTML;
var km9 = true;

document.getElementById("A9").onclick = function () {
    if (km9) {
        document.getElementById("conten9").style.display = "block";
        km9= false;
        if (ans9 == "1") {
            document.getElementById("A9").className = "btn btn-success";
        }
        else {
            document.getElementById("A9").className = "btn btn-danger";
            if (ans9 == "2")
                document.getElementById("B9").className = "btn btn-warning";
            if (ans9 == "3")
                document.getElementById("C9").className = "btn btn-warning";
            if (ans9 == "4")
                document.getElementById("D9").className = "btn btn-warning";
        }
    }
};
document.getElementById("B9").onclick = function () {
    if (km9) {
        document.getElementById("conten9").style.display = "block";
        km9 = false;
        if (ans9 == "2") {
            document.getElementById("B9").className = "btn btn-success";
        }
        else {
            document.getElementById("B9").className = "btn btn-danger";
            if (ans9 == "1")
                document.getElementById("A9").className = "btn btn-warning";
            if (ans9 == "3")
                document.getElementById("C9").className = "btn btn-warning";
            if (ans9 == "4")
                document.getElementById("D9").className = "btn btn-warning";
        }
    }
};
document.getElementById("C9").onclick = function () {
    if (km9) {
        document.getElementById("conten9").style.display = "block";
        km9 = false;
        if (ans9 == "3") {
            document.getElementById("C9").className = "btn btn-success";
        }
        else {
            document.getElementById("C9").className = "btn btn-danger";
            if (ans9 == "2")
                document.getElementById("B9").className = "btn btn-warning";
            if (ans9 == "1")
                document.getElementById("A9").className = "btn btn-warning";
            if (ans == "4")
                document.getElementById("D9").className = "btn btn-warning";
        }
    }
};
document.getElementById("D9").onclick = function () {
    if (km9) {
        document.getElementById("conten9").style.display = "block";
        km9 = false;
        if (ans9 == "4") {
            document.getElementById("D9").className = "btn btn-success";
        }
        else {
            document.getElementById("D9").className = "btn btn-danger";
            if (ans9 == "2")
                document.getElementById("B9").className = "btn btn-warning";
            if (ans9 == "3")
                document.getElementById("C9").className = "btn btn-warning";
            if (ans9 == "1")
                document.getElementById("A9").className = "btn btn-warning";
        }
    };
};

//an10

var ans10 = document.getElementById('anser10').innerHTML;
var km10 = true;

document.getElementById("A10").onclick = function () {
    if (km10) {
        document.getElementById("conten10").style.display = "block";
        km10 = false;
        if (ans10 == "1") {
            document.getElementById("A10").className = "btn btn-success";
        }
        else {
            document.getElementById("A10").className = "btn btn-danger";
            if (ans10 == "2")
                document.getElementById("B10").className = "btn btn-warning";
            if (ans10 == "3")
                document.getElementById("C10").className = "btn btn-warning";
            if (ans10 == "4")
                document.getElementById("D10").className = "btn btn-warning";
        }
    }
};
document.getElementById("B10").onclick = function () {
    if (km10) {
        document.getElementById("conten10").style.display = "block";
        km10 = false;
        if (ans10 == "2") {
            document.getElementById("B10").className = "btn btn-success";
        }
        else {
            document.getElementById("B10").className = "btn btn-danger";
            if (ans10 == "1")
                document.getElementById("A10").className = "btn btn-warning";
            if (ans10 == "3")
                document.getElementById("C10").className = "btn btn-warning";
            if (ans10 == "4")
                document.getElementById("D10").className = "btn btn-warning";
        }
    }
};
document.getElementById("C10").onclick = function () {
    if (km10) {
        document.getElementById("conten10").style.display = "block";
        km10 = false;
        if (ans10 == "3") {
            document.getElementById("C10").className = "btn btn-success";
        }
        else {
            document.getElementById("C10").className = "btn btn-danger";
            if (ans10 == "2")
                document.getElementById("B10").className = "btn btn-warning";
            if (ans10 == "1")
                document.getElementById("A10").className = "btn btn-warning";
            if (ans10 == "4")
                document.getElementById("D10").className = "btn btn-warning";
        }
    }
};
document.getElementById("D10").onclick = function () {
    if (km10) {
        document.getElementById("conten10").style.display = "block";
        km10 = false;
        if (ans10 == "4") {
            document.getElementById("D10").className = "btn btn-success";
        }
        else {
            document.getElementById("D10").className = "btn btn-danger";
            if (ans10 == "2")
                document.getElementById("B10").className = "btn btn-warning";
            if (ans10 == "3")
                document.getElementById("C10").className = "btn btn-warning";
            if (ans10 == "1")
                document.getElementById("A10").className = "btn btn-warning";
        }
    };
};
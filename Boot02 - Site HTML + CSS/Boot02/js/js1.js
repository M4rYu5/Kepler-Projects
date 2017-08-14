/*var x1 = document.getElementById('inp1');
var x2 = document.getElementById('inp2');
var x3 = document.getElementById('inp3');


function adauga() {

    if (x1.value == "" && x2.value == "" && x3.value == "") {
        alert("Invalid input");
        return;
    }

    var table = document.getElementById("table1");

    var row = table.insertRow(1);

    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    
    cell1.innerHTML = x1.value;
    cell2.innerHTML = x2.value;
    cell3.innerHTML = x3.value;
}
*/

var a = document.createElement("ul");

var li = document.createElement("li");

li.innerText("item 1");

document.getElementById("a").innerHTML(li);
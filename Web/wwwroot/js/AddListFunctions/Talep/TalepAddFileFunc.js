﻿function TalepAddFileFunc() {

    var ftable = document.getElementById("FList");
    var file = document.getElementById("File");
    var description = document.getElementById("FileDesc");

    if (file.value != "" && description.value != "") {
        var row = ftable.insertRow(1);
        var cell = row.insertCell(0);
        var cell1 = row.insertCell(1);
        var cell2 = row.insertCell(2);

        cell.innerHTML = btnFile;
        cell1.innerHTML = file.value;
        cell2.innerHTML = description.value;

        file.value = "";
        description.value = "";

        file.focus();
    }
}
var btnFile = document.createElement('button');
btnFile.type = "submit";
btnFile.className = "btn btn-danger";
btnFile.value = "Sil";
btnFile.onclick = (function (Sil) { return function (Sil) { chooseUser(entry); } })(entry);
td.appendChild(btnFile);
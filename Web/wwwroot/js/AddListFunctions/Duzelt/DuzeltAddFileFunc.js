function DuzeltAddFileFunc() {

    var ftable = document.getElementById("FileList");
    var file = document.getElementById("FileName");
    var description = document.getElementById("FileDescription");

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
var btnFile = document.createElement("button");
btnFile.type = "button";
btnFile.className = "btn btn-danger";
btnFile.value = "Sil";
btnFile.onclick = (function (Sil) { return function (Sil) { chooseUser(entry); } })(entry);
td.appendChild(btnFile);
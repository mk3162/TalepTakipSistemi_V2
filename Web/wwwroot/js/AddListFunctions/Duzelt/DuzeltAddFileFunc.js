function DuzeltAddFileFunc() {

    //var buttonFile = document.createElement("button");
    //buttonFile.type = "button";
    //buttonFile.className = "btn btn-danger";
    //buttonFile.innerHTML = "Sil";
    //document.getElementById("FileRemove").appendChild(buttonFile);

    var filetable = document.getElementById("FileList");
    var file = document.getElementById("FileName");
    var description = document.getElementById("FileDescription");

    if (file.value != "" && description.value != "") {
        var row = filetable.insertRow(-1);
        var cell = row.insertCell(0);
        var cell1 = row.insertCell(1);
        var cell2 = row.insertCell(2);

        cell.innerHTML = '<input type="button" class="btn btn-danger" value="Sil" onclick="deleteRow(this)"/>';
        cell1.innerHTML = file.value;
        cell2.innerHTML = description.value;

        file.value = "";
        description.value = "";

        file.focus();
    }
}

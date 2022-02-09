
function TalepAddFileFunc() {

    //var btnFile = document.createElement('button');
    //btnFile.type = "button";
    //btnFile.className = "btn btn-danger";
    //btnFile.innerHTML = "Sil";
    //document.getElementById("RemoveFile").appendChild(btnFile);


    var ftable = document.getElementById("FList");
    var file = document.getElementById("File");
    var description = document.getElementById("FileDesc");


    if (file.value != "" && description.value != "") {

        var row = ftable.insertRow(-1);
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


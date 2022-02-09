function TalepAddProductFunc() {
    var ptable = document.getElementById("ProductList");
    var product = document.getElementById("ProductTalep");
    var amount = document.getElementById("Amount");
    var amountunit = document.getElementById("AmountTalep");
    var unitprice = document.getElementById("UnitPrice");
    var currency = document.getElementById("CurrencyTalep");
    var totalprice = document.getElementById("TotalPrice");
    var description = document.getElementById("Description");


    if (product.value != "" && amount.value != "" && amountunit.value != "" && unitprice.value != "" && currency.value != "" && totalprice.value != "" && description.value != "") {
        if (product.selectedIndex != "0" && amountunit.selectedIndex != "0" && currency.selectedIndex != "0") {
            var row = ptable.insertRow(1);
            var cell = row.insertCell(0);
            var cell1 = row.insertCell(1);
            var cell2 = row.insertCell(2);
            var cell3 = row.insertCell(3);
            var cell4 = row.insertCell(4);
            var cell5 = row.insertCell(5);
            var cell6 = row.insertCell(6);
            var cell7 = row.insertCell(7);

            cell.innerHTML = btnUrun;
            cell1.innerHTML = product.value;
            cell2.innerHTML = amount.value;
            cell3.innerHTML = amountunit.options[amountunit.selectedIndex].text;
            cell4.innerHTML = unitprice.value;
            cell5.innerHTML = currency.options[currency.selectedIndex].text;
            cell6.innerHTML = totalprice.value;
            cell7.innerHTML = description.value;

            product.value = "";
            amount.value = "";
            amountunit.value = "";
            unitprice.value = "";
            currency.value = "";
            totalprice.value = "";
            description.value = "";

            product.focus();
        }


    }

}


var btnUrun = document.createElement("button");
btnUrun.type = "submit";
btnUrun.className = "btn btn-danger";
btnUrun.value = "Sil";
btnUrun.onclick = (function (Sil) { return function (Sil) { chooseUser(entry); } })(entry);
td.appendChild(btnUrun);
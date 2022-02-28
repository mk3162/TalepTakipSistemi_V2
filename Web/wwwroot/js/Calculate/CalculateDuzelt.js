

function CalculateDuzelt() {
    var a = document.getElementById('AmountEdit').value;
    var b = document.getElementById('UnitPriceEdit').value;
    var result = parseFloat(a) * parseFloat(b);
    if (!isNaN(result)) {
        document.getElementById('TotalPriceEdit').value = result;
    }
}
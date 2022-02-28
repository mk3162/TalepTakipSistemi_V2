
function CalculateTalep() {
    var a = document.getElementById('AmountRequest').value;
    var b = document.getElementById('UnitPriceRequest').value;
    var result = parseFloat(a) * parseFloat(b);
    if (!isNaN(result)) {
        document.getElementById('TotalPriceRequest').value = result;
    }
}
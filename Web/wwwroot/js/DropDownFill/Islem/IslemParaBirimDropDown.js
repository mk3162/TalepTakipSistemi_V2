$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetCurrencies",
        dataType: "json",
        success: function (response) {
            $("#CurrencyIslem").empty().append('<option value="0"> Para Birimi Seçiniz </option>');
            for (let currency of response) {
                $("#CurrencyIslem").append('<option value="' + currency.siraNo + '"> ' + currency.tanimi + ' </option>');
            }
        }
    })
});
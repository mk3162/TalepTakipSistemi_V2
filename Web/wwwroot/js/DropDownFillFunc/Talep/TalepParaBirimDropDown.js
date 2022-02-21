$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetCurrencies",
        dataType: "json",
        success: function (response) {
            $("#CurrencyTalep").empty().append('<option value="0"> --Para Birimi Seçiniz-- </option>');
            for (let currency of response) {
                $("#CurrencyTalep").append('<option value="' + currency.tanimi + '"> ' + currency.tanimi + ' </option>');
            }
        }
    })
});
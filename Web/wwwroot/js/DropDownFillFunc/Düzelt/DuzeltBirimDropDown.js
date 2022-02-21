$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetUnits",
        dataType: "json",
        success: function (response) {
            $("#AmountDuzelt").empty().append('<option value="0"> --Birim Seçiniz-- </option>');
            for (let unit of response) {
                $("#AmountDuzelt").append('<option value="' + unit.tanimi + '"> ' + unit.tanimi + ' </option>');
            }
        }
    })
});
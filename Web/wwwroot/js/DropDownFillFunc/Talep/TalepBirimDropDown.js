$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetUnits",
        dataType: "json",
        success: function (response) {
            $("#AmountTalep").empty().append('<option value="0"> --Birim Seçiniz-- </option>');
            for (let unit of response) {
                $("#AmountTalep").append('<option value="' + unit.siraNo + '"> ' + unit.tanimi + ' </option>');
            }
        }
    })
});
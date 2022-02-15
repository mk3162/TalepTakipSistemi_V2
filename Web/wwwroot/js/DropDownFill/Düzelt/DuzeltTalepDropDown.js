$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetRequestOwners",
        dataType: "json",
        success: function (response) {
            $("#RequestDuzelt").empty().append('<option value="0"> --Talep Sahibi Seçiniz-- </option>');
            for (let request of response) {
                $("#RequestDuzelt").append('<option value="' + request.kodu + '"> ' + request.adiSoyadi + ' </option>');
            }
        }
    })
});
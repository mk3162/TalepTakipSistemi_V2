$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetRequestOwners",
        dataType: "json",
        success: function (response) {
            $("#ProcessorIslem").empty().append('<option value="0"> Talep Sahibi Seçiniz </option>');
            for (let request of response) {
                $("#ProcessorIslem").append('<option value="' + request.kodu + '"> ' + request.adiSoyadi + ' </option>');
            }
        }
    })
});
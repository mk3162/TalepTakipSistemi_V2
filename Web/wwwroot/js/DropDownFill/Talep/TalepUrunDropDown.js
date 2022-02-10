$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetProducts",
        dataType: "json",
        success: function (response) {
            $("#ProductTalep").empty().append('<option value="0"> Ürün Seçiniz </option>');
            for (let product of response) {
                $("#ProductTalep").append('<option value="' + product.urunTanimi + '"> ' + product.urunTanimi + ' </option>');
            }
        }
    })
}); 
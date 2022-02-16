$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetProducts",
        dataType: "json",
        success: function (response) {
            $("#ProductDuzelt").empty().append('<option value="0"> --Ürün Seçiniz-- </option>');
            for (let product of response) {
                $("#ProductDuzelt").append('<option value="' + product.urunKodu + '"> ' + product.urunTanimi + ' </option>');
            }
        }
    })
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetSuppliers",
        dataType: "json",
        success: function (response) {
            $("#SupplierIslem").empty().append('<option value="0"> Tedarikçi Seçiniz </option>');
            for (let supplier of response) {
                $("#SupplierIslem").append('<option value="' + supplier.tedarikciKodu + '"> ' + supplier.tedarikciUnvani + ' </option>');
            }
        }
    })
});
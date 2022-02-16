$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetTypes",
        dataType: "json",
        success: function (response) {
            $("#TypeTalep").empty().append('<option value="0"> --Tip Seçiniz-- </option>');
            for (let type of response) {
                $("#TypeTalep").append('<option value="' + type.siraNo + '"> ' + type.tanimi + ' </option>');
            }
        }
    })
});
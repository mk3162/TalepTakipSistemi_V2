$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetCompany",
        dataType: "json",
        success: function (response) {
            $("#CompaniesDuzelt").empty().append('<option value="0"> Şirket Seçiniz </option>');
            for (let company of response) {
                $("#CompaniesDuzelt").append('<option value="' + company.siraNo + '"> ' + company.tanimi + ' </option>');
            }
        },
    });


    $('#CompaniesDuzelt').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetDepartment",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#DepartmentDuzelt").removeAttr('disabled');
                $("#DepartmentDuzelt").empty().append('<option value="0"> Departman Seçiniz </option>');

                for (let department of response) {
                    $("#DepartmentDuzelt").append('<option value="' + department.siraNo + '"> ' + department.tanimi + ' </option>');
                }
            },
        });
    });

    $('#CompaniesDuzelt').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetLocation",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#LocationDuzelt").removeAttr('disabled');
                $("#LocationDuzelt").empty().append('<option value="0"> Lokasyon Seçiniz </option>');

                for (let location of response) {
                    $("#LocationDuzelt").append('<option value="' + location.siraNo + '"> ' + location.tanimi + ' </option>');
                }
            },
        });
    });

    $('#CompaniesDuzelt').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetProject",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#ProjectDuzelt").removeAttr('disabled');
                $("#ProjectDuzelt").empty().append('<option value="0"> Proje Seçiniz </option>');

                for (let project of response) {
                    $("#ProjectDuzelt").append('<option value="' + project.siraNo + '"> ' + project.tanimi + ' </option>');
                }
            },
        });
    });

    $('#CompaniesDuzelt').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetExpenseCenter",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#CostDuzelt").removeAttr('disabled');
                $("#CostDuzelt").empty().append('<option value="0"> Departman Seçiniz </option>');

                for (let expense of response) {
                    $("#CostDuzelt").append('<option value="' + expense.siraNo + '"> ' + expense.tanimi + ' </option>');
                }
            },
        });
    });


    $('#DepartmentDuzelt').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetService",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#ServiceDuzelt").removeAttr('disabled');
                $("#ServiceDuzelt").empty().append('<option value="0"> Servis Seçiniz </option>');

                for (let service of response) {
                    $("#ServiceDuzelt").append('<option value="' + service.siraNo + '"> ' + service.tanimi + ' </option>');
                }
            },
        });
    });
});
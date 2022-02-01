$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetCompany",
        dataType: "json",
        success: function (response) {
            $("#CompaniesIslem").empty().append('<option value="0"> Şirket Seçiniz </option>');
            for (let company of response) {
                $("#CompaniesIslem").append('<option value="' + company.siraNo + '"> ' + company.tanimi + ' </option>');
            }
        },
    });


    $('#CompaniesIslem').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetDepartment",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#DepartmentIslem").removeAttr('disabled');
                $("#DepartmentIslem").empty().append('<option value="0"> Departman Seçiniz </option>');

                for (let department of response) {
                    $("#DepartmentIslem").append('<option value="' + department.siraNo + '"> ' + department.tanimi + ' </option>');
                }
            },
        });
    });

    $('#CompaniesIslem').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetLocation",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#LocationIslem").removeAttr('disabled');
                $("#LocationIslem").empty().append('<option value="0"> Lokasyon Seçiniz </option>');

                for (let location of response) {
                    $("#LocationIslem").append('<option value="' + location.siraNo + '"> ' + location.tanimi + ' </option>');
                }
            },
        });
    });

    $('#CompaniesIslem').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetProject",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#ProjectIslem").removeAttr('disabled');
                $("#ProjectIslem").empty().append('<option value="0"> Proje Seçiniz </option>');

                for (let project of response) {
                    $("#ProjectIslem").append('<option value="' + project.siraNo + '"> ' + project.tanimi + ' </option>');
                }
            },
        });
    });

    $('#CompaniesIslem').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetExpenseCenter",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#CostIslem").removeAttr('disabled');
                $("#CostIslem").empty().append('<option value="0"> Departman Seçiniz </option>');

                for (let expense of response) {
                    $("#CostIslem").append('<option value="' + expense.siraNo + '"> ' + expense.tanimi + ' </option>');
                }
            },
        });
    });


    $('#DepartmentIslem').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetService",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#ServiceIslem").removeAttr('disabled');
                $("#ServiceIslem").empty().append('<option value="0"> Servis Seçiniz </option>');

                for (let service of response) {
                    $("#ServiceIslem").append('<option value="' + service.siraNo + '"> ' + service.tanimi + ' </option>');
                }
            },
        });
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Request/GetCompany",
        dataType: "json",
        success: function (response) {
            $("#CompaniesTalep").empty().append('<option value="0"> Şirket Seçiniz </option>');
            for (let company of response) {
                $("#CompaniesTalep").append('<option value="' + company.siraNo + '"> ' + company.tanimi + ' </option>');
            }
        },
    });


    $('#CompaniesTalep').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetDepartment",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#DepartmentTalep").removeAttr('disabled');
                $("#DepartmentTalep").empty().append('<option value="0"> Departman Seçiniz </option>');

                for (let department of response) {
                    $("#DepartmentTalep").append('<option value="' + department.siraNo + '"> ' + department.tanimi + ' </option>');
                }
            },
        });
    });

    $('#CompaniesTalep').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetLocation",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#LocationTalep").removeAttr('disabled');
                $("#LocationTalep").empty().append('<option value="0"> Lokasyon Seçiniz </option>');

                for (let location of response) {
                    $("#LocationTalep").append('<option value="' + location.siraNo + '"> ' + location.tanimi + ' </option>');
                }
            },
        });
    });

    $('#CompaniesTalep').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetProject",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#ProjectTalep").removeAttr('disabled');
                $("#ProjectTalep").empty().append('<option value="0"> Proje Seçiniz </option>');

                for (let project of response) {
                    $("#ProjectTalep").append('<option value="' + project.siraNo + '"> ' + project.tanimi + ' </option>');
                }
            },
        });
    });

    $('#CompaniesTalep').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetExpenseCenter",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#CostTalep").removeAttr('disabled');
                $("#CostTalep").empty().append('<option value="0"> Departman Seçiniz </option>');

                for (let expense of response) {
                    $("#CostTalep").append('<option value="' + expense.siraNo + '"> ' + expense.tanimi + ' </option>');
                }
            },
        });
    });


    $('#DepartmentTalep').change(function () {
        let siraNo = $(this).val();
        $.ajax({
            type: "POST",
            url: "../Request/GetService",
            data: { SiraNo: siraNo },
            dataType: "json",
            success: function (response) {
                $("#ServiceTalep").removeAttr('disabled');
                $("#ServiceTalep").empty().append('<option value="0"> Servis Seçiniz </option>');

                for (let service of response) {
                    $("#ServiceTalep").append('<option value="' + service.siraNo + '"> ' + service.tanimi + ' </option>');
                }
            },
        });
    });
});
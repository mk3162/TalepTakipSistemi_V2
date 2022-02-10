
$('table').on('click', 'input[type="button"]', function (e) {
    if (!confirm("Bu kaydı silmek istediğinize emin misiniz?")) {
        return;
    }
    $(this).closest('tr').remove();
})




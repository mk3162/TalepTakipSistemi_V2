
$('table').on('click', 'input[type="button"]', function (e) {
    $(this).closest('tr').remove();
})
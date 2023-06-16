$(document).ready(function () {
    $(".nameofcard").click(function () {
        var innerText = $(this).text();
        console.log(innerText);
        $.ajax({
            url: `shop/GetText?searchText=${innerText}`,
            type: 'Get',
            success: function (result) {
                console.log("Lannn");
            }
        });
    });
});


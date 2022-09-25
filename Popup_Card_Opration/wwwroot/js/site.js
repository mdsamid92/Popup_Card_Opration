$(function () {
    var PlaceHolderElement = $('#PlaceHolderHere');
    $('button[data-toggle="ajax-modal"]').click(function (event) {
        alert("ok")
        var url = $(this).data('url');
        var decodedUrl = decodeURIComponent(url);
        $.get(decodedUrl).done(function (data) {
            PlaceHolderElement.html(data);
            PlaceHolderElement.find('.modal').modal('show');
        })
    })

    PlaceHolderElement.on('click', '[data-dismiss="modal"]', function (event) {
            PlaceHolderElement.find('.modal').modal('hide');
    })
})

   










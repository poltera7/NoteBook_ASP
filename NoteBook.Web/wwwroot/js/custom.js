/*$(document).ready(function () {

    //alert('Hello!');
    $.ajax({
        type: 'POST',
        url: '/Default/DoAction?action=test-param&state-id=0',
        //contentType: 'text/plain',
        cache: false
    }).done(function (responseText, textStatus, jqXHR) {
        //if got code 200
        if (responseText !== '' && responseText !== 'error') {
            //
            console.log(responseText);
        } else {
            //
        }

    }).fail(function (jqXHR, textStatus, errorThrown) {
        console.log(textStatus);
    });
});*/
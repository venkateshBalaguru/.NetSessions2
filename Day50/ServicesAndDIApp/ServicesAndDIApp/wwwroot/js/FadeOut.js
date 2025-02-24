$(document).ready(function () {
    $('h1').text("This is Display View ")//setter
    var h1 = $('h1').text()//getter
    console.log(h1)
    $('h1')
        .css('color', 'red')
        .css('background-color', 'yellow')
        .css('font-size', '36px')
        .fadeOut(5 * 1000);
        });

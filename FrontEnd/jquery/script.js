//$(document).ready(function(){   //teljes oldal betöltésre került
$(function () {     //ready-t tartalmazó sor rövidebb írásmódja
    $(".kek").click(function () {     //kek osztályú elemhez kattintás eseményt csatolok
        $(this).hide(2000);     //Amelyikre kattintottam, tűnjön el!
    });
    $('.btn-kek').click(function () {
        //        $(".kek").show(1000);
        $(".kek").toggle(1000, function () {  //animációt követően
            if ($(this).is(":hidden")) {     //megnézem, hogy látszik-e az elem, Rejtett állapotú-e?
                $(".btn-kek").text("Mutat");    //.text() innerText-nek a megfelelője
            } else {
                $(".btn-kek").text("Elrejt");
            }
        });
    });
    $(".sarga").on("mouseover", function () {
        $(this).fadeOut(1000);  //átlátszóvá válik az elem
        //fadeIn() - megjelenik
        //fadeToggle()  
    });

    $(".szinvalto").dblclick(function () {
        $(this).css("background-color", "black");
    });

    $(".szinvalto").click(function () {
        $(this).toggleClass("bordered")
    });

    $("input[type=text]").keyup(function () {
        let v = $(this).val();
        $("#be").text(v);

        function myColour() {

            // Get the value of red color
            var red = document.getElementById('r').value;

            // Get the value of green color
            var green = document.getElementById('g').value;

            // Get the value of blue color
            var blue = document.getElementById('b').value;

            var colour = 'rgb(' + red + ',' + green + ',' + blue + ')';


            // On changing red range slider myColour()
            // function is called  
            document.getElementById('red')
                .addEventListener('input', myColour);

            // On changing green range slider myColour()
            // function is called
            document.getElementById('green')
                .addEventListener('input', myColour);

            // On changing blue range slider myColour()
            // function is called
            document.getElementById('blue')
                .addEventListener('input', myColour);

        });



})


//ready vége

//https://www.geeksforgeeks.org/how-to-create-rgb-color-generator-using-html-css-and-javascript/
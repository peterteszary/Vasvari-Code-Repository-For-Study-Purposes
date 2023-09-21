$(document).ready(function() {
    //Teljes oldal letöltésre került..
    $(".kek").click(function(){
        $(this).hide(2000);
    })
    $('.btn-kek').click(function(){
       // $(".kek").show();
         $(".kek").toggle(1000);
    })
    })

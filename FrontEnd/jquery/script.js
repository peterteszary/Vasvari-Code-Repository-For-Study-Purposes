$(document).ready(function() {
    //Teljes oldal letöltésre került..
    $(".kek").click(function(){
        $(this).hide(2000);
    })
    $('.btn-kek').click(function(){
       // $(".kek").show();
         $(".kek").toggle(1000, function(){
            if ($(this).is(":hidden")){
                $(".btn-kek").text("Mutat")
                }else{
                    $(".btn-kek").text("Elrejt");
            }
         });
    })
    })

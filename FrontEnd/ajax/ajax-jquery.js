$(document).ready(function(){
    $.get('https://jsonplaceholder.typicode.com/users/1', function(d){
        console.log(Object.keys(d)) //Objektum kulcsainak lekérdezése egy tömbbe.
       // console.log(Object.values(d)) // Objektum kulcsokhoz tartozó értékek lekérdezése

        //A Kapot objektumot teljes mértékben járjuk be és jelenítsük meg egy egymásba ágyazott listában.

        if (typeof d == 'object'){
            $(".content").append("<ul></ul>");
            for (const key in d) {
                if (Object.hasOwnProperty.call(d, key)) {
            
                    if (typeof d[key] == 'object') {
            
                        $(".content > ul").append(`<li> ${key} <ul></ul> </li>`)
                        const obj2 = d[key];
                        for (const key2 in obj2) {
                            if (Object.hasOwnProperty.call(obj2, key2)) {
                                const element = obj2[key2];
                                $("li > ul").append(`<li> ${key2} : ${obj2[key2]} </li>`)
                        }
                    } 
                    } else {
                        $(".content > ul").append(`<li>${key} : ${d[key]}</li>`) 
                    }

                    
                    
                }
            }
        }
    })
})
$(document).ready(function(){
    $.get('https://jsonplaceholder.typicode.com/users/1', function(d){
        console.log(Object.keys(d)) //Objektum kulcsainak lekérdezése egy tömbbe.
        console.log(Object.values(d)) // Objektum kulcsokhoz tartozó értékek lekérdezése
    })
})
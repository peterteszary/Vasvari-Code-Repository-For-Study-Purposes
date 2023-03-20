let urlap;

function init(){
    console.log('Oldal betöltése kész.')
   // document.getElementById('aszf').addEventListener('change', aszf(this))
    urlap = document.querySelectorAll('input')
    console.log(urlap)
    urlap[0].addEventListener('blur', nameCheck)
    
   //document.querySelectorAll('input[name="penznem"]').addEventListener('change',penz)
}

function nameCheck(){
    let v = urlap[0].value;
    let p = /[a-zA-Z\s]{5,}/
    
    if (!p.test(v)){
        alert('Név formátuma nem megfelelő!')
    }
}
function penz(elem){
    console.log(elem.value)
}
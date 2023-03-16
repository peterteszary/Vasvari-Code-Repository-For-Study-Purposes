function init(){
    document.getElementById('aszf').addEventListener('onchange', aszf(this))
    document.querySelector('[name=submit]').addEventListener('onmouseenter',aszf)
}

function aszf(){
    if (document.getElementById('aszf'.checked)){
        console.log("aszf elfogadva")
    }
    
    
}
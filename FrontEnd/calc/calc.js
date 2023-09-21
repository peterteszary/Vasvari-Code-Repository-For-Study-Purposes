function init() {
    let nums = document.querySelectorAll('.num');
    let sc = document.querySelector('.screen'); //screen opsztályú elem kiválasztása
    // for (let i = 0; i < btns.length; i++) {
    //     console.log(btns[i]);        
    // }
    nums.forEach((v, k) => {
        //console.log(v.innerText);
        v.addEventListener("click", () => { //kattintás esemény csatolása a num osztályú elemekhez
            if (sc.innerText != "0") {  //már valamilyen szám van a kijelzőn, vagy valós szám lesz
                sc.innerText += v.innerText;    //összefűzés
            } else {
                //0-t látok a kijelzőn
                if ((v.innerText == ".") && (sc.innerText.indexOf(".") == -1)) {
                    //Tizedes pontra kattintottak, de a kijelző még nem tartalmaz pontot
                    sc.innerText += v.innerText;
                } else {
                    //Számok valamelyikére kattintottak
                    sc.innerText = v.innerText;
                }
            }
        });
    })

    document.querySelectorAll(".op").forEach((v,k) => {
        let op = v.innerText;   //op osztályú tr elemek szövegei
        //console.log(v.innerText);
        v.addEventListener("click", () => {
            if (op == "x2"){
                console.log(sc);
                sc.innerText = Math.pow(Number(sc.innerText), 2);
            }
        })
        
    })

}

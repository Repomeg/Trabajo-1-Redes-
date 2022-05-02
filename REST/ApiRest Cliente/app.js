var url;
fetch('config.json')
.then(data => data.json())
.then(data => {
    url = data.url;
})

//-.-.-.-.- Rut -.-.-.-.-.-.-
var contenidoRut = document.querySelector('#contenidoRut')
var errorRut = document.querySelector('#errorRut')

function jsonRutGet(){
    fetch(url + 'rut')
    .then(data => data.json())
    .then(data => {
        contenidoRut.innerHTML = `
        <div class="alert alert-info text-light bg-primary" role="alert">
        <p>El RUT es: ${data.validate}</p>
        </div>
        `
    });
}

var formularioRut = document.getElementById('formularioRut');

formularioRut.addEventListener('submit',function(e){
    e.preventDefault();
    var datos = new FormData(formularioRut);
    var rut = datos.get('InputRut');
    var verifyCode = rut.charAt(rut.length -1);
    var verifyCodeTarget = ['1','2','3','4','5','6','7','8','9','0','k','K'];
    min=["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","u","v",
    "w","x","y","z","A","B","C","D","E","F","G","H","I","J","K","L","M","N",
    "O","P","Q","R","S","U","V","W","X","Y","Z"];

    if(rut.includes('-') && contains(verifyCode,verifyCodeTarget) && !contains(rut,min) && rut.length == 9 || rut.length == 10){
        rut = rut.slice(0, -2)

        const jsonRutPost = new Request(url + 'rut', {
            method: 'POST',
            headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
            },
            body: JSON.stringify({rut: rut, verifyCode: verifyCode})
        });
        fetch(jsonRutPost)
        .then(response => {
            if (!response.ok) throw Error(response.status);
            return response;
        })
        .then(response => {
        errorRut.innerHTML=`
        <div class="alert alert-success text-light bg-primary" role="alert">El RUT ingresado es valido</div>
        `
        jsonRutGet();
        })
        .catch(error => console.log(error));
    }
    else{
        errorRut.innerHTML=`<div class="alert alert-danger text-light bg-primary" role="alert">Por favor, ingrese un rut valido.</div>`
    }
    
})

//-.-.-.- funcion auxiliar -.-.-.-.-.

function contains(target, pattern){
    var value = 0;
    pattern.forEach(function(word){
      value = value + target.includes(word);
    });
    return (value === 1)
}

//-.-.-.-.- Split -.-.-.-.-.-.-

var contenidoSplit = document.querySelector('#contenidoSplit')
var errorSplit = document.querySelector('#errorSplit')

function jsonSplitGet(){
    fetch(url + 'split')
    .then(data => data.json())
    .then(data => {
        var nombres = data.nombres;
        data.nombres.forEach(element => {
            contenidoSplit.innerHTML = `${element}`
        });
        contenidoSplit.innerHTML = ` <div class="alert alert-info text-light bg-primary" role="alert">`
        
        + `<p>Nombres: ${data.nombres}<p>` +
        `<p>Apellido Paterno : ${data.paterno}</p>
        <p>Apellido Materno: ${data.materno}</p>
        </div>
        `
    })
}

var formularioSplit = document.getElementById('formularioSplit');


formularioSplit.addEventListener('submit',function(e){
    e.preventDefault();
    var datos = new FormData(formularioSplit);
    var InputSplit = datos.get('InputSplit');
    var iChars = "@#$%^&*()+=-]\\[\';,!/}|\"{:<>?";
    countSplit = (InputSplit.match(/ /g) || []).length;

    if(InputSplit.includes(' ') && countSplit >= 2 ) {    
        const jsonSplitPost = new Request(url + 'split', {
            method: 'POST',
            headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
            },
            body: JSON.stringify({nombreCompleto: InputSplit})
        });
        fetch(jsonSplitPost)
        .then(response => {
            if (!response.ok) throw Error(response.status);
            return response;
        })
        .then(response => {
        errorSplit.innerHTML=`<div class="alert alert-success text-light bg-primary" role="alert">El Nombre ingresado es valido.</div>
        `
        jsonSplitGet();
        })
        .catch(error => console.log(error));
    }
    else{
        errorSplit.innerHTML=`<div class="alert alert-danger text-light bg-primary" role="alert">Por favor, ingrese un nombre valido.</div>`
    }
    
})


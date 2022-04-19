function pagrut(){
    document.location.href="/rut.html"
}
function pagnombre(){
    document.location.href="/nombre.html"
}

function verificarRUT(){
var numeroRUT= document.getElementById("numrut").value;
var digitoRUT= document.getElementById("digver").value;
if(numeroRUT>22000000){
    alert("Rut sobrepasa el maximo");
}
if(numeroRUT.length!=8){
    alert("Si el RUT es bajo los 10 millones, por favor agregue un 0 antes");
}
fetch('https://janieck78.pythonanywhere.com/'+numeroRUT+'-'+digitoRUT,{
    mode:'no-cors',
}) //VER RECEPCION DE DATOS DESDE EL JSON DE LA API
  .then(response => response.json())
  .then(data => console.log(data));
console.log(numeroRUT);
console.log(digitoRUT);

}

function separarNombre(){
var nombre= document.getElementById("nombre").value;
if(isNaN(nombre)!=true){
    alert("Por favor ingrese un nombre valido.")
}
console.log(nombre);
}

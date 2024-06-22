// let baseUrl = "https://api-traveller.azurewebsites.net/";
let baseUrl = "https://localhost:7142/";

document.getElementById("btnPesquisar").onclick = function() 
{
    pesquisar()
};

function pesquisar()
{

    console.log("OK");
    // Pegar o valor da cidade de digitada no input
    // let cidade_digitada = document.getElementById("inputCidade").value;
    // let data_digitada = document.getElementById("inputData").value;

    // // Codigo para realizar uma busca (get, put, update, delete) em uma API
    // // Atraves de uma Request
    // var xmlHttp = new XMLHttpRequest();
 
    // // Linha de codigo feita para realiazar uma request/requisicao a uma API para pegar valores
    // // GET = Verbo HttpGet
    // https://localhost:7142/Pesquisa/PorNomeData?cidade=atibaia&data=18-09-2023
    // var url = "https://localhost:7142/Hoteis/PorNomeData?cidade=" + cidade_digitada + "&data=" + data_digitada;
    // xmlHttp.open("GET", url, false); 
    // xmlHttp.send(null);
    
    // let hoteis = JSON.parse(xmlHttp.responseText);


    
    // for(var h = 0; h < hoteis.dados.length; h++){

    //     var div = document.createElement("div");
    //     div.innerHTML = hoteis.dados[h].nome;


    //     var divRef = document.getElementById("resultado");
    //     divRef.appendChild(div);

    //     console.log(hoteis.dados[h].nome);
    // }

    // console.log(hoteis);

  
};
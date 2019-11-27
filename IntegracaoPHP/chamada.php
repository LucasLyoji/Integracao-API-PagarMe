<!DOCTYPE html>
<html>
<head>
<style>

@import url(https://fonts.googleapis.com/css?family=Open+Sans:400,600,700);
body {
  background-color: #e6fee6;
}
.button {
    width: 400px;
    height: 40px;
    background: linear-gradient(to bottom, #ADFF2F 0%,#90EE90 100%); /* W3C */
    border: none;
    border-radius: 5px;
    position: relative;
    border-bottom: 4px solid #3CB371;
    color: #000000;
    font-weight: 600;
    font-family: 'Open Sans', sans-serif;
    text-shadow: 1px 1px 1px rgba(0,0,0,.4);
    font-size: 15px;
    text-align: left;
    text-indent: 5px;
    box-shadow: 0px 3px 0px 0px rgba(0,0,0,.2);
    cursor: pointer;
    display: block;
    margin: 0 auto;
    margin-bottom: 20px;
    margin-left: 250px;
}
button:active {
  box-shadow: 0px 2px 0px 0px rgba(0,0,0,.2);
  top: 1px;
}

button:after {
  content: "";
  width: 0;
  height: 0;
  display: block;
  border-top: 20px solid #3CB371;
  border-bottom: 20px solid #3CB371;
  border-left: 16px solid transparent;
  border-right: 20px solid #3CB371;
  position: absolute;
  opacity: 0.6; 
  right: 0;
  top: 0;
  border-radius: 0 5px 5px 0;  
}
a {
    text-decoration: none;
} 

</style>
<body>
<h2>Integração da API-PagarMe em PHP</h2>

<?php

?>
<br>
<button class="button"> <a href="split.php"> Clique aqui para realizar uma transação com split </a> </button>
<br>
<button class="button"> <a href="recorrencia.php"> Clique aqui para realizar uma assinatura </a> </button>
<br>
<button class="button"> <a href="transfer.php"> Clique aqui para realizar uma transferência </a> </button>
<br>
<button class="button"> <a href="antecipacao.php"> Clique aqui para realizar uma antecipação </a> </button>
<br>
<button class="button"> <a href="recorrenciaSplit.php"> Clique aqui para realizar uma assinatura com split </a> </button>
<br>
<button class="button"> <a href="estornoSplit.php"> Clique aqui para realizar um estorno com split </a> </button>
<br>
<button class="button"> <a href="postback.php"> Clique aqui para verificar o status de um postback </a> </button>

</body>
</head>
</html>

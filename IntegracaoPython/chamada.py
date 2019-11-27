# This Python file uses the following encoding: utf-8

from split import Split  
from recorrencia import Recorrencia  
from transfer import Transfer  
from antecipacao import Antecipacao  
from recorrenciaSplit import RecorrenciaSplit
from estornoSplit import EstornoSplit
from postback import Postback

print("Precione 1 para realizar uma transação com split")
print("Precione 2 para realizar uma assinatura")
print("Precione 3 para realizar uma transferência")
print("Precione 4 para realizar uma antecipação")
print("Precione 5 para realizar uma assinatura com split")
print("Precione 6 para realizar um estorno com split")
print("Precione 7 para verificar o status de um postback")

esco = raw_input("")
        
if (esco == "1"): 

    print("A transação numero " + str(Split()) + " foi criada!")

elif (esco == "2"):

    print("A assinatura numero " +  str(Recorrencia()) + " foi criada!")

elif (esco == "3"):

    retorno = Transfer()
    print("A transferencia: " + str(retorno[0])  + ", de " + str(retorno[1]) + " centavos foi realizada para a conta bancária do recebedor " + str(retorno[2]) + "!")

elif (esco == "4"):

    retorno = Antecipacao()
    print("A antecipação: " + str(retorno[0]) + ", de " + str(retorno[1]) + " centavos foi criada para o recebedor " + str(retorno[2]) + "!")

elif (esco == "5"):
    
    print("A assinatura com split numero " +  str(RecorrenciaSplit()) + " foi criada!")

elif (esco == "6"):
    
    print("A transação numero " + str(EstornoSplit()) + " foi criada e estornada!")

elif (esco == "7"):
    
    retorno = Postback()
    print("O postback da transação " + str(retorno[0]) + " está com status " + str(retorno[1]) + "!")

else:

    print("hi dumb dumb")

require_relative 'split'
require_relative 'recorrencia'
require_relative 'transfer'
require_relative 'antecipacao'
require_relative 'recorrenciaSplit'
require_relative 'estornoSplit'

puts "Precione 1 para realizar uma transação com split"
puts "Precione 2 para realizar uma assinatura"
puts "Precione 3 para realizar uma transferência"
puts "Precione 4 para realizar uma antecipação"
puts "Precione 5 para realizar uma assinatura com split"
puts "Precione 6 para realizar um estorno com split"

esco  = gets
        
if esco.chomp == "1"

    puts "A transação numero " + Split()["id"].to_s + " foi criada!"

elsif esco.chomp  == "2"

    puts "A assinatura numero " +  Recorrencia()["id"].to_s + " foi criada!"

elsif esco.chomp  == "3"

    retorno = Transfer()
    puts "A transferencia: " + retorno["id"].to_s  + ", de " + retorno["amount"].to_s + " centavos foi realizada para a conta bancária do recebedor " + retorno["source_id"].to_s + "!"

elsif esco.chomp  == "4"

    retorno = Antecipacao()
    puts "A antecipação: " + retorno[0]["id"].to_s + ", de " + retorno[0]["amount"].to_s + " centavos foi criada para o recebedor " + retorno[1].to_s + "!"

elsif esco.chomp  == "5"
    
    puts "A assinatura com split numero " +  RecorrenciaSplit()["id"].to_s + " foi criada!"

elsif esco.chomp  == "6"
    
    puts "A transação numero " + EstornoSplit()["id"].to_s + " foi criada e estornada!"

else

    puts "hi dumb dumb"

end
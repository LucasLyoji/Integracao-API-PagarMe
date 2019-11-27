using System;
using System.IO;

namespace CSharptest2
{
    public class Chamada
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precione 1 para realizar uma transação com split");
            Console.WriteLine("Precione 2 para realizar uma assinatura");
            Console.WriteLine("Precione 3 para realizar uma transferência");
            Console.WriteLine("Precione 4 para realizar uma antecipação");
            Console.WriteLine("Precione 5 para realizar um estorno com split");
            Console.WriteLine("Precione 6 para verificar o status de um postback");
            string esco = Console.ReadLine();

            if (esco == "1")
            {
                Split insaneSplit = new Split();
                Console.WriteLine("A transação numero " + insaneSplit.TSplit() + " foi criada!");
            }
            else if (esco == "2")
            {
                Recorrencia insaneRec = new Recorrencia();
                Console.WriteLine("A assinatura numero " + insaneRec.TRecorrencia() + " foi criada!");
            }
            else if (esco == "3")
            {
                Transferencia insaneTran = new Transferencia();
                Console.WriteLine("A transferencia numero " + insaneTran.TTransferencia()[0]  + " de " + insaneTran.TTransferencia()[1] + " centavos foi realizada para a conta bancaria com o ID " + insaneTran.TTransferencia()[2] + "!");
            }
            else if (esco == "4")
            {
                Antecipaçao insaneAnte = new Antecipaçao();
                Console.WriteLine("A antecipação numero " + insaneAnte.TAntecipaçao()[0] + " de " + insaneAnte.TAntecipaçao()[1] + " centavos foi criada para o recebedor com o ID " + insaneAnte.TAntecipaçao()[2] + "!");
            }
            else if (esco == "5")
            {
                Split insaneSplit = new Split();
                EstornoComSplit insaneEstorno = new EstornoComSplit();
                String insaneTid = insaneSplit.TSplit();
                Console.WriteLine("A transação numero " + insaneTid + " foi criada e estornada!" + insaneEstorno.TEstornoComSplit(insaneTid));
            }
            else if (esco == "6")
            {
                PostBack insanePost = new PostBack();
                Console.WriteLine("O postback da transação " + insanePost.TPostBack()[0] + " está com status " + insanePost.TPostBack()[1]);
            }
            else
            {
                Console.WriteLine("hi dumb dumb");
            }
        }
    }
}

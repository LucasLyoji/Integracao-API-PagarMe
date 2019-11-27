using System;
using PagarMe;

namespace CSharptest2
{
    public class Transferencia
    {
        public String[] TTransferencia()
        {
            PagarMe.PagarMeService.DefaultApiKey = "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg";

            var transfer = new Transfer
            {
                Amount = 1000,
                RecipientId = "re_ck0zjmw1s007ier6eysyd3agj"
            };
            transfer.Save();
            string[] retorno = new string[3];
            retorno[0] = transfer.Id;
            retorno[1] = transfer.Amount.ToString();
            retorno[2] = transfer.Bank.Id;
            return retorno;
        }
    }
}

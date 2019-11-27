using System;
using PagarMe;
using PagarMe.Model;

namespace CSharptest2
{
    public class Antecipaçao
    {
        public String[] TAntecipaçao()
        {
            PagarMeService.DefaultApiKey = "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg";
            var recipient = PagarMeService.GetDefaultService().Recipients.Find("re_ck0zjmw1s007ier6eysyd3agj");
            var bulkAnticipation = new BulkAnticipation()
            {
                Timeframe = TimeFrame.Start,
                PaymentDate = DateTime.Today.AddDays(3),
                RequestedAmount = 5300,
                Build = true
            };
            try
            {
                recipient.CreateAnticipation(bulkAnticipation);
                string[] retorno = new string[3];
                retorno[0] = bulkAnticipation.Id;
                retorno[1] = bulkAnticipation.Amount.ToString();
                retorno[2] = recipient.Id;
                return retorno;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                string[] retorno = new string[2];
                retorno[0] = Convert.ToString(ex);
                retorno[1] = "";
                retorno[2] = "";
                return retorno;
            }
        }
    }
}

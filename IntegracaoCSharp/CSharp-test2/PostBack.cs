using System;
using PagarMe;

namespace CSharptest2
{
    public class PostBack
    {
        public String[] TPostBack()
        {
            PagarMeService.DefaultApiKey = "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg";
            var postback = PagarMeService.GetDefaultService().Transactions.Find("7341631").Postbacks.Find("po_ck368bv1v00b0vs733f9uuuc3");
            string[] retorno = new string[2];
            retorno[0] = postback.ModelId; 
            retorno[1] = Convert.ToString(postback.Status);
            return retorno;
        }
    }
}

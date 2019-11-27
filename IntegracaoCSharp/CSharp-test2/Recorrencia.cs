using System;
using PagarMe;

namespace CSharptest2
{
    public class Recorrencia
    {
        public String TRecorrencia()
        {
            PagarMeService.DefaultApiKey = "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg";

            Subscription subscription = new Subscription
            {
                PaymentMethod = PaymentMethod.CreditCard,
                CardNumber = "4901720080344448",
                CardHolderName = "Jose da Silva",
                CardExpirationDate = "1225",
                CardCvv = "123"
            };

            subscription.Plan = PagarMeService.GetDefaultService().Plans.Find(435922);
            Customer customer = new Customer
            {
                Email = "api@test.com",
                Name = "Rick",
                Documents = new[]
            {
                new Document{
                Type = DocumentType.Cpf,
                Number = "30621143049"
                }
            },
            };

            subscription.Customer = customer;

            subscription.Save();
            return Convert.ToString(subscription.Id);
        }
    }
}

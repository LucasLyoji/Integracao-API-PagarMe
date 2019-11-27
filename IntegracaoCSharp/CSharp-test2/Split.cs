using System;
using PagarMe;

namespace CSharptest2
{
    public class Split
    {
        public String TSplit()
        {
            PagarMeService.DefaultApiKey = "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg";
            PagarMeService.DefaultEncryptionKey = "ek_test_SF2MPmKaWRLywNuetObE0vkv0nnkel";

            Transaction transaction = new Transaction();

            transaction.Amount = 2000;
            var Card = new Card
            {
                Number = "4018720572598048",
                HolderName = "Aardvark Silva",
                ExpirationDate = "1125",
                Cvv = "123"
            };
            Card.Save();
            transaction.Card = Card;
            transaction.SplitRules = new SplitRule[]{
                new SplitRule
                {
                    Percentage = 80,
                    RecipientId = "re_ck0zkjmuj00gln86dajtwrfws",
                    ChargeProcessingFee = true,
                    Liable = true
                },
                new SplitRule
                {
                    Percentage = 20,
                    RecipientId = "re_ck0zjmw1s007ier6eysyd3agj",
                    ChargeProcessingFee = false,
                    Liable = false
                }
            };
            transaction.Customer = new Customer
            {
                ExternalId = "#3311",
                Name = "Rick",
                Type = CustomerType.Individual,
                Country = "br",
                Email = "rick@morty.com",
                Documents = new[]
            {
                new Document{
                Type = DocumentType.Cpf,
                Number = "30621143049"
                },
                new Document{
                Type = DocumentType.Cnpj,
                Number = "83134932000154"
                }
            },
                PhoneNumbers = new string[]
                {
                "+5511982738291",
                "+5511829378291"
                },
                Birthday = new DateTime(1991, 12, 12).ToString("yyyy-MM-dd")
            };

            transaction.Billing = new Billing
            {
                Name = "Morty",
                Address = new Address()
                {
                    Country = "br",
                    State = "sp",
                    City = "Cotia",
                    Neighborhood = "Rio Cotia",
                    Street = "Rua Matrix",
                    StreetNumber = "213",
                    Zipcode = "04250000"
                }
            };

            var Today = DateTime.Now;

            transaction.Shipping = new Shipping
            {
                Name = "Rick",
                Fee = 100,
                DeliveryDate = Today.AddDays(4).ToString("yyyy-MM-dd"),
                Expedited = false,
                Address = new Address()
                {
                    Country = "br",
                    State = "sp",
                    City = "Cotia",
                    Neighborhood = "Rio Cotia",
                    Street = "Rua Matrix",
                    StreetNumber = "213",
                    Zipcode = "04250000"
                }
            };

            transaction.Item = new[]
            {
            new Item()
                {
                    Id = "1",
                    Title = "Little Car",
                    Quantity = 1,
                    Tangible = true,
                    UnitPrice = 1000
                },
            new Item()
                {
                    Id = "2",
                    Title = "Baby Crib",
                    Quantity = 1,
                    Tangible = true,
                    UnitPrice = 1000
                }
            };

            transaction.Save();
            return Convert.ToString(transaction.Id);
        }
    }
}


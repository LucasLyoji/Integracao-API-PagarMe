using System;
using PagarMe;
using PagarMe.Model;

namespace CSharptest2
{
    public class EstornoComSplit
    {
        public String TEstornoComSplit(String Tid)
        {
            PagarMeService.DefaultApiKey = "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg";

            var transaction = PagarMeService.GetDefaultService().Transactions.Find(Tid);
            var splitRules = new SplitRule[]{
                new SplitRule
                {
                    Id = transaction.SplitRules[0].Id,
                    Percentage = transaction.SplitRules[0].Percentage,
                    RecipientId = transaction.SplitRules[0].RecipientId,
                    ChargeProcessingFee = transaction.SplitRules[0].ChargeProcessingFee
                },
                new SplitRule
                {
                    Id = transaction.SplitRules[1].Id,
                    Percentage = transaction.SplitRules[1].Percentage,
                    RecipientId = transaction.SplitRules[1].RecipientId,
                    ChargeProcessingFee = transaction.SplitRules[1].ChargeProcessingFee
                }
            };
            try
            {
                transaction.RefundWithSplit(transaction.Amount, splitRules);
                return " ";
            }
            catch (PagarMeException ex)
            {
                Console.WriteLine(ex.Error.Errors[0].Message);
                return Convert.ToString(ex);
            }
        }
    }
}

require 'pagarme'

def Recorrencia()
    
    PagarMe.api_key = "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg"

    plan = PagarMe::Plan.find_by_id("435922")

    subscription = PagarMe::Subscription.new({
        :payment_method => "credit_card",
        :card_number => "4111111111111111",
        :card_holder_name => "Jose da Silva",
        :card_expiration_month => "10",
        :card_expiration_year => "20",
        :card_cvv => "314",
        :postback_url => "http://test.com/postback",
        :customer => {
            email: "api@test.com"
        }
    })
    subscription.plan = plan

    subscription.create
end

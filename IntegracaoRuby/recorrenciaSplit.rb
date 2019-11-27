require 'pagarme'

def RecorrenciaSplit()
    
  PagarMe.api_key = "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg"

  plan = PagarMe::Plan.find_by_id("435922")

  subscription = PagarMe::Subscription.new({
      :payment_method => 'credit_card',
      :card_number => "4901720080344448",
      :card_holder_name => "Jose da Silva",
      :card_expiration_month => "10",
      :card_expiration_year => "25",
      :card_cvv => "314",
      :postback_url => "http://test.com/postback",
      :customer => {
          email: 'api@test.com',
          name: 'John Appleseed',
          document_number: '92545278157'
      },
      :split_rules => [
          {
            recipient_id: "re_ck0zkjmuj00gln86dajtwrfws",
            percentage: 10,
            liable: true,
            charge_processing_fee: true
          } ,
          {
            recipient_id: "re_ck0zjmw1s007ier6eysyd3agj",
            percentage: 90,
            liable: false,
            charge_processing_fee: false
          } 
      ]
  })
  subscription.plan = plan

  subscription.create
end
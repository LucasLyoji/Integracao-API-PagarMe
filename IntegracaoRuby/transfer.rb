require 'pagarme'

def Transfer()

    PagarMe.api_key = 'ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg'

    transferencia = PagarMe::Transfer.create({
        :amount => 14000,
        :recipient_id => "re_ck0zjmw1s007ier6eysyd3agj"
    })
end
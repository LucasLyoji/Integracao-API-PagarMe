require 'pagarme'

def Antecipacao()
	PagarMe.api_key = 'ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg'
	recipientId = "re_ck0zjmw1s007ier6eysyd3agj"
	recipient = PagarMe::Recipient.find_by_id(recipientId)
	bulk_anticipation = recipient.bulk_anticipate(
		:requested_amount => 10000,
		:payment_date => Date.today + 7,
		:timeframe => :start
	)
	return [bulk_anticipation, recipientId]
end
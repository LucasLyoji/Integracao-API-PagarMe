const pagarme = require('pagarme')
  
pagarme.client.connect({ api_key: 'ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg' })
  .then(client => client.subscriptions.create({
    plan_id: 435922,
    card_number: '4111111111111111',
    card_holder_name: 'TESTE jo',
    card_expiration_date: '1225',
    card_cvv: '123',
    customer: {
      email: 'test@somewhere.com',
      document_number: '30621143049'
    }
	}))
  .then(subscription => console.log(subscription.id))

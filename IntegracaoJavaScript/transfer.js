const pagarme = require('pagarme')

pagarme.client.connect({ api_key: 'ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg' })
  .then(client => client.transfers.create({
    amount: 10000,
    recipient_id: 're_ck0zjmw1s007ier6eysyd3agj',
  }))
  .then(transfer => console.log(transfer))
  .catch(response => console.log(JSON.stringify(response)))
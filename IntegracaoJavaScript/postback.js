const pagarme = require('pagarme')

pagarme.client.connect({ api_key: 'ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg' })
  .then(client => client.postbacks.find({ transactionId: 7341631, id: 'po_ck368bv1v00b0vs733f9uuuc3' }))
  .then(refund => console.log(refund))
  .catch(response => console.log(JSON.stringify(response)))

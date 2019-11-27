const pagarme = require('pagarme')
var milliseconds = (new Date).getTime();
pagarme.client.connect({ api_key: 'ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg' })
  .then(client =>  client.bulkAnticipations.create({
  	recipientId: 're_ck0zjmw1s007ier6eysyd3agj',
    payment_date: milliseconds+604800000,
    timeframe: 'start',
    requested_amount: '9000',
  }))
  .then(bulkAnticipation => console.log(bulkAnticipation))
  .catch(response => console.log(JSON.stringify(response)))
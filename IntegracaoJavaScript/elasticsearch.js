const pagarme = require('pagarme')

pagarme.client.connect({ api_key: 'ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg' })
  .then(client => client.search({
    type: 'transaction',
    query: {
      "query": {
        "terms": {
          "items.id": [
            "r123"
          ]
        }
      }
    }
  }))
  .then(result => console.log(result))
  .catch(response => console.log(JSON.stringify(response)))
  
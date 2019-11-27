const pagarme = require('pagarme')

pagarme.client.connect({ api_key: 'ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg' })
.then(client => client.transactions.create({
    "amount": 1000,
    "card_id": "card_ck394f18e01flvh6d3sdtoohj",
    "postback_url": "http://requestb.in/pkt7pgpk",
    "split_rules":[
    	{
    	"liable": "true",
    	"charge_processing_fee": "true",
    	"percentage": "90",
    	"charge_remainder_fee": "true",
    	"recipient_id":"re_ck0zkjmuj00gln86dajtwrfws"
    	},
    	{
    	"liable": "false",
    	"charge_processing_fee": "false",
    	"percentage": "10",
    	"charge_remainder_fee": "false",
    	"recipient_id":"re_ck0zjmw1s007ier6eysyd3agj"
    	}
    	],
    "customer": {
      "external_id": "#3311",
      "name": "Morpheus Fishburne",
      "type": "individual",
      "country": "br",
      "email": "mopheus@nabucodonozor.com",
      "documents": [
        {
          "type": "cpf",
          "number": "30621143049"
        }
      ],
      "phone_numbers": ["+5511999998888", "+5511888889999"],
      "birthday": "1965-01-01"
    },
    "billing": {
      "name": "Trinity Moss",
      "address": {
        "country": "br",
        "state": "sp",
        "city": "Cotia",
        "neighborhood": "Rio Cotia",
        "street": "Rua Matrix",
        "street_number": "9999",
        "zipcode": "06714360"
      }
    },
    "shipping": {
      "name": "Neo Reeves",
      "fee": 1000,
      "delivery_date": "2000-12-21",
      "expedited": true,
      "address": {
        "country": "br",
        "state": "sp",
        "city": "Cotia",
        "neighborhood": "Rio Cotia",
        "street": "Rua Matrix",
        "street_number": "9999",
        "zipcode": "06714360"
      }
    },
    "items": [
      {
        "id": "r123",
        "title": "Red pill",
        "unit_price": 10000,
        "quantity": 1,
        "tangible": true
      },
      {
        "id": "b123",
        "title": "Blue pill",
        "unit_price": 10000,
        "quantity": 1,
        "tangible": true
      }
    ]
}))
.then(transaction => { console.log(transaction.id)})
require 'pagarme'

def EstornoSplit()
    
  PagarMe.api_key = "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg";

  transaction  = PagarMe::Transaction.new({
    amount: 40000,
    payment_method: "credit_card",
    card_number: "4111111111111111",
    card_holder_name: "Mario Fishburne",
    card_expiration_date: "1123",
    card_cvv: "123",
    postback_url: "http://requestb.in/pkt7pgpk",
    async: "false",
    split_rules: [
      { recipient_id: "re_ck0zkjmuj00gln86dajtwrfws", 
      percentage: 50,
      liable: false,
      charge_processing_fee: false
    },
      { recipient_id: "re_ck0zjmw1s007ier6eysyd3agj", 
      percentage: 50,
      liable: true,
      charge_processing_fee: true
    }
    ],
    customer: {
      external_id: "#3311",
      name: "Morpheus Fishburne",
      type: "individual",
      country: "br",
      email: "mopheus@nabucodonozor.com",
      documents: [
        {
          type: "cpf",
          number: "30621143049"

        }

      ],
      phone_numbers: ["+5511999998888", "+5511888889999"],
      birthday: "1965-01-01"
    },
    billing: {
      name: "Trinity Moss",
      address: {
        country: "br",
        state: "sp",
        city: "Cotia",
        neighborhood: "Rio Cotia",
        street: "Rua Matrix",
        street_number: "9999",
        zipcode: "06714360"
      }
    },
    shipping: {
      name: "Neo Reeves",
      fee: 1000,
      delivery_date: "2000-12-21",
      expedited: true,
      address: {
        country: "br",
        state: "sp",
        city: "Cotia",
        neighborhood: "Rio Cotia",
        street: "Rua Matrix",
        street_number: "9999",
        zipcode: "06714360"
      }
    },
    items: [
      {
        id: "r123",
        title: "Red pill",
        unit_price: 10000,
        quantity: 1,
        tangible: true
      },
      {
        id: "b123",
        title: "Blue pill",
        unit_price: 10000,
        quantity: 1,
        tangible: true
      }

    ]
  })

  transaction.charge
  sleep(5)

  split_refund = transaction.refund({
    async: false,
    amount: 40000,
    split_rules:[
      {
        "id": "sr_ck1icn4gw02j7oz6d3fdmibfw",
        "percentage": "50",
        "recipient_id": "re_ck0zkjmuj00gln86dajtwrfws",
        "liable": "false",
        "charge_processing_fee": "false"
      },
      {
        "id": "sr_ck1icn4gw02j8oz6d3lnd7l1g",
        "percentage": "50",
        "recipient_id": "re_ck0zjmw1s007ier6eysyd3agj",
        "liable": "true",
        "charge_processing_fee": "true"
      }
    ]
  })
end
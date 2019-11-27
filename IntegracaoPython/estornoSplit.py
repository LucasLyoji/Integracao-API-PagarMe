import pagarme
import time
import json


def EstornoSplit():
    
  pagarme.authentication_key("ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg")


  params = {
    "amount": "21000",
      "card_number": "4111111111111111",
      "card_cvv": "123",
      "card_expiration_date": "0922",
      "card_holder_name": "teste de codigo",
      "postback_url": "http://requestb.in/pkt7pgpk",
      "async": "false",
      "split_rules": [
          { 
          "recipient_id": "re_ck0zkjmuj00gln86dajtwrfws", 
          "percentage": "50",
          "liable": "false",
          "charge_processing_fee": "false"
          },
          { 
          "recipient_id": "re_ck0zjmw1s007ier6eysyd3agj", 
          "percentage": "50",
          "liable": "true",
          "charge_processing_fee": "true"
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
        "fee": "1000",
        "delivery_date": "2000-12-21",
        "expedited": True,
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
          "unit_price": "10000",
          "quantity": "1",
          "tangible": True
        },
        {
          "id": "b123",
          "title": "Blue pill",
          "unit_price": "10000",
          "quantity": "1",
          "tangible": True
        }
      ]
  }

  trx = pagarme.transaction.create(params)

  id_trx = str(trx['id'])
  time.sleep(5)

  transaction = pagarme.transaction.find_by({'id': id_trx})

  estr = pagarme.transaction.refund(transaction[0]['id'], {"amount": "21000"})
  
  estr_in_string = json.dumps(estr)
  parsed_json = (json.loads(estr_in_string))
  
  return parsed_json["id"]


import pagarme
import json

def Recorrencia():

    pagarme.authentication_key('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg')

    subscription = pagarme.subscription.create({
        "card_number": "4111111111111111",
        "card_cvv": "123",
        "card_expiration_date": "0922",
        "card_holder_name": "Marv Fishburne",
        "customer":{
            "email":"jorah.mormont@gameofthrones.com",
            "name":"Sir Jorah Mormont",
            "document_number":"18152564000105",
            "address":{
                "zipcode":"04571020",
                "neighborhood":"Cidade Moncoes",
                "street":"R. Dr. Geraldo Campos Moreira",
                "street_number":"240"
            },
            "phone": {
                "number":"987654321",
                "ddd":"11"
            }
        },
        "payment_method": "credit_card",
        "plan_id": "435922",
        "postback_url": "http://requestb.in/zyn5obzy"
    })
    
    sub_in_string = json.dumps(subscription)
    parsed_json = (json.loads(sub_in_string))

    return parsed_json["id"]
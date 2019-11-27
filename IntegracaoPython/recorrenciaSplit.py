import pagarme
import json

def RecorrenciaSplit():

    pagarme.authentication_key('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg')

    subscription = pagarme.subscription.create({
        "card_number": "4111111111111111",
        "card_cvv": "123",
        "card_expiration_date": "0922",
        "card_holder_name": "Marv Fishburne",
        "customer":{
            "email":"aardvark.silva@gmail.com",
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
        "split_rules":[
            {
                "recipient_id": "re_ck0zkjmuj00gln86dajtwrfws",
                "percentage": "25"
            },
            {
                "recipient_id": "re_ck0zjmw1s007ier6eysyd3agj",
                "percentage": "75"
            }
        ],
        "payment_method": "credit_card",
        "plan_id": "435922",
        "postback_url": "http://requestb.in/zyn5obzy"
    })
    
    sub_in_string = json.dumps(subscription)
    parsed_json = (json.loads(sub_in_string))

    return parsed_json["id"]


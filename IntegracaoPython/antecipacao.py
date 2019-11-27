import pagarme
import json
import time

def Antecipacao():

    pagarme.authentication_key('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg')

    params = {
        'payment_date': time.time()*1000 + 86400000,
        'timeframe': 'start',
        'requested_amount': '5000'
    }
    recipientId = 're_ck0zjmw1s007ier6eysyd3agj'
    bulk_anticipation = pagarme.bulk_anticipation.create(recipientId, params)

    ante_in_string = json.dumps(bulk_anticipation)
    parsed_json = (json.loads(ante_in_string))

    return parsed_json["id"], parsed_json["amount"], recipientId

import pagarme
import json

def Transfer():

    pagarme.authentication_key('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg')

    transfer_params = {
        'amount': '1000',
        'recipient_id': 're_ck0zjmw1s007ier6eysyd3agj'
    }

    transfer = pagarme.transfer.create(transfer_params)
    transf_in_string = json.dumps(transfer)
    parsed_json = (json.loads(transf_in_string))

    return parsed_json["id"], parsed_json["amount"], parsed_json["source_id"]

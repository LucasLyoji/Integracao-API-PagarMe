import pagarme
import json

def Postback():
        
    pagarme.authentication_key('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg')

    postback = pagarme.transaction.specific_postback("7341631", "po_ck368bv1v00b0vs733f9uuuc3")

    post_in_string = json.dumps(postback)
    parsed_json = (json.loads(post_in_string))
    
    return parsed_json["model_id"], parsed_json["status"]
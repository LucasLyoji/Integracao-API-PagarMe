/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.integracaojava;

import java.util.logging.Level;
import java.util.logging.Logger;
import org.joda.time.DateTime;
import me.pagar.model.BulkAnticipation;
import me.pagar.model.BulkAnticipation.Timeframe;
import me.pagar.model.PagarMe;
import me.pagar.model.PagarMeException;
import me.pagar.model.Recipient;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
/**
 *
 * @author lucas
 */
public class Antecipacao {
    
    public String[] retornoId(){
        
        String[] aid = new String[3];
        
        PagarMe.init("ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg");
                
        try {

            String recipientId = "re_ck0zjmw1s007ier6eysyd3agj";
            Recipient recipient = new Recipient().find(recipientId);
            DateTime paymentDate = new DateTime().plusDays(7);
            int requestedAmount = 13000;
            boolean build = true;
            BulkAnticipation anticipation = new BulkAnticipation();
            anticipation.setRequiredParametersForCreation(paymentDate, Timeframe.END, requestedAmount, build);
            anticipation = recipient.anticipate(anticipation);
            
            try
            {
                String jsonobj = anticipation.toJson();
                JSONObject jo = (JSONObject) new JSONParser().parse(jsonobj);
                String aid0 = (String) jo.get("id").toString();
                String aid1 = (String) jo.get("amount").toString();
                aid[0] = aid0;
                aid[1] = aid1;
                aid[2] = recipientId;
                return aid;
            }
            catch (Exception e)
            {
                aid[0] = "  ";
                aid[1] = "  ";
                aid[2] = "  ";
                return aid;
            }

        } 
        catch (PagarMeException ex) 
        {
                Logger.getLogger(Split.class.getName()).log(Level.SEVERE, null, ex);
                aid[0] = "  ";
                aid[1] = "  ";
                aid[2] = "  ";
                return aid;
        }
    }
}

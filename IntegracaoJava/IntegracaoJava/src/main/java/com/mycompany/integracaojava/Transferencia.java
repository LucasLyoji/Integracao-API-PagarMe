/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.integracaojava;

import java.util.logging.Level;
import java.util.logging.Logger;
import me.pagar.model.PagarMe;
import me.pagar.model.PagarMeException;
import me.pagar.model.Transfer;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

/**
 *
 * @author lucas
 */
public class Transferencia {
    
    public String[] retornoId() {
        
        String[] tid = new String[3];
        
        PagarMe.init("ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg");

        try {

            Transfer transfer = new Transfer();
            transfer.setAmount(100);
            transfer.setRecipientId("re_ck0zjmw1s007ier6eysyd3agj");
            transfer.save();
            try
            {
                String jsonobj = transfer.toJson();
                JSONObject jo = (JSONObject) new JSONParser().parse(jsonobj);
                String tid0 = (String) jo.get("id").toString();
                String tid1 = (String) jo.get("amount").toString();
                String tid2 = (String) jo.get("recipientId").toString();
                tid[0] = tid0;
                tid[1] = tid1;
                tid[2] = tid2;
                return tid;
            }
            catch (Exception e)
            {
                tid[0] = "  ";
                tid[1] = "  ";
                tid[2] = "  ";
                return tid;
            }

        } 
        catch (PagarMeException ex) 
        {
                Logger.getLogger(Split.class.getName()).log(Level.SEVERE, null, ex);
                tid[0] = "  ";
                tid[1] = "  ";
                tid[2] = "  ";
                return tid;
        }
    }
}

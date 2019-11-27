/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.integracaojava;

import java.util.logging.Level;
import java.util.logging.Logger;
import me.pagar.model.Address;
import me.pagar.model.Card;
import me.pagar.model.Customer;
import me.pagar.model.PagarMe;
import me.pagar.model.PagarMeException;
import me.pagar.model.Phone;
import me.pagar.model.Subscription;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

/**
 *
 * @author lucas
 */
public class Recorrencia {

    public String retornoId() {
        
        PagarMe.init("ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg");

        try {

            Phone phone = new Phone();
            phone.setDdd("11");
            phone.setDdi("55");
            phone.setNumber("99999999");

            String street = "Avenida Brigadeiro Faria Lima";
            String streetNumber = "1811";
            String neighborhood = "Jardim Paulistano";
            String zipcode = "01451001";
            Address address = new Address(street, streetNumber, neighborhood, zipcode);

            String name = "Aardvark Silva";
            String email = "aardvark.silva@pagar.me";
            String documentNumber = "18152564000105";
            Customer customer = new Customer(name, email);
            customer.setAddress(address);
            customer.setPhone(phone);
            customer.setDocumentNumber(documentNumber);

            Card card = new Card();
            card.setNumber("4901720080344448");
            card.setHolderName("Jose da Silva");
            card.setExpiresAt("1224");
            card.setCvv(122);
            card.save();

            Subscription subscription = new Subscription();
            subscription.setCreditCardSubscriptionWithCardId("440495", card.getId(), customer);
            subscription.save();
            try
            {
                String jsonobj = subscription.toJson();
                JSONObject jo = (JSONObject) new JSONParser().parse(jsonobj);
                String sid = (String) jo.get("id").toString();
                return sid;
            }
            catch (Exception e)
            {
                return " ";
            }

        } 
        catch (PagarMeException ex) 
        {
                Logger.getLogger(Split.class.getName()).log(Level.SEVERE, null, ex);
                return " ";
        }
    }
}

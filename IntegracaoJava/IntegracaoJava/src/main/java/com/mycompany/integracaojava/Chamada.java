/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.integracaojava;

import java.util.Scanner;
/**
 *
 * @author lucas
 */
public class Chamada {
    
    public static void main(String[] args) {
        
        System.out.println("Precione 1 para realizar uma transação com split");
        System.out.println("Precione 2 para realizar uma assinatura");
        System.out.println("Precione 3 para realizar uma transferência");
        System.out.println("Precione 4 para realizar uma antecipação");
        Scanner ler = new Scanner(System.in); 
        String esco = ler.nextLine();
        
        if (esco.contentEquals("1"))
        {
            System.out.println("A transação numero " + new Split().retornoId() + " foi criada!");
        }
        else if (esco.contentEquals("2"))
        {
            System.out.println("A assinatura numero " + new Recorrencia().retornoId() + " foi criada!");
        }
        else if (esco.contentEquals("3"))
        {
            String[] retorno = new Transferencia().retornoId();
            System.out.println("A transferencia: " + retorno[0]  + ", de " + retorno[1] + " centavos foi realizada para a conta bancária do recebedor " + retorno[2] + "!");
        }
        else if (esco.contentEquals("4"))
        {
            String[] retorno = new Antecipacao().retornoId();
            System.out.println("A antecipação: " + retorno[0] + ", de " + retorno[1] + " centavos foi criada para o recebedor " + retorno[2] + "!");
        }
        else
        {
            System.out.println("hi dumb dumb");
        }
    }
}

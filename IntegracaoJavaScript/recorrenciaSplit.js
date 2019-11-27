const pagarme = require("pagarme");

pagarme.client.connect({ api_key: "ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg" })
.then( client => {

    client.subscriptions.create({
      plan_id: "435922",
      card_number: '4111111111111111',
      card_holder_name: 'TESTE jo',
      card_expiration_date: '1123',
      card_cvv: '123',
      customer: {
        document_number: '45473486851',
        name: 'Teste Johnny',
        email: 'test@email.com',
        born_at: '17071996',
        gender: 'M',
        address: {
          street: 'Rua Fidêncio Ramos',
          complementary: 'apto',
          street_number: '308',
          neighborhood: 'pinheiros',
          city: 'São Paulo',
          state: 'SP',
          zipcode: '04551010',
          country: 'Brasil'
        },
        phone: {
          ddd: '11',
          number: '999887766'
        }
      },
      split_rules: [
        {
          recipient_id: "re_ck0zkjmuj00gln86dajtwrfws",
          charge_processing_fee: true,
          liable: true,
          percentage: 50,
          charge_remainder_fee: true
        },
        {
          recipient_id: "re_ck0zjmw1s007ier6eysyd3agj",
          charge_processing_fee: false,
          liable: false,
          percentage: 50,
          charge_remainder_fee: false
        }
      ]
    })
    .then( subscription => console.log(subscription), failure => console.log(JSON.stringify(failure) ));

});
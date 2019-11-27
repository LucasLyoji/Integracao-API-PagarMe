<?php
require("vendor/autoload.php");
$pagarme = new PagarMe\Client('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg');

$transaction = $pagarme->transactions()->create([
    'amount' => 10000,
    'payment_method' => 'credit_card',
    'card_holder_name' => 'teste de codigo',
    'card_cvv' => '123',
    'card_number' => '4242424242424242',
    'card_expiration_date' => '1220',
    'postback_url' => 'http://postback.url',
    'split_rules' => [
      [
      'liable' => 'true',
      'charge_processing_fee' => 'true',
      'percentage' => '50',
      'charge_remainder_fee' => 'true',
      'recipient_id' => 're_ck0zkjmuj00gln86dajtwrfws'
      ],
      [
      'liable' => 'false',
      'charge_processing_fee' => 'false',
      'percentage' => '50',
      'charge_remainder_fee' => 'false',
      'recipient_id' => 're_ck0zjmw1s007ier6eysyd3agj'
      ]
      ],
    'customer' => [
        'external_id' => '1',
        'name' => 'Nome do cliente',
        'type' => 'individual',
        'country' => 'br',
        'documents' => [
          [
            'type' => 'cpf',
            'number' => '67415765095'
          ]
        ],
        'phone_numbers' => [ '+551199999999' ],
        'email' => 'cliente@email.com'
    ],
    'billing' => [
        'name' => 'Nome do pagador',
        'address' => [
          'country' => 'br',
          'street' => 'Avenida Brigadeiro Faria Lima',
          'street_number' => '1811',
          'state' => 'sp',
          'city' => 'Sao Paulo',
          'neighborhood' => 'Jardim Paulistano',
          'zipcode' => '01451001'
        ]
    ],
    'shipping' => [
        'name' => 'Nome de quem receberá o produto',
        'fee' => 1020,
        'delivery_date' => '2018-09-22',
        'expedited' => false,
        'address' => [
          'country' => 'br',
          'street' => 'Avenida Brigadeiro Faria Lima',
          'street_number' => '1811',
          'state' => 'sp',
          'city' => 'Sao Paulo',
          'neighborhood' => 'Jardim Paulistano',
          'zipcode' => '01451001'
        ]
    ],
    'items' => [
        [
          'id' => '1',
          'title' => 'R2D2',
          'unit_price' => 300,
          'quantity' => 1,
          'tangible' => true
        ],
        [
          'id' => '2',
          'title' => 'C-3PO',
          'unit_price' => 700,
          'quantity' => 1,
          'tangible' => true
        ]
    ]
  ]);
 $id_trx = strval($transaction -> id);
 $id_split_rules1 = strval($transaction -> split_rules[0] -> id);
 $id_split_rules2 = strval($transaction -> split_rules[1] -> id);
 sleep(5);

$refundedTransactionWithSplit = $pagarme->transactions()->refund([
    'id' => $id_trx,
    'amount' => 10000,
    'split_rules' => [
        [
            'id' => $id_split_rules2,
            'percentage' => '50',
            'recipient_id' => 're_ck0zkjmuj00gln86dajtwrfws',
            'charge_processing_fee' => 'true',
            'liable' => 'true',
            'charge_remainder_fee' => 'true'
        ],
        [
            'id' => $id_split_rules1,
            'percentage' => '50',
            'recipient_id' => 're_ck0zjmw1s007ier6eysyd3agj',
            'charge_processing_fee' => 'false',
            'liable' => 'false',
            'charge_remainder_fee' => 'false'
        ]
    ]
]);
echo("A transação número ".$refundedTransactionWithSplit->id." foi criada e estornada!");


<?php
require("vendor/autoload.php");
$pagarme = new PagarMe\Client('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg');

$substription = $pagarme->subscriptions()->create([
    'plan_id' => 435922,
    'payment_method' => 'credit_card',
    'card_number' => '4111111111111111',
    'card_holder_name' => 'UNIX TIME',
    'card_expiration_date' => '0722',
    'card_cvv' => '123',
    'postback_url' => 'http://postbacj.url',
    'customer' => [
        'email' => 'time@unix.com',
        'name' => 'Unix Time',
        'document_number' => '75948706036',
        'address' => [
            'street' => 'Rua de Teste',
            'street_number' => '100',
            'complementary' => 'Apto 666',
            'neighborhood' => 'Bairro de Teste',
            'zipcode' => '01451001'
        ],
        'phone' => [
            'ddd' => '01',
            'number' => '923456780'
        ],
        'sex' => 'other',
        'born_at' => '1970-01-01',
    ],
    'metadata' => [
        'foo' => 'bar'
    ]
]);
echo("A assinatura número ".$substription->id." foi criada!");
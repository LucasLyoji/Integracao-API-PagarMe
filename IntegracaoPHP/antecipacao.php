<?php
require("vendor/autoload.php");
$pagarme = new PagarMe\Client('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg');

$recipientId = "re_ck0zjmw1s007ier6eysyd3agj";
$anticipation = $pagarme->bulkAnticipations()->create([
    'recipient_id' => $recipientId,
    'build' => 'true',
    'payment_date' => time()*1000+604800000,
    'requested_amount' => '1000',
    'timeframe' => 'start'
]);
echo("A antecipação: ".$anticipation->id.", de ".$anticipation->amount." centavos foi criada para o recebedor ".$recipientId."!");
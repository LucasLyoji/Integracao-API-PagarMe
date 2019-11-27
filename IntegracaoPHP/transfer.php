<?php
require("vendor/autoload.php");
$pagarme = new PagarMe\Client('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg');

$transfer = $pagarme->transfers()->create([
    'amount' => 1000,
    'recipient_id' => 're_ck0zjmw1s007ier6eysyd3agj'
]);
echo("A transferência: ".$transfer->id.", de ".$transfer->amount." centavos foi realizada para a conta bancária do recebedor ".$transfer->source_id."!");

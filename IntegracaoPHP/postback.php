<?php
require("vendor/autoload.php");
$pagarme = new PagarMe\Client('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg');

$postback = $pagarme->postbacks()->get([
    'model' => 'transaction',
    'model_id' => '7341631',
    'postback_id' => 'po_ck368bv1v00b0vs733f9uuuc3'
]);
echo("O postback da transação ".$postback->model_id." está com status ".$postback->status."!");
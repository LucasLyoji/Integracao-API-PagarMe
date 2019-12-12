<?php
    require(__DIR__."/vendor/autoload.php");

    $pagarme = new PagarMe\Client('ak_test_jbIXhrHXHOaUUNKtUVrkT9HGL60SSg');

    $capturedTransaction = $pagarme->transactions()->capture([
    'id' => $_POST['token'],
    'amount' => 8000
]);
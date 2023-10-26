<?php
$url = 'https://randomhistoricalfact.000webhostapp.com/fact';
$response = file_get_contents($url);

if ($response) {
    $data = json_decode($response, true);
    echo $data['fact'];
} else {
    echo 'Error fetching data';
}
?>

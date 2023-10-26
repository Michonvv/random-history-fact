<?php
// Sample array of historical facts.
include('facts.php');

// Choose a random fact.
$randomFact = $historicalFacts[array_rand($historicalFacts)];

$source = "https://parade.com/1099930/marynliles/history-facts/";

// Create a JSON response with pretty print.
$response = [
    "fact" => $randomFact,
    "Source" => $source
];

// Set response headers to indicate JSON content.
header("Content-Type: application/json");

// Output the JSON response with indentation.
echo json_encode($response, JSON_PRETTY_PRINT | JSON_UNESCAPED_SLASHES);
?>

<?php
$servername="localhost";
$username = "root";
$password = "student";
$dbname = "22135";

//create connection
$conn = new mysqli($servername, $username, $password, $dbname);

//check connection
if($conn->connect_error){
    die("connection failed : ".$conn->connect_error);
}

?>

<?php
$servername = "localhost";
$username="root"; 
$password="student"; 
$dbname="CMS";
// Create connection
$conn =new mysqli ($servername, $username, $password, $dbname);

// Check connection
if($conn->connect_error) {
die("Connection failed: ". $conn->connect_error); }
$stmt = $conn->prepare("INSERT INTO users (username, password) VALUES (?, ?)"); 
$stmt->bind_param("ss", $username, $password);
$username =$_GET['user']; 
$password =$_GET['pass']; 

$stmt->execute();

echo "New records created successfully"; 
$stmt->close(); 
$conn->close(); 
?>
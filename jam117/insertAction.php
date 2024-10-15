
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
$stmt = $conn->prepare("INSERT INTO student (firstname, lastname, age) VALUES (?, ?, ?)"); 
$stmt->bind_param("ssi", $firstname, $lastname, $age);
$firstname =$_GET['first']; 
$lastname =$_GET['last']; 
$age =$_GET['age'];
$stmt->execute();

echo "New records created successfully"; 
$stmt->close(); 
$conn->close(); 
?>
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
$id=$_GET['id'];

//sql to delete a record
$sql = "DELETE FROM student WHERE id=$id";

if ($conn->query($sql)==TRUE)
{
  echo"Record deleted succesfully";
  include("deleteform.php");
}
else
{
  echo"Error deleting record: ". $conn->error;
}
$conn->close();
?>
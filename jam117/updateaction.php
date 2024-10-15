<?php
require("open_db.php");
$id=$_GET['id'];
$firstname=$_GET['firstname'];
$lastname=$_GET['lastname'];
$age=$_GET['age'];

//sql to delete a record
$sql = "UPDATE student set firstname='$firstname', lastname='$lastname',age=$age WHERE id=$id ";

if ($conn->query($sql)==TRUE)
{
  echo"Record updated succesfully";
  include("updateform.php");
}
else
{
  echo"Error updating record: ". $conn->error;
}
require("close_db.php");
?>
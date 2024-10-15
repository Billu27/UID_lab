<?php
require("open_db.php");
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
require("close_db.php");
?>
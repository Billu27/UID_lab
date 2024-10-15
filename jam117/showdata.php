<?php
require("open_db.php");

$sql ="SELECT * FROM student";
$result= $conn->query($sql);
if ($result->num_rows>0)
{
  //output data of each row

  echo"<table border='1'>";
  echo"<tr><td>id</td><td>name</td><td>lastname</td></tr>";
  while($row = $result->fetch_assoc())
  {
    echo"<tr><td>".$row['id']."</td><td> ".$row['firstname']."</td><td>".$row['lastname']."</td></tr>";
  }
  echo "</table>";
}

else
{
  echo"0 results";
}
require ("close_db.php");
?>

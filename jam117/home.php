<?php
require("open_db.php");
$username=$_POST['user'];
$password=$_POST['pass'];

$sql="SELECT * FROM users WHERE username = '$username' AND password ='$password'";
$result = $conn->query($sql);
if($result->num_rows >0)
{
echo "valid user";
}
else
{
echo "invalid user";
}

require("close_db.php");
?>








?>
<?php 
//date to one hour ago
setcookie("user", "",time() - 3600, "/", "",0);
echo"the cookie is deleted";
?>
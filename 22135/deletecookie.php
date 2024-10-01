<?php
//date to 1 hour ago
setcookie("user","myname", time()+3600,"/");
echo "the cooki is deleted".$_COOKIE['user'];
?>
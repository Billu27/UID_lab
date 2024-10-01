<?php
setcookie("user","myname", time()+3600,"/");
echo "the cookie is created" .$_COOKIE["user"];
?>
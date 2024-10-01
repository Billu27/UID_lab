<?php
    require("open_db.php");
    $username=$_POST['user'];
    $password = $_POST['pass'];

    $sql = "INSERT INTO user (add tablecloms)
    VALUES('$username', '$password')";
    $result = $conn->query($sql);

   echo "user created";
    require("close_db.php");
?>
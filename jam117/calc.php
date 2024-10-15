<?php

$n1=$_GET['num1'];
$n2=$_GET['num2'];

if (isset($_GET['addition']))
  {
    $res=$n1+$n2;
    echo "result".$res;
  }


if (isset($_GET['multiplication']))
  {
    $res=$n1*$n2;
    echo "result".$res;
  }

if (isset($_GET['division']))
  {
    $res=$n1/$n2;
    echo "result".$res;
  }

  ?>
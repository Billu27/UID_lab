<?php
$t = date("H"); //0-24
if($t>22 && $t<4)
echo"good night";
if($t<12 && $t>4)
echo"good morning";
if($t>12 && $t<18)
echo"good afternoon";
if($t>18 && $t<22)
echo"good evening";

echo"the time is ".$t
?>
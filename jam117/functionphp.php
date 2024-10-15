
<?php
// function definition pass 1 argument 
function calc($daysLate) {
if ($daysLate<5)
  return $daysLate*100;
else
  return $daysLate*200;
}
// function definition pass 1+ arguments
function getbook($name, $publicationY, $author, $daysLate)
{

  echo "<br>the book is ".$name;
  echo "<br>the publication is ".$publicationY; 
  echo" <br>the author is ".$author;
  echo" <br> the fine is ".calc($daysLate); //call to function calc(arg)
  echo"<br>________________________________________________<br>";
}

  getbook ("Alice in the wonder land", 343, "Jack",5); 
  getbook("my book", 343, "Jill",7);
  getbook("your book", 333, "Jame",5);

?>
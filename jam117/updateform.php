<!DOCTYPE html>
<html>
  <head>
  <style>
    body{
      background-color: yellowgreen;
    }
    </style></head>
    <body>
      <?php ?>
      <h1> UPDATE</h1>
      <form method="get" action="updateaction.php">
        id <input type="text" name="id"><br>
        firstname <input type="text" name="firstname"><br>
        lastname <input type="text" name="lastname"><br>
        age <input type="text" name="age"><br>
        <input type="submit" name="update" value="update">
      </form>
    </body>
</html>
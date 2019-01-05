<form>
    Name: <input type="text" name="name">
    <input type="submit">
</form>



<?php

      if(isset($_GET['name'])){
         $name =htmlspecialchars($_GET ['name']);
         echo "Hello, ".$name."!";
      }

?>
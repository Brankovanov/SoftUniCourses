<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        X: <input type="text" name="num1" />
		Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
		<input type="submit" />
    </form>
	<?php
    if(isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])){
        $number1 = intval($_GET['num1']);
        $number2 = intval($_GET['num2']);
        $number3 = intval($_GET['num3']);
        $counter = 0;

     if($number1==0 || $number2==0 || $number3==0){
        echo "Positive";
     }else{
       if($number1<0) {
           $counter++;
       }

       if($number2<0) {
         $counter++;
       }

        if($number3<0) {
          $counter++;
        }

         if($counter%2==0) {
          echo "Positive";
         }else{
        echo "Negative";
         }
}

    }
    ?>
</body>
</html>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if(isset($_GET['num'])){

        $number = intval($_GET['num']);

        for($index =1; $index<=$number; $index++){
            echo"<button> $index</button>";
            
        }
    }

    ?>
</body>
</html>
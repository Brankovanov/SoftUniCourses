<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>

    <form>
        N: <input type="text" name="num1" />
        M: <input type="text" name="num2" />
        <input type="submit" />
    </form>

	<ul>
        <?php
        if(isset($_GET['num1']) && isset($_GET['num2'])) {
            $number1 = intval($_GET['num2']);
            $number2 = intval($_GET['num2']);

            for ($index = 1; $index <= $number1; $index++) {
                echo "<li>List. $index</li>";

                for($secondaryIndex=1;$secondaryIndex<=$number2;$secondaryIndex++){
                echo "<ul><li>Element. $index.$secondaryIndex</li></ul>";
                }
            }

        }
        ?>
	</ul>

</body>
</html>
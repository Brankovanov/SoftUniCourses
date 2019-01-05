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
        $counter =0;

        for($index =$number; $index>=2; $index--){
            for($divider =2; $divider<$index; $divider++){
                if($index%$divider==0){
                   $counter++;
                   break;
                }
            }

            if($counter==0){
                echo $index." ";
            }

            $counter=0;

        }
    }
    ?>
</body>
</html>
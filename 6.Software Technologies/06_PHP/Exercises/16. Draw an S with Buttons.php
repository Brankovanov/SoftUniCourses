<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php

for($lines=1;$lines<=9;$lines++){

    for($columns=1; $columns<=5; $columns++){
        if($lines==1 || $lines==5 || $lines==9){
            echo "<button style='background-color: blue'>1</button>";
        }
        else if($lines>1 && $lines<5 && $columns==1){
            echo "<button style='background-color: blue'>1</button>";
        }
        else if($lines>1 && $lines<5 && $columns!=1){
            echo "<button>0</button>";
        }
        else if($lines>5 && $lines<9 && $columns==5){
            echo "<button style='background-color: blue'>1</button>";
        }
        else if($lines>5 && $lines<9 && $columns!=5){
            echo "<button>0</button>";
        }
    }

    echo "<br>\n";
}
?>
</body>
</html>
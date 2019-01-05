<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style> 
</head>
<body>

<?php
$colorIndex=0;

for($lines=1;$lines<=5;$lines++){
    $color="rgb($colorIndex,$colorIndex,$colorIndex)";

    for($columns=1; $columns<=10; $columns++){
            echo "<div style='background-color:$color'></div>";
            $colorIndex+=5;
    }

    $colorIndex++;

    echo "<br>\n";
}
?>

</body>
</html>
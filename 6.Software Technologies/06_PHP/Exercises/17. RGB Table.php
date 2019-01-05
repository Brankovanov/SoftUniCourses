<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
	<style>
		table * {
			border: 1px solid black;
			width: 50px;
			height: 50px;
		}
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
    <?php
    $red =51;
    $blue=51;
    $green=51;


    for($lines=1;$lines<=5;$lines++){?>

        <tr>
            <?php
        for($columns=1; $columns<=3; $columns++){

            if($columns==1){
                $redColor ="rgb($red,0,0)";
                echo "<td style='background-color: $redColor'></td>";
                $red+=51;
            }else if($columns==2){
                $greenColor ="rgb(0,$green,0)";
                echo "<td style='background-color: $greenColor'></td>";
                $green+=51;
            }else if($columns==3){
                $blueColor ="rgb(0,0,$blue)";
                echo "<td style='background-color: $blueColor'></td>";
                $blue+=51;
            }

        }?>
</tr>
   <?php } ?>

</table>
</body>
</html>
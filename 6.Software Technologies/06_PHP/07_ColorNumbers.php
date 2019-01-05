<ul>
<?php
for($i =1; $i <= 20; $i++){

    if($i%2==0){
        $color ="green";
    }else{
        $color ="blue";
    }
     echo "<li style='color: $color'>$i</li>";
}
?>
</ul>


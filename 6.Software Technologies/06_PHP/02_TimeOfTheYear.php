<?php $month= intval(date("m"));?>

<?php if($month>=6 && $month<=8) {?>

    <p>It is <?= date("M")?>, a summer time!</p>

<?php } else {?>

    <p>Sorry, not summer.</p>

<?php }?>

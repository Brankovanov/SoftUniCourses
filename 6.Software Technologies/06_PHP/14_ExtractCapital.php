<?php
if(isset($_GET['text'])) {
    $text=$_GET['text'];
    preg_match_all('/\+/', $text, $words);
    $words=$words[0];
    $upperWords = array_filter($words,function($word){
        return strtoupper($word) == $word;
    });
    echo implode(', ',$upperWords);
}
?>

<form>
    <textarea rows="10" name="text"></textarea><br>
    <input type="submit" value="Find upper">
</form>
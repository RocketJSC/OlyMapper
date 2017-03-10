<?php
  $rows = "abcdfghjkmnpqrstvwxz";
  $path = "d:\\Olympia\\turn164";
  $im = @imagecreate(60, 80);
  $y = 0;
  foreach (array("f", "g", "h") as $row) {
    foreach (array("00", "20", "40", "60") as $col) {
      $colors['x_sea']    = imagecolorallocate($im, 0xDD, 0xDD, 0xDD);
      $colors['x_land']   = imagecolorallocate($im, 0xBB, 0xBB, 0xBB);
      $colors['plain']    = imagecolorallocate($im, 0x00, 0xFF, 0x00);
      $colors['forest']   = imagecolorallocate($im, 0x80, 0x80, 0x00);
      $colors['mountain'] = imagecolorallocate($im, 0x80, 0x80, 0x80);
      $colors['desert']   = imagecolorallocate($im, 0xFF, 0xFF, 0x00);
      $colors['swamp']    = imagecolorallocate($im, 0xFF, 0x00, 0xFF);
      $colors['ocean']    = imagecolorallocate($im, 0x00, 0xFF, 0xFF);
      $colors['sealane']  = imagecolorallocate($im, 0x00, 0x80, 0x80);
      $lines = file("$path//faery_map_leaf_$row" . "a" . "$col.html");
      print("$path//main_map_leaf_$row" . "a" . "$col.html\n\r");
      foreach ($lines as $line) {
        if (preg_match("/<td id=\"$row([a-z])([0-9]{2})\" class=\"([a-z_]*)\">/", $line, $matches)) {
          imagesetpixel($im, $matches[2], $y + strpos($rows, $matches[1]), $colors[$matches[3]]);
        }
      }
    }
    $y += 20;
  }
  imagegif($im, "$path//faery_thumbnail.gif");
  imagedestroy($im);
?>

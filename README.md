### 起動方法&必要動作環境
番号ガラガラverX.X.X.zipを展開、番号ガラガラ.exeを起動。


### 使い方
Click!を押すと1～75の範囲で乱数が生成され表示される。また、それと同時に配列にも保存される。

２回目以降は生成された乱数が、配列に保存された今までの乱数と比較され、違うときに表示される。

75個目の乱数が生成されたあとにClick!を押すとメモリエラーを防ぐため強制終了するようにしてある。

右上には残りの乱数の個数が表示される。


終了ボタン・再起動ボタンは分かると思うので説明はパス。


左下のビンゴしたらクリック!は押すとビンゴした人をカウントすることができる。

間違えて押してしまったときは右下の人数-1を押すことで修正可能。


BINGO.csの16行目、const int bingoの値を変えることにより最大値の変更が可能。
その際、用意される配列の個数や繰り返しの回数はいい感じに調整される。

フォントサイズもconst int fontsizeを変更することで変更可能、その際全ての文字が連動して変更される。








2020/12/16:挙動とUIを若干変更

2020/12/11:FHDモードとHDモードを追加













Copyright 2020 Ukai All Rights Reserved.

Download https://drive.google.com/file/d/1NgUy22Ir9PaNU_MC3U7gPLeF_0U_U0I0/view?usp=drive_link

## 前提知識
カービィのエアライドで使われる乱数は、メニュー画面では決められた動作をする際のみ消費します。
* シティトライアルモードでプレイヤーエントリー画面に入る（Zボタンでゲーム設定に入り戻った場合も消費） → 1消費
* スタジアムモードに入る → 1消費
* ドライブモードに入る → 1消費
* 任意のモードのプレイヤーエントリー画面でCPUがエントリーする → エントリーしたCPUの数消費
* データ全消去 → 355消費
### 乱数値の特定
乱数値は以下の式で決定されます。  
r1 = (r0 * 214013 + 2531011) % 4294967296  
スタジアムモードでCPUがエントリーした時、乱数が消費されますが、この乱数値によってCPUのマシンが決定されます。  
このマシンの種類を10個ほど連続で抜き出すことで、現在の乱数値を特定することが可能です。

**参考資料**  
*カービィのエアライド@走法まとめ Wiki* https://wikiwiki.jp/airride/%E4%B9%B1%E6%95%B0%E8%AA%BF%E6%95%B4%20(WIP)
### スタジアムの決定
シティトライアルは、過去4試合で選ばれたスタジアムは除外されるという裏仕様があります（シャッフル設定のみ）。  
スタジアムが決定されるタイミングは、上記の各モードに入った時の乱数1消費の時です。  
実際にスタジアムを遊んでいなくても、過去4試合のスタジアムメモリに格納されていきます。  
例えば、ゲーム設定のスタジアムをポイントストライクにしておき、スタジアムモードに4回入り、その後ゲーム設定でシャッフルに戻して、シティトライアルモードに入ったとします。  
この時点でスタジアムが決定されますが、過去4試合のスタジアムが全てポイントストライクになっているため、その試合でポイントストライクが選ばれることはありません。

# Quick Guide
最初に初期Seedを計算します。数分程度の時間がかかることがあります。この計算をすることで、2回目以降の計算時間を短縮できます。マシンをクリックすると、文字を入力できます。  
First, calculate the initial seed. This may take several minutes. By performing this calculation, you can reduce the calculation time from the second time onward. Click on the machine to enter characters.  
![https://github.com/shirokirby/KAR_RTATool/blob/main/images/1.jpg](https://github.com/shirokirby/KAR_RTATool/blob/main/images/1.jpg)
![https://github.com/shirokirby/KAR_RTATool/blob/main/images/2.jpg](https://github.com/shirokirby/KAR_RTATool/blob/main/images/2.jpg)
![https://github.com/shirokirby/KAR_RTATool/blob/main/images/3.jpg](https://github.com/shirokirby/KAR_RTATool/blob/main/images/3.jpg)

エアグライダーを出してみましょう。まず、ゲーム設定でスタジアムをポイントストライクにします。そして、スタジアムモードを4回選択してください。これは、スタジアムの履歴をポイントストライクで埋めています。  
Let's take out the Air Glider. First, make the stadium "Target Flight" in the game settings. Then select stadium mode 4 times. This fills the history of the stadium with Target Flight. If you're not sure, try "select stadium mode 4 times while in Target Flight" and do this each time.  

![https://github.com/shirokirby/KAR_RTATool/blob/main/images/4.jpg](https://github.com/shirokirby/KAR_RTATool/blob/main/images/4.jpg)

1列目に現在の乱数値からの消費数、2列目にその消費数で出るスタジアムの番号を表します。0または13消費するとエアグライダーが出るようです。CPUマシンを0回または13回エントリーさせた後、ゲーム設定でスタジアムをシャッフルにし、シティトライアルモードを選択して開始しましょう。シティトライアルモードを選択した時点でスタジアムが決定されるので、その前にシャッフルに戻すことを忘れないようにしてください。間違っていなければ、エアグライダーが出るはずです。  
The first column shows the consumption number from the current random value, and the second column shows the stadium number that comes out with that consumption number. If you consume 0 or 13, an Air Glider will appear. After entrying 0 or 13 CPU machines, set the stadium to shuffle in the game settings and select City Trial mode to begin. The stadium will be determined when you select City Trial mode, so don't forget to switch it back to shuffle before doing so. If you are not mistaken, the Air Glider should appear.

左側のチェックボックスは、選ばれる可能性のあるスタジアムを全てチェックする必要があります。逆に、選ばれないスタジアムはチェックを外す必要があります。スタジアムモードを選択しても、スタジアムが内部的に決定され、どのスタジアムのチェックを外せば分からない状態になるので、シャッフルにしたままスタジアムモードを選択しないでください。よく分からなければ、「ポイントストライクにした状態でスタジアムモードを4回選択」これを毎回実行してください。  
All stadiums that may be selected must be checked in the checkboxes on the left. Conversely, stadiums that are not selected must be unchecked. Even if you select stadium mode, the stadium will be determined internally and you will not be able to know which stadium to uncheck, so do not select stadium mode with shuffl setting. If you're not sure, try "select stadium mode 4 times while setting Target Flight" and do this each time.

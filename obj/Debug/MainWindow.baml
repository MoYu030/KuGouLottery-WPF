   M S B A M L   `   `   `  ????G  C抽奖程序, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:抽奖程序抽奖程序  5   	       抽奖程序.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RXamlAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=20a987d8023d9690<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5   	   &localclr-namespace:抽奖程序  5   	   -   5          ? WindowStyle$
  None=?5	   	    ? AllowsTransparency .  ? Title$ 
MainWindow??5   	   $	??455??6   $	??457??6)    ? 	Resources 5         	BaseStyle ?? 
TargetType ?? Property ?? Value  
SaleButton  ZhiZunButton ?? BasedOn ?? 
TargetType	 ??Name
 ?? Triggers P? Property P? Value ?? 
TargetName  AgainButton ?? CornerRadius  GaoJiButton  PuTongButton  
MoreButton J? Opacity  CloseButton ?? TextAlignment  GiftIcon 	 GiftName 
 
PriseLable  BasePopItemStyle  Pop_ExplainButton  Pop_NumButton??%#  &	        &	 t     &	 ?    7  &	 ?    &	 F    7  &	 0    7  &	 2	    &	 ?
    &	 $    &		 ?    7   &	
 ~    7   &	     &	     7  &	 +    7  ?? 5   
   " ??6"   .?5      ??  ? ??$ Center=?64   ?? 5       ? ??$ Center=?62   5      ?? 5   
   " ??6#   .?5      ??  ? ??$ 0q?60   ?? 5       ? ??$ Center=?64   ?? 5       ? ??$	 Top=?62   ?? 5       ? ??$	 100??6&   ?? 5       ? ??$ 50??6'   ?? 5       ? ?? 6+   Z? ?? 5       ? ??$ 5??6)   5      ?? 5   
   8   " ??6K   .?5      ??  ? ?? 5      ?? 5      " ??6&   .R?5      ?? $	 salebuttonborder1??6!   #??z??6<   $??0q?6p   ???	#01ffffff._?5       ?? $??Center=?6(   $??Center=?6C   $??购买??6`   $??16(?6j   $
??Bold"?6x   $??微软雅黑)?6?   ???#800$??0,3,0,16q?6?   5!      
 5"      P? 5#       ?@J?IsMouseOver . . ?5$   "   ?? $ salebuttonborder1??6)    ? ?? ?	#40ffffff6^   5%      5'      5)      5*      ?? 5+   
   " ??6$   .?5,      ??  ? ?? 5-      ?? 5.      " ??6&   .R?5/      ?? $	 again_border??6!   ???#FF8800???#FF8800$ 24??6b   ._?50      ?? $??再买一次??6(   
???????$??18(?6G   $??Center=?6U   $??Center=?6r   51      
 52      P? 53       ? ?? . . ?54   "   ?? $ again_border??6)    ? ?? ?	#90FF88006Y   55      57      59      5:      ?? 5;   
   8   " ??6J   .?5<      ??  ? ?? 5=      ?? 5>      " ??6&   .R?5?      ?? $	 salebuttonborder1??6!   #??z??6<   $??0q?6p   ???	#01ffffff._?5@      ?? $??Center=?6(   $??Center=?6C   $??购买??6a   $??16(?6l   $
??Bold"?6z   ???#ffffff$??0,3,0,16q?6?   5A      
 5B      P? 5C       ?@J?IsMouseOver . . ?5D   "   ?? $ salebuttonborder1??6)    ? ?? ?	#40ffffff6^   5E      5G      5I      5J      ?? 5K   
   8   " ??6K   .?5L      ??  ? ?? 5M      ?? 5N      " ??6&   .R?5O      ?? $	 salebuttonborder1??6!   #??z??6<   $??0q?6p   ???	#01ffffff._?5P      ?? $??Center=?6(   $??Center=?6C   $??购买??6a   $??16(?6l   $
??Bold"?6z   $??微软雅黑)?6?   ???#ffffff$??0,3,0,16q?6?   5Q      
 5R      P? 5S       ?@J?IsMouseOver . . ?5T   "   ?? $ salebuttonborder1??6)    ? ?? ?	#40ffffff6^   5U      5W      5Y      5Z      ?? 5[   
   " ??6#   .?5\      ??  ? ?? 5]      ?? 5^      " ??6&   .R?5_      ?? $	 myBorder??6!   #??z??64   $??0q?6h   $ 20??6|   ???	#80812700._?5a      ?? $.??(Resources/icon-more-pc-normal_5dcbec.png??6$   $	 0.9Q?6V   5b      
 5c      P? 5d       ?@J?IsMouseOver . . ?5e   "   ?? $ myBorder??6)    ? ?? ?	#107A13006U   5f      5h      5j      5k      ?? 5l   
   " ??6$   .?5m      ??  ? ??$ 4??6,   ?? 5n       ? ??$ 2??60   ?? 5o       ? ??$ 2??6-   ?? 5p       ? ??$ 24??6&   ?? 5q       ? ??$ 24??6'   ?? 5r       ? ??$ 	20,0,0,10q?6'   ?? 5s       ? ?? 5t      ?? 5u      " ??6&   .R?5v      ?? $	 myBorder??6!   #??z??64   $??0q?6h   $ 15??6|   ???#af3800._?5x      ?? $??×??6(   $??22(?61   ???#fff$ Center=?6Q   $??Medium"?6i   $??Center=?6~   $??Center=?6?   $??0,0,0,2q?6?   5y      5z      5|      5}      ?? 5~   
   " ??6!   .?5      ??  ? ??$ 2??6)   ?? 5?       ? ??$ 
25,10,0,10q?6'   ?? 5?       ? ??$
 Fill=?6(   5?      ?? 5?   
   " ??6!   8   .?5?      ??  ? ?? ?#fc06+   ?? 5?       ? ??$ 12(?6)   ?? 5?       ? ??$ 2??6)   ?? 5?       ? ??$ 0,11,0,0q?6'   5?      ?? 5?   
   " ??6#   8   .?5?      ??  ? ??$ 4??6)   ?? 5?       ? ??$ 12(?6)   ?? 5?       ? ??$ 0,20,0,0q?6'   5?      ?? 5?   
   " ??6)   .?5?      ??  ? ?? ?#0000006+   ?? 5?       ? ??$ 16(?6)   ?? 5?       ? ??$ Center=?64   ?? 5?       ? ??$ Center=?62   ?? 5?       ? ??$ 4,4,4,4q?6'   5?      ?? 5?   
   " ??6*   8   .?5?      ??  ? ??$ 83??6&   ?? 5?       ? ??$ 32??6'   ?? 5?       ? ?? 5?      ?? 5?      " ??6&   .R?5?      ?? $	 UpgateBtnBorder??6!   
???????#??z??6N   $??0q?6?   $ 21??6?   ._?5?      ?? $??规则说明??6(   $??14(?64   ???#666666$ Center=?6W   $??Center=?6p   $??Center=?6?   5?      
 5?      P? 5?       ?@J?IsMouseOver . . ?5?   "   ?? $ UpgateBtnBorder??6)    ? ?? ?#F0F0F06\   5?      5?      5?      5?      ?? 5?   
   " ??6&   8   .?5?      ??  ? ??$ 86??6&   ?? 5?       ? ??$ 37??6'   ?? 5?       ? ?? ?#9999996+   ?? 5?       ? ??
 ?????6+   ?? 5?       ? ?? 5?      ?? 5?      " ??6&   .R?5?      ?? $	 UpgateBtnBorder??6!   #??z??6:   #??z??6e   $??0q?6?   $ 21??6?   ._?5?      ?? #??z??6/   #??z??6n   5?      
 5?      P? 5?       ?@J?IsMouseOver . . ?5?   "   ?? $ UpgateBtnBorder??6)    ? ?? ?#ebebeb6\   ?? 5?   "    ? ?? ?#0000006?   5?      5?      5?      5?      5?      ??5?      ?? 5?   
    ?? Opacity$ 0Q?6    ?? Color$ Transparent??6&   .??5?      ?  ? RowDefinitions 5?   
   ?? 5?      $??40 ?6   ?? 5?      $	??53* ?6   ?? 5?      $	??54* ?6   ?? 5?      $	??41* ?6   ?? 5?      $
??108* ?6   ?? 5?      $	??47* ?6   ?? 5?      $	??48* ?6   ?? 5?      $	??64* ?6    ? ColumnDefinitions 5?   
   ?? 5?      $	??64* ?6   ?? 5?      $
??189* ?6   ?? 5?      $
??185* ?6   ?? 5?      $
??188* ?6   ?? 5?      $	??64* ?6   ?? 5?      $	??40* ?6   .+?5?   
   ?? $??1??6   $??7??6   $??6??6/   $'??!Resources\page-bg-home_84fbd5.png??6C   $
??Fill=?6n   $??0,0,25,0q?6}   ?? 5?   
   -   5        ???	#01ffffff$??1??5?   D   $??1??6Q   $??3??6a   $??20,12,20,49q?6u   $??2??6?    ? Cursor$ SizeAll??6?   ?? 5?   
   -   5         ??Name$ BtnPop??5?      $??1??6!   #??[ 6C   $??4??6g   $
??None??6w   $??25??6?   $??25??6?   $??0,17,2,0q?6?   ?? 5?   
   -   5        $ BtnClose??5?      #??[ 6;   $??4??6`   $??2??6p   $??25??6?   $??25??6?   $??28,25,10,38q?6?   $??2??6?   ?? 5?   
   $??1??6   $%??Resources\icon-title_ac1fa3.png??6!   #??[ 6K   $??
23,14,23,3q?6m   $??3??6?   ?? 5?   
   $??至尊宝箱??6   $??1??6    #??[	 60   $??16??6R   $??3??6^   $??48??6k   ?? 5?   
   $??2??6   $%??Resources\icon-title_ac1fa3.png??6    #??[ 6I   $??
23,14,23,3q?6k   $??3??6   ?? 5?   
   $??高级宝箱??6   $??2??6    #??[	 61   $??16??6S   $??3??6_   $??48??6l   ?? 5?   
   $??3??6   $%??Resources\icon-title_ac1fa3.png??6    #??[ 6I   $??
23,14,23,3q?6k   $??3??6   ?? 5?   
   $??普通宝箱??6   $??3??6    #??[	 61   $??16??6S   $??3??6_   $??48??6l   ?? 5?   
   $??4??6   $??1??6   $+??%Resources\icon-giftbag-lv1-normal.png??6-   $??3,2,3,6q?6\   ?? 5?   
   $??4??6   $??2??6   $2??,Resources\icon-giftbag-lv2-normal_072802.png??6-   $??3,2,3,6q?6c   ?? 5?   
   $??4??6   $??3??6   $2??,Resources\icon-giftbag-lv3-normal_f0b8e0.png??6-   $??3,2,3,6q?6c   ?? 5?   
   -   5        $ 
btn_zhizun??5?      #??[ 6%   $??1??6K   $??50??6t   $??5??6?   $??Center=?6?   $	??100??6?   ?? 5?   
   $??	100水晶??6   $??1??6!   ???#f46#??[
 6C   $??15??6g   $??0,28,0,0q?6s   $??5??6?   $	??Top=?6?   $??45??6?   ?? 5?   
   -   5        $ 	btn_gaoji??5?      #??[ 6$   $??2??6I   $??50??6q   $??5??6}   $??Center=?6?   $	??100??6?   ?? 5?   
   $??10水晶??6   $??2??6    ???#fe0#??[
 6B   $??15??6f   $??0,28,0,0q?6r   $??5??6?   $	??Top=?6?   $??38??6?   ?? 5?   
   -   5        $ 
btn_putong??5?      #??[ 6&   $??3??6L   $??50??6u   $??5??6?   $??Center=?6?   $	??100??6?   ?? 5?   
   $??5水晶??6   $??3??6   ???#fe0#??[
 6A   $??15??6e   $??0,28,0,0q?6q   $??5??6?   $	??Top=?6?   $??31??6?   ?? 5?   
   $??7??6   $??5??6   .+?5?      ? -   5        $??GroupboxArea??5?   Q   $??7??6   $??5??6    $	??432??64    ?? Left$ 0??6A    5?      ?? 5?      $	??42* ?6'   ?? 5?      $	??74* ?6'   ?? 5?      $
??225* ?6'   ?? 5?      $	??73* ?6'   ?? 5?      $	??18* ?6'   .+?5?      ?? $??0??6   $??2??6)   $ 15??6>   $??67??6P   $
??Left=?6[   $??
24,21,0,19q?6v   ??5?      ?? 5?       ?? EndPoint$ 1.002,0.498&?6.    ?? 
StartPoint$ -0.024,0.502&?6E   .??5?      ?  ? Color$ #880000??6+    ? Offset$ 0.027Q?6;   ? 5?      $ #af3800??6+   $ 0.948Q?6;   5?      5?      ?? 5?      $??0??6   $??2??6)   $+??%Resources\icon-crystal-big_0048d3.png??6=   $??36??6l   $
??Left=?6w   $??23,9,0,8q?6?   ?? 5?      $??1??68   ???#ffffff$??14(?6]   $??	22,0,10,0q?6k   $??Center=?6~   $??16??6?   ??6   ?? *
DiamondNum+6?   ?? 5     -	   5        $ btn_num??5  @     ButtonStyle2#???  6   ???#fff$??14(?6?   $??2??6?   $??Center=?6?   $??0q?6?   $??Right=?6?   $??24??6  $??0,1,1,0q?6%  ??6i   ?? *
ShovelNums+??6?   Z? 6%  ?? 5     $(??"Resources\icon-dropdown_3b2eb9.png??6   $??2??6D   $??11??6T   $??Right=?6_   $??
0,30,11,31q?6{   ?? 5     -
   5         ??Name$ 
img_shovel??5     $??2??6-   $??Resources\icon-gift1.png??6=   $??30??6_   $
??Left=?6j   $??
70,19,0,19q?6?   ?? 5     -   5        $??3??5     $??1??6)   $??	1,17,0,15q?6=   ??5     ?? 5     " ??6*   .R?5     ?? #??z??6%   $??0q?6Y   $ 18??6m   ??5  "   ?? 5	  &   $ 1.002,-0.498&?6:   $ 0.024,0.502&?6R   .??5
  *   ? $ #FFD115??67   $ 0.027Q?6G   ? 5  *   $ #FFA453??67   $	 0.9Q?6G   5  '   ._?5  "   ?? $??赠送??6,   ???#862828$??16(?6K   $??Center=?6Y   $??Center=?6v   5     5     5     5     5     ? 5  
   -   5         ?Name$	 Pop??5     $??Slide=?6   $??Bottom=?6c    ? AllowsTransparency .  ? 	StaysOpen .  $??2??6?   $??	0,0,24,18q?6?   $??2??6?     ? PlacementTarget  64   ?? ! ?? ElementName$! BtnPop??.??5     ?? ???#ffffff$ 12??6*   ._?5     ?? $??2q?6   .+?5     ?? -   5        $ btn_explain??5     #??[ 63   6^   5     5     5     ? 5  
   -   5        $ PopNum??5     $??Slide=?6!   $	??Top=?6?    .  .  $??2??6?   $??2??6?     6U   ?? $! btn_num??.??5     ?? ???#ffffff$ 12??6*   ._?5     ?? $??8,0,8,0q?6   .+?5      ?? -   5        $ btn_num1??5      $??5??6F   $??Center=?6S   $??Center=?6p   #??[ 6?   $??0,12,0,0q?6?   ?? 5!     -   5        $ btn_num2??5!     $??10??6F   $??Center=?6T   $??Center=?6q   #??[ 6?   ?? 5"     -   5        $ btn_num3??5"     $	??100??6F   $??Center=?6U   $??Center=?6r   #??[ 6?   ?? 5#     -   5        $ btn_num4??5#     $	??500??6F   $??Center=?6U   $??Center=?6r   #??[ 6?   $??0,0,0,12q?6?   5$     5%     5&     ?? 5(  
   -   5        $	 giftInfo??5(  <   $ 12??6O   $	??311??6b   $	??330??6o   $??Center=?6{   $??Bottom=?6?   $??1??6?   $??1??6?   $??3??6?   $??6??6?   $??0,0,0,3q?6?   y?6   ?? *ResultVisibility+??5)     ?? 5*     $ 0Q?6"   $ White??6.   ._?5,     ?  5-     ?? 5.     $	??33* ?6'   ?? 5/     $	??23* ?6'   ?? 50     $	??10* ?6'    52     ?? 53     $	??28* ?6$   ?? 54     $	??28* ?6$   ?? 55     $
??129* ?6$   ?? 56     $	??37* ?6$   ?? 57     $	??76* ?6$   .+?59     ?? $ 12??6   $??1??6+   $??4??68   $??3??6I   
???????6]   ?? 5:     $??2??6   $??2??6,   $,??&Resources\icon-modal-header_3dd94a.png??6=   $
??Fill=?6m   $	??248??6|   $??	50,0,0,12q?6?   ?? 5;     $??0??6   $??2??6)   $??3??6;   $??恭喜获得神秘礼物??6O   
???????$??18(?6r   $ Center=?6?   $
??Left=?6?   $??Center=?6?   $	??280??6?   $??	25,0,0,20q?6?   $??24??6?   ?? 5=     -   5        " ??Name$" list_result??5=  C     ListBoxStyle1#???  6   $??Center=?6X   $??Center=?6|   $??Bottom=?6?   $??2??6?   $??3??6?   $??6,0,10,2q?6?   $??0q?6?   ??5>     ?? 5?     " ??6    .?5@     ??  ? |? .  6:   ?? 5A      ? ??$ 6,0,6,0q?67   ?? 5C      ? {? .  6:   5E     ??5G     ?? 5H     .R?5I     ?? # ?? Orientation$# 
Horizontal=?6)   5J     ??5L     ?? 5M     .R?5N     ?  5O  "   ?? 5P  &   $??* ?64   ?? 5Q  &   $??* ?64   .+?5T  "   ?? $??58??6^   $??58??6i   $??Center=?6u   $??0,0,0,4q?6?   '  !XamlAnimatedGif.AnimationBehavior$   	SourceUri$ 6)   ?? *	ImgName+6?   ?? 5U  "   
???   ?$??Medium"?6U   $??14(?6k   $??1??6z   $ Center=?6?   $??Center=?6?   ??6,   ?? *Name+6?   5V     5W     5Y     ?? 5[     $!??已经放入礼物 - 仓库??6   $??3??6/   $??2??6<   ???#999999$??14(?6e   $??Center=?6t   $
??Left=?6?   $??18??6?   $??	100,0,0,3q?6?   $	??127??6?   ?? 5]     -   5        $ 
btn_submit??5]     $??4??6G   $??	22,7,7,23q?6T   ??5^     ?? 5_     " ??6*   .R?5`     ?? ???#FF8800
???????$??1q?6N   $ 24??6b   ._?5a  "   ?? $??	知道了??6,   ???#FF8800$??18(?6L   $??Center=?6Z   $??Center=?6w   5b     5c     5e     ?? 5g     -   5        $ btn_saleagain??5g     $??4??6L   $??1??6Y   $??	8,8,26,23q?6i   $??2??6|   #??[ 6?   5h     5i     ?? 5k  
   -   5        $
	 tips??5k  8   
???   ?$ 16??6Y   $
 0.75Q?6k   $??0,24,0,5q?6z   $??78??6?   $	??210??6?   $??Center=?6?   $	??Top=?6?   $??1??6?   $??3??6?   $??4??6?   y?6   ?? *TipsVisibility+._?5l     ?? 
???????$??18(?6D   $
??Wrap=?6R   $	 0.9Q?6f   $
 Left=?6t   $??Center=?6?   $??Center=?6?   $	??190??6?   ??6   ?? *	NumTips+6?   5m     ?? 5o     -   5        $	 tips_increase??5o  *   $y?Hidden=?6   
???   ?$ 12??6T   $
 0.75Q?6f   $??0,34,0,5q?6u   $??56??6?   $	??230??6?   $??Center=?6?   $	??Top=?6?   $??1??6?   $??3??6?   $??4??6?   ._?5p     ?? $# 
Horizontal=?6   $
??Left=?62   $??8,0,0,0q?6M   .+?5q     ?? $??赠送成功，获得??6   
???????$??18(?6>   $
??Wrap=?6L   $	 0.9Q?6`   $
 Left=?6n   $??Center=?6?   $??Center=?6?   ?? 5r     $+??%Resources\icon-crystal-big_0048d3.png??6   $??40??6H   $??40??6S   $??0q?6_   ?? 5s     
???????$??18(?6M   $
??Wrap=?6[   $	 0.9Q?6o   $
 Left=?6}   $??Center=?6?   $??Center=?6?   ??6   ?? *IncreaseStr1+6?   5t     5u     ?? 5v  
   $??6??6   $??2??6   $??2??6/   .+?5w     ?? -   5        $??	grid_Area??5w     $y?Hidden=?6&   ???	#80000000$??49??6Q   $??16??6\   $ 25??6h   
% ?? Top$% 75??6y   $ 8??6?   ._?5x     ?? $# 
Horizontal=?6   .+?5y     ?? $+??%Resources\icon-crystal-big_0048d3.png??6   $??18??6L   $??18??6W   ?? 5z     $??+??6    
???????$??12(?6<   $
??Wrap=?6J   $	 0.9Q?6^   $
 Left=?6l   $??Center=?6?   $??Center=?6?   ?? 5{     
???????$??12(?6Q   $
??Wrap=?6_   $	 0.9Q?6s   $
 Left=?6?   $??Center=?6?   $??Center=?6?   ??6    ?? *IncreaseStr2+6?   5|     5}     5~     5     5?     
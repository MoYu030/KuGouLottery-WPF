# 介绍
这是一款大小尺寸，UI界面都1：1完美复刻了酷狗直播抽奖的UI界面的一个程序，实现了与其相同的所有功能以及部分动画
# 界面展示
![image](https://github.com/MoYu030/KuGouLottery-WPF/blob/main/Resources/131058.png)
![image](https://github.com/MoYu030/KuGouLottery-WPF/blob/main/Resources/131020.png)
# 部分功能介绍
点击**赠送按钮**就可以增加水晶数继续抽奖，点击按钮旁的**可获XXX个水晶**字样即可更改一次增加的水晶数
# 说明
礼物有三种 分别保存在不同的Json文件(文件名为XXXGiftData.json)中，
因为Json文件在release文件夹中，所以要使用，需用VS打开项目，release调试项目<br>
也可以在Json文件中修改礼物的概率，（endpoint-startpoint）%，就是礼物的概率，请确保每种礼包中所有礼物概率相加为100%<br>
（原先用winform写了一个修改概率的程序，丢了，等找到一并上传>.<）
**这是刚接触Wpf不久时写的项目，代码比较乱，可下载试玩，但谨慎修改**

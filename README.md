# MobileVRController

可以在Unity中用到的一個光源遙控器

![gif](https://github.com/106820017/VRController/blob/master/gif%20(4).gif)
![gif](https://github.com/106820017/VRController/blob/master/gif%20(5).gif)
![gif](https://github.com/106820017/VRController/blob/master/gif%20(3).gif)
![gif](https://i.imgur.com/lTEbmYT.gif)

移動裝置與Unity連線方法:
------------------------
●在Unity專案中，加入MController的Prefab到場景中

●在手機上安裝控制器的APK檔

●專案執行中，將手機App內的IP指向伺服器端的IP (DHCP)

●按下連接即可連線至伺服器端以控制光源

![image](https://i.imgur.com/4sDPvZ1.png)

特點:
---------
- 方便使用的連線與燈光控制介面
- 直觀控制執行中專案的燈光方向

源頭專案預設的Service:
----------------------
- GyroServiceProvider: 陀螺儀資訊
- AccelServiceProvider: 重力感應器資訊
- TouchServiceProvider: 觸控點資訊
- SwipeServiceProvider: 滑動資訊

新增的Service:
--------------
- UIServiceProvider: 取得面板UI資訊

引用專案:
-----
mrayy / MobileVRController:
https://github.com/mrayy/MobileVRController

judah4/HSV-Color-Picker-Unity:
https://github.com/judah4/HSV-Color-Picker-Unity


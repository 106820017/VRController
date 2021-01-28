# MobileVRController

可以在Unity中用到的一個光源遙控器

![gif](https://drive.google.com/file/d/1ADtMKy3onpDOf8snDnUtKn9bZkWLM0tO/view?usp=sharing)

移動裝置與Unity連線方法:
------------------------
●在Unity專案中，加入MController的Prefab到場景中

●在手機上安裝控制器的APK檔

●專案執行中，將手機App內的IP指向伺服器端的IP (DHCP)

●按下連接即可連線至伺服器端以控制光源

![image](https://drive.google.com/file/d/16oec2zuuOdSXWkcYxR5JC6WaTtsZi4jo/view?usp=sharing)

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

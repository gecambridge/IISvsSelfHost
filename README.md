# IIS与 Selfhost模式测试

可以下载源码重现此测试，并得出相同的测试结论：
在通用情况下，selfhost模式优于IIS托管模式

测试脚本：
```
ab -n 100000 -c 100 http://myip:port/api/testapi
```

测试机器：

|机器|CPU|内存|操作系统
| ------------- |:-------------: |:-------------:| -----:| 
|win7| i3| 8G|win7 Ultimate x64 
|WinSer2008| i5| 8G| win2008 x64
|WinSer2012| i5| 8G| Win2012 x64

测试结果：

| Round | Host | Requests (#/sec)| Time per request (ms)|
| ------------- |:-------------: |:-------------:| -----:| 
| win7 | self-host | 464.00 |215 
| win7 | IIS 7.5 | 406.02 | 246
|WinSer2008|IIS 7.5|3025.73|33.050
|WinSer2008|self-host|4624.44|21.624
|WinServ2012|IIS 8.5|4778.23|20.928
|WinServ2012|self-host|5612.23|17.818

 

   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089 
  biFile  biSelectDevice  coStart  coPause 
 coStop  coClear 
 coSave  coOperation  coFrame 	 coTimes 
 
coSendData  
coInterval 
 coSend  coDirection 
 coTime  scDevice  scDevicePara  scInitialPara 
 scType  
scDevIndex  scDevChannel  scTimer0  scTimer1  
scBaudrate  	scPattern  scCheckCode  scShieldCode  scSelect  scOK  scCanel  scCANFDStandary  scArbitrationBaudRate   scDataBaudRate ! scIsTerminalResistance " scSystemSetting # 
scProtocol $ scRecordInterval % scHandShakeInterval & scWakeInterval ' scVoltageBase ( scVoltageError ) scTemperatureBase * scTemperatureError + scHardwareVersion , scSoftwareVersion - teNormal . teListenonly / tePrompt 0 tePromptText1 1 tePromptText2 2 tePromptText3 3 	teReceive 4 teStandardFrame 5 teExtendedFrame 6 tbLoadProtocol 7 tbLoadParam 8 tbLoadAdjustOffset 9 tbUpLoadParam : tbUpLoadAdjustOffset ; tbCommunicationRecords < tbRealtimeRecords = tbHistoryRecords > tbAdjustAndControl ? tbDebug @ 	tbVerInfo A 	tbAidInfo B 
tbPackInfo C 	tbSetting D 
tbLanguage E 	tbChinese F 	tbEnglish G tbUnlock H 	gcBatVolt I gcBatCur J cbpMaxCellVolt K cbpMinCellVolt L cbpAvgCellVolt M 	glMaxTmpr 
N chVolt 	O chCur 	P ttSoc 	Q ttSoh 
R teMode S teInsulatio T 	teBatType U teManufacturers V 	teSoftVer W 	teHardVer X 
teBatCells Y gbPackStatus 	Z brOSI 
[ brMode \ undefinedMode ] dxglRelayStatus ^ dxglInputSignals _ dxglOutputSignals ` dxglWarnAndProtect a upLoadPromt b successPromt c sessionChangePromt d unLockSucessPromt e requestSeedPromt f clearDTCPromt g NoMatchRecordPromt h errorUploadCompletedPromt i 
txblOnline j txblOffline k eclpColorMaskProtect l eclpColorMaskWarn m eclpColorMaskNormal n txblProtection o txblWarn p 
txblNormal q txblRecordCnt r bsiCurrentPack s gpbHighestVolt t gpbLowestVolt u gpbAverageVolt v gpbHighestTmpr w gpbLowestTmpr x txblPackAddr y txblPackSoftVer z txblPackHardVer { txblVoltagedifference | txblTemperaturedifference } txblBalanceMask ~ txblAFEMask  promtUpLoad � promtParameter � promtAdjust � promtUpLoadParam � promtUpLoadAdjust � promtAdjustAction � promtUpLoadAdjustOffset � tbicOpenParaFile � tbicSaveAsParaFile � tbicParaClose � tbicParaSetAll � tbicParaSave � tbicParaReset � grpbhNumericalparameter � grpbhFunctionswitch � grpbhOtherparameters � 
dxgacIndex � 	dxgacName � 
dxgacValue � 	dxgacunit � dxgacbalance � dxgacoperate � btndownload � promtSetAllPara � promtSavePara � promtResetPara � tbicOpenAdjustFile � tbicSaveAsAdjustFile � tbicAdjustClose � tbicAdjustSetAll � tbicAdjustSave � tbicAdjustReset � grpbhNumericaladjust � grpbhBmsClock � grpbhFunctionctrl � grpbhVersionInfo � btncReadTime � btncSetTime � readTimePromtInfo � setTimePromtInfo � grpbhRelayCtrl � tbicRealTimeRecordStart � tbicRealTimeRecordStop � tbicRealTimeRecordSave � tbicRealTimeRecordClear � tbicRealTimeRecordClose � dateRealPromt � timeRealPromt � modeRealPromt � auxInputSignalPromt � relayStatusPromt � warnRealPromt � 	datePromt � 	timePromt � 	warnPromt � clearDTC � readDTC � promtSessionSelect � promtUnlockOperation � promtChangeto � promtSessionType � promtSessionChange � promtRequestSeed � promtSendKey � promptNonProtocol � promptNonParameter � promptNonAdjust � promtNoFidProtocol � 
promtError � loadProtocolFile � protocolDefinitionFile � promtAllFile � promtProtocolLoading � promtParaFile � promtOpenParaFileSuccess � promtOpenParaFileFailed � promtAllParaUploading � promtAllAdjustUploading � promtPleaseWait � promtLoading � promtLoadingBasicSettings � promtLoaddingmeterSettings � promtLadingMasterSettings � promtLoadingPackSettings � promtInitializationTable � promtProtocolLoadingSucess�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .sys&clr-namespace:System;assembly=mscorlib  5      %v&  &	        &	      &	 <     &	 Z     &	 x     &	 �     &	 �     &	 �     &	 �     &		     &	
 <    &	 _    &	 �    &	 �    &	 �    &	 �    &	 �    &	 #    &	 J    &	 k    &	 �    &	 �    &	 �    &	 �    &	     &	 F    &	 l    &	 �    &	 �    &	 �    &	 �    &	     &	  B    &	! o    &	" �    &	# �    &	$ �    &	%     &	& D    &	' x    &	( �    &	) �    &	* �    &	+     &	, F    &	- n    &	. �    &	/ �    &	0 �    &	1     &	2 L    &	3 s    &	4 �    &	5 �    &	6 �    &	7 �    &	8     &	9 E    &	: i    &	; �    &	< �    &	= �    &	> �    &	? &	    &	@ D	    &	A h	    &	B �	    &	C �	    &	D �	    &	E �	    &	F 
    &	G &
    &	H D
    &	I h
    &	J �
    &	K �
    &	L �
    &	M �
    &	N     &	O #    &	P A    &	Q e    &	R �    &	S �    &	T �    &	U �    &	V     &	W :    &	X _    &	Y ~    &	Z �    &	[ �    &	\ �    &	] �    &	^ $    &	_ H    &	` l    &	a �    &	b �    &	c �    &	d �    &	e     &	f G    &	g q    &	h �    &	i �    &	j �    &	k �    &	l %    &	m R    &	n     &	o �    &	p �    &	q �    &	r �    &	s !    &	t L    &	u w    &	v �    &	w �    &	x �    &	y     &	z *    &	{ O    &	| n    &	} �    &	~ �    &	 �    &	� �    &	�     &	� .    &	� R    &	� y    &	� �    &	� �    &	� �    &	�     &	� -    &	� Q    &	� u    &	� �    &	� �    &	� �    &	�     &	� #    &	� A    &	� _    &	� }    &	� �    &	� �    &	� �    &	�     &	� (    &	� P    &	� z    &	� �    &	� �    &	� �    &	�     &	� %    &	� I    &	� p    &	� �    &	� �    &	� �    &	� �    &	� !    &	� H    &	� o    &	� �    &	� �    &	� �    &	� �    &	�     &	� #    &	� A    &	� _    &	� �    &	� �    &	� �    &	� �    &	� 
    &	� (    &	� I    &	� g    &	� �    &	� �    &	� �    &	� �    &	�     &	� B    &	� c    &	� �    &	� �    &	� �    &	�     &	� ;    &	� �    &	� �    &	� �    &	� �    &	�     &	� P    &	� �    &	� �    &	� �    &	� �    &	�     &	� K    &	� x    &	� �    &	� �    &	� �    ��5      
文件��6$   ��5      
设置��6,   ��5      
启动��6%   ��5      
暂停��6%   ��5      
停止��6$   ��5      
清空��6%   ��5      
保存��6$   ��5      基本操作��6+   ��5      
帧ID(HEX)��6+   ��5      发送次数��6'   ��5      数据(HEX)��6-   ��5      发送间隔(ms)��6.   ��5      
发送��6$   ��5      
方向��6)   ��5      
时间��6$   ��5      
设备��6&   ��5      设备参数��6,   ��5       初始化参数��6.   ��5!      	类型：��6%   ��5"      	索引：��6)   ��5#      	通道：��6+   ��5$      定时器0：0x��6+   ��5%      定时器1：0x��6+   ��5&      波特率：��6*   ��5'      工作模式：��6*   ��5(      验收码：0x��6-   ��5)      屏蔽码：0x��6.   ��5*      	请选择��6'   ��5+      
确定��6"   ��5,      
取消��6%   ��5-      CANFD标准：��63   ��5.      仲裁域波特率：��68   ��5/      数据域波特率：��61   ��50      终端电阻使能：��69   ��51      系统设置：��60   ��52      协议:��6)   ��53      数据记录间隔时间:��65   ��54      握手连接间隔时间:��68   ��55       浅休眠唤醒间隔时间:��64   ��56      电压基数(mV):��62   ��57      电压误差(mV):��63   ��58      温度基数(℃):��65   ��59      温度误差(℃):��66   ��5:      硬件版本号:��63   ��5;      软件版本号:��63   ��5>      
正常��6&   ��5?      
只听��6*   ��5@      
提示��6&   ��5A      C?此类型CAN盒没有多余的设备或者通道可以打开！��6@   ��5B      打开CAN盒失败！��62   ��5C      发送失败！��6.   ��5D      
接收��6'   ��5E      	标准帧��6.   ��5F      	扩展帧��6.   ��5J      加载协议��6.   ��5K      加载参数��6+   ��5L      加载校准偏移��64   ��5M      参数管理��6-   ��5N      上传校准偏移值��67   ��5O      通讯记录��66   ��5P      实时记录��61   ��5Q      	DTC信息��61   ��5R      校准和控制��63   ��5S      
调试��6%   ��5T      版本信息��6)   ��5U      辅助信息��6)   ��5V      
Pack信息��6,   ��5W      
设置��6'   ��5X      
语言��6(   ��5Y      
中文��6'   ��5Z      
英文��6'   ��5[      
解锁��6&   ��5^      总电压(V)��6+   ��5_      	电流(A)��6)   ��5`      最大:��6-   ��5a      最小:��6-   ��5b      平均:��6-   ��5c      最高:��6(   ��5d      
电压��6$   ��5e      
电流��6#   ��5f      剩余容量��6%   ��5g      电池健康状态��6'   ��5h      
模式��6$   ��5i      绝缘阻值��6+   ��5j      电池类型:��6*   ��5k      厂商:��6.   ��5l      软件版本:��6*   ��5m      硬件版本:��6*   ��5n      串数:��6)   ��5o      
Pack状态��6.   ��5p      
绝缘��6#   ��5q      
模式��6$   ��5r      	未定义��6,   ��5s      继电器状态��60   ��5t      输入信号��60   ��5u      输出信号��61   ��5v      告警和保护��63   ��5w      
上传��6)   ��5x      
成功��6*   ��5y      会话切换成功��64   ��5z      解锁成功��61   ��5{      请求种子成功��62   ��5|      DTC信息已清楚��61   ��5}      无匹配记录��63   ��5~      上传完成��69   ��5�      
在线��6(   ��5�      
断开��6)   ��5�      颜色 标识--保护��69   ��5�      颜色 标识--告警��66   ��5�      颜色 标识--正常��68   ��5�      
保护��6,   ��5�      
告警��6&   ��5�      
正常��6(   ��5�      实时记录:��6.   ��5�      当前pack:��61   ��5�      最高单体电压:��61   ��5�      最低单体电压:��60   ��5�      平均电压:��6/   ��5�      最高温度:��6/   ��5�      最低温度:��6.   ��5�      地址:��6+   ��5�      软件版本:��60   ��5�      硬件版本:��60   ��5�      压差:��64   ��5�      温差:��68   ��5�      均衡标识:��60   ��5�      
AFE标识:��6-   ��5�      
上传��6)   ��5�      
参数��6,   ��5�      
校准��6)   ��5�      上传参数��60   ��5�      上传校准值��62   ��5�      
校准��6/   ��5�      上传校准偏移值��6:   ��5�      打开参数文件��62   ��5�      	另存为��61   ��5�      
关闭��6+   ��5�      设置所有��6.   ��5�      设置保存��6,   ��5�      恢复出厂��6-   ��5�      数值参数��67   ��5�      功能开关��63   ��5�      其它参数��64   ��5�      
序号��6(   ��5�      
名称��6'   ��5�      
数值��6(   ��5�      
单位��6'   ��5�      
均衡��6*   ��5�      
操作��6*   ��5�      
下载��6)   ��5�      Set all parameters��6=   ��5�      Save parameters��68   ��5�      Reset parameters��6:   ��5�      打开校准文件��64   ��5�      	另存为��63   ��5�      
关闭��6-   ��5�      设置所有��60   ��5�      设置保存��6.   ��5�      恢复出厂��6/   ��5�      数值校准��64   ��5�      保护板时钟��6.   ��5�      功能控制��61   ��5�      版本信息��60   ��5�      	读时间��6+   ��5�      设置时间��6+   ��5�      读BMS时间��63   ��5�      设置BMS时间��63   ��5�      继电气控制��6/   ��5�      
开始��65   ��5�      
停止��64   ��5�      
保存��64   ��5�      
清除��65   ��5�      
关闭��65   ��5�      
日期��6+   ��5�      
时间��6+   ��5�      
模式��6+   ��5�      输入输出信号��65   ��5�      继电器状态��61   ��5�      
告警��6+   ��5�      
日期��6'   ��5�      
时间��6'   ��5�      
告警��6'   ��5�      	清除DTC��6)   ��5�      
读DTC��6'   ��5�      会话选择 $10��66   ��5�      解锁操作 $27��6:   ��5�      
切换��6+   ��5�      会话类型:��61   ��5�      会话切换��62   ��5�      请求种子��60   ��5�      	发送key��6-   ��5�      非协议文件��62   ��5�      非参数文件��63   ��5�      非校准文件��60   ��5�      1-未发现协议文件，请导入协议文件��6=   ��5�      
错误��6(   ��5�      :6加载协议文件失败，请确认后重新加载。��6>   ��5�      协议定义文件��68   ��5�      所有文件��6,   ��5�      加载协议��64   ��5�      参数文件��6-   ��5      打开参数文件成功.��6=   ��5     打开参数文件失败.��6<   ��5     上传所有参数��67   ��5     上传所有校准值.��6;   ��5     	请等待��6.   ��5     加载中...��6.   ��5     加载基本设定...��6>   ��5     加载仪表设置...��6?   ��5     加载主控配置...��6>   ��5	     加载pack配置...��6?   ��5
     表格初始化...��6<   ��5     协议加载成功��6<   5     
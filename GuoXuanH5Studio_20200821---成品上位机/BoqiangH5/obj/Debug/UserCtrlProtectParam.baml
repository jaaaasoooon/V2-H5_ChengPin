   M S B A M L   `   `   `  ����D  @BoqiangH5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BoqiangH5	BoqiangH5  5      $    BoqiangH5.UserCtrlProtectParam   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:BoqiangH5     5      -   5        .��5	      � ���	#FFE5E5E5$��0��6"     � ColumnDefinitions  5
   
   �� 5      $
��200* �6   �� 5      $
��200* �6   �� 5      $
��200* �6    � RowDefinitions 5   
   �� 5      $	��40* �6   6+   �� 5      $	��60* �6   6+   .+�5   
   �� $��电压保护参数��6   $��2q�6#   $��0��6.   $��2��6>   .��5      &   System.Windows.Controls.DataGrid  -   5        $��dgVoltageParam��5         CanUserAddRows .     CanUserSortColumns .     AutoGenerateColumns .  $��14(�6|      RowHeaderWidth$ 0Q�6�   $��0 5 0 5q�6�   ��.     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5         
dxgacIndex,  &System.Windows.Controls.DataGridColumn   Header# �   6-     DataGridHeaderStyle   HeaderStyle# [ 6S   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6�   
   
IsReadOnly
 .    CellTemplate 5      �� 5      .R�5   "   �� $��Center=�6G   ��6(   ��  �� Path$ Index�6G   5      5      0  *System.Windows.Controls.DataGridTextColumn  5        	dxgacName# �  6)   # [ 6O   $
	 150* 6�   
 .  ! DataGridTextColumnCenterStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6�      Binding 6�   �� $ Description�6    5        
dxgacValue# �  6)   # [ 6O   $		 80* 6�   
 . # [ 6�    6�   �� $ StrValue�6�     5        	dxgacunit# �  6)   # [ 6N   $		 60* 6�   
 . # [ 6�    6�   �� $
 Unit�6�   5!      5"      �� 5#   
   $��电流保护参数��6   $��2q�6#   $��1��6.   $��0��6>   .��5$        -   5        $��dgCurrentParam��5$       .   .   .  $��14(�6|   $ 0Q�6�   $��0 5 0 5q�6�   ��.   5%        5&      # �   6-   # [ 6S   $	 50 6�   
 .  5'      �� 5(      .R�5)   "   �� $��Center=�6G   ��6(   �� $ Index�6G   5*      5,        5-      # �  6)   # [ 6O   $
	 150* 6�   
 . # [ 6�    6�   �� $ Description�6    5.      # �  6)   # [ 6O   $		 80* 6�   
 . # [ 6�    6�   �� $ StrValue�6�     5/      # �  6)   # [ 6N   $		 60* 6�   
 . # [ 6�    6�   �� $
 Unit�6�   51      52      �� 53   
   $��温度保护参数��6   $��2q�6#   $��1��6.   $��1��6>   .��54        -   5        $��dgTemperatureParam��54       .   .   .  $��14(�6�   $ 0Q�6�   $��0 5 0 5q�6�   ��.   55        56      # �   6-   # [ 6S   $	 50 6�   
 .  57      �� 58      .R�59   "   �� $��Center=�6G   ��6(   �� $ Index�6G   5:      5<        5=      # �  6)   # [ 6O   $
	 150* 6�   
 . # [ 6�    6�   �� $ Description�6    5>      # �  6)   # [ 6O   $		 80* 6�   
 . # [ 6�    6�   �� $ StrValue�6�     5?      # �  6)   # [ 6N   $		 60* 6�   
 . # [ 6�    6�   �� $
 Unit�6�   5A      5B      �� 5C   
   $��告警参数��6   $��2q�6!   $��2��6,   $��2��6<   .��5D        -   5        $��dgWarningParam��5D       .   .   .  $��14(�6|   $ 0Q�6�   $��0 5 0 5q�6�   ��.   5E        5F      # �   6-   # [ 6S   $	 50 6�   
 .  5G      �� 5H      .R�5I   "   �� $��Center=�6G   ��6(   �� $ Index�6G   5J      5L        5M      # �  6)   # [ 6O   $
	 150* 6�   
 . # [ 6�    6�   �� $ Description�6    5N      # �  6)   # [ 6O   $		 80* 6�   
 . # [ 6�    6�   �� $ StrValue�6�     5O      # �  6)   # [ 6N   $		 60* 6�   
 . # [ 6�    6�   �� $
 Unit�6�   5Q      5R      5S      5T      
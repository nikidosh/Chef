   M S B A M L   `   `   `  ����M  IChef_administrator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Chef_administrator.PropertiesChef_administrator.Properties  5      7 clr-namespace:Chef_administratorChef_administrator  5   	   $    Chef_administrator.Ingredients   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   9p+clr-namespace:Chef_administrator.Properties     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Chef_administrator     5   	   -   5          � Title$  Ingredients��5	   	   $	��720��6   $
��1080��6*   .��5
      � $��0,0,664.6,0.4q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	goodsGrid��5   /      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   'Chef_administrator.Properties.Resources   Title,  &System.Windows.Controls.DataGridColumn   Header# Z 6>      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6d     5         Quantity# Z 6?   $	 200 6h    6%   �� *Count+6h   5      �� 5   
   -   5        
	   Add#��Z	 5      $��15(�67   
��� � �$��444,50,-164,589q�6p   $
��Auto��6�   
 � Cursor$

 Hand��6�   �� 5   
   -   5           Menu#��Z 5      $��15(�69   
��� � �$��444,103,-164,549q�6v   $
��Auto��6�   �� 5   
   -   5           Delete#��Z 5      $��15(�6:   
��� � �$��444,150,-164,501q�6v   $
��Auto��6�   �� 5   
      Search_by_name#��Z 6   $��444,229,-321,401q�6@   $��20(�6[   �� 5   
   -   5         ��Name$ textBoxSearch��5      $��444,288,-291,352q�6)   $��20(�6D   $
 Arrow��6R   �� 5   
   -   5           Search#��Z 5      $��448,349,-178,287q�6:   $	��145��6l   
��� � �$

 Hand��6�   5      5      
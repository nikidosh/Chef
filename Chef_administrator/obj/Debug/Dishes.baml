   M S B A M L   `   `   `  ����M  IChef_administrator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Chef_administrator.PropertiesChef_administrator.Properties  5      7 clr-namespace:Chef_administratorChef_administrator  5   	       Chef_administrator.Dishes   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   9p+clr-namespace:Chef_administrator.Properties     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Chef_administrator     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          � Title$  Dishes��5
   	   $	��720��6   $
��1080��6%   .��5      � 
�������$	��720��6   $
��1080��6+   .+�5   
   �� -   5        -   'Chef_administrator.Properties.Resources   Delete#��Z 5      $��15(�6;   
��� � �$��939,23,38,663q�6w   $
��Auto��6�    � Cursor$
 Hand��6�   �� 5   
   -   5           Sorted_by_weight#��Z 5      $��15(�6D   
��� � �$��511,23,253,665q�6|   $
��Auto��6�   $
 Hand��6�   �� 5   
   -   5           Sort_by_price#��Z 5      $��15(�6A   
��� � �$��511,62,383,626q�6y   $
��Auto��6�   �� 5   
   -   5         ��Name$ s1��5      
�������$
��Left=�63   $	��506��6N   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	goodsGrid��5   3      AutoGenerateColumns .  $��
0,0,-0.4,0q�6F      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      	   Title,  &System.Windows.Controls.DataGridColumn
   Header#
 Z	 6B      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Name+6h     5         Weight#
 Z 6D   $	 100 6k    6)   �� *Weight+6k     5         Price#
 Z 6C   $	 100 6i    6)   �� *Price+6i     5         Quantity#
 Z 6D   $	 100 6m    6)   �� *Amount+6m     5         Category#
 Z 6F   $	 100 6o    6)   �� *
Category+6o   5      5      �� 5   
   -   5        $ s1_Copy1��5      $	��300��6#   
�������$	��Top=�6E    �� Padding$ 10q�6]   $
��1200��6j    �� CornerRadius$ 25��6z   $	��170��6�   $
��Left=�6�   $	��559��6�   $��511,106,0,0q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   5       �� 5!   
      Search_by_name#��Z 6   $��531,125,290,563q�6@   $��20(�6Z   �� 5"   
   -   5         ��Name$ textBoxSearch��5"      $��531,162,372,518q�6)      Enter_the_title)  #MaterialDesignThemes.Wpf.HintAssist   Hint# Z 6B   $��20(�6�   $ Arrow��6�   6�   �� 5#   
   -	   5           Search#��Z 5#      $��531,228,404,460q�6:   $	��145��6k   
��� � �$
 Hand��6�   �� 5$   
   -
   5        
   Add#��Z 5$      $��15(�67   
��� � �$��832,23,146,665q�6p   $
��Auto��6�   $
 Hand��6�   �� 5%   
   -   5           Menu#��Z 5%      $��15(�68   
��� � �$��702,62,276,626q�6q   $
��Auto��6�   �� 5&   
   -   5           Export#��Z 5&      $��15(�6:   
��� � �$��832,62,119,626q�6w   $
��Auto��6�   $
 Hand��6�   5*      5+      
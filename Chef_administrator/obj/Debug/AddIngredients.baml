   M S B A M L   `   `   `  ����M  IChef_administrator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Chef_administrator.PropertiesChef_administrator.Properties  5      7 clr-namespace:Chef_administratorChef_administrator  5   	   '    !Chef_administrator.AddIngredients   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   9p+clr-namespace:Chef_administrator.Properties     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Chef_administrator     5   	   -   5          � Title$  AddIngredients��5	   	   $	��720��6    $
��1080��6-    � Cursor$
 Hand��6Q   .��5      � 
�������$	��720��6   $
��1080��6+   .+�5   
   �� -   'Chef_administrator.Properties.Resources   Add_Ingredient#��Z 6   $��392,56,336,605q�6A   $��24(�6Z   $
��Bold"�6h   $
 Hand��6z   �� 5   
      Title#��Z 6   $��132,151,824,263.6q�67   $��20(�6R   �� 5   
      Quantity#��Z 6   $��506,151,450,518q�6:   $��20(�6S   �� 5   
   -   5         ��Name$ textBoxName��5      $	��Top=�6'   $	��259��6?   $��20(�6K   $��55,212,766,0q�6Y   $ Arrow��6o   �� 5   
   -   5        $ textBoxWeight��5      $��482,208,426,472q�6*   $	��173��6C   $��20(�6O   �� 5   
   -   5        
   Add#��Z 5      $	��222��67   $��20(�6D   $��92,527,766,161q�6l   
��� � �6�   �� 5   
   -   5           Menu#��Z 5      $	��222��68   $��20(�6E   $��346,527,512,161q�6m   
��� � �6�   �� 5   
   -   5           Ingredients#��Z 5      $	��222��6?   $��20(�6L   $��92,475,766,213q�6u   
��� � �$
 Hand��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 	goodsGrid��5   /   
   AutoGenerateColumns
 .  $��746,339,42,57q�6B   $��2��6Y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header# Z 6>      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6d     5      # Z 6?   $	 200 6h    6%   �� *Count+6h   5      5      5      
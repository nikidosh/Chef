   M S B A M L   `   `   `  ����   Chef_administrator"    Chef_administrator.AddDishes   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    >d2http://schemas.microsoft.com/expression/blend/2008    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  	AddDishes��$	��720��$
��1080��.��� 
�������$	��720��$
��1080�� � RowDefinitions �� $	��28* ��� $	��17* �.+��� $&�� Добавление блюда:��$��392,56,437,343.6q�$��24(�$
��Bold"��� $��Вес:��$��392,151,590,255.6q�$��20(��� -    ��Name$ textBoxName��$	��Top=�$	��259��$��20(�$��55,212,766,0q��� -   $ textBoxWeight��$��392,208,515,199.6q�$	��173��$��20(��� -   $ textBoxPrice��$��596,208,311,199.6q�$	��173��$��20(��� -   $ textBoxCount��$��102,385,805,22.6q�$	��173��$��20(��� -    ��Name$ 	TypeList3��
��� � �$
��Left=�$��102,19.4,0,0q�$	��Top=�$	��173��$��18(�$��1��.@��� $��Картошка���� $��Капуста���� $��Помидор���� $��Свинина���� $��Сыр���� -   $ 	TypeList4��
��� � �$
��Left=�$��280,19.4,0,0q�$	��Top=�$	��192��$��18(�$��1��.@��� $��Картошка���� $��Филе куриное���� $��Капуста���� $��Помидор���� $��Огурец���� -   $ 	TypeList5��
��� � �$
��Left=�$��477,19.4,0,0q�$	��Top=�$	��192��$��18(�$��1��.@��� $��Картошка���� $��Филе куриное���� $��Капуста���� $��Помидор���� $��Огурец���� $��	Цена:��$��603,151,411,263.6q�$��20(��� $��Название:��$��132,151,824,263.6q�$��20(��� $��Количество:��$��132,330,824,84.6q�$��20(��� $��Категория:��$��368,330,588,84.6q�$��20(��� -	   $��Добавить��$	��222��$��20(�$��92,152.4,766,88q�
��� � �$��1���� -
   $��Меню��$	��222��$��20(�$��343,152,515,88q�
��� � �$��1���� -   $ TypeList��
��� � �$
��Left=�$��368,392,0,0q�$	��Top=�$	��240��$��18(�&   System.Windows.Controls.DataGrid  -     Name$ 	goodsGrid��   AutoGenerateColumns .  $��746,339,42,57q�$��2��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Название��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *Name+  $ Кол��$	 200 	 �� *Count+
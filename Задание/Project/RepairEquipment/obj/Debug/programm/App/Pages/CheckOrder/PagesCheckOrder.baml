   M S B A M L   `   `   `  ����J  FRepairEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:RepairEquipment.programm.App.Pages.CheckOrder-RepairEquipment.programm.App.Pages.CheckOrder  5      C    =RepairEquipment.programm.App.Pages.CheckOrder.PagesCheckOrder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:RepairEquipment.programm.App.Pages.CheckOrder     5        N� Title$  PagesCheckOrder��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $	��49* �6   �� 5      $
��363* �6   �� 5      $	��38* �6   .+�5   
   �� $��0��5      $��Center=�5       �� Orientation$ 
Horizontal=�5      $��10 0 0 0q�5      .+�5      �� $ 
Horizontal=�5      .+�5      �� $��34��5      $��55��5      
������� �� CornerRadius$ 4 0 0 4��5      ._�5      �� $ Vertical=�5       .+�5!      �� $��/res/image/User.png��5"      $��23��5#      5$      �� 5&      $��-5q�5'      $��Название��5(      $��Center=�5)      $��Center=�5*      $	��8px(�5+      $��Arial)�5,      $
��Bold"�5-      5.      5/      50      �� 52      $��34��53      $	��180��54      
�������$ 0 4 4 0��56      ._�57      �� -   5         ��Name$ CmdHomeTech��58      
������ 
������ $��Center=�5;      $��Center=�5<      $��Arial)�5=      $
��14px(�5>      $
��Bold"�5?      5@      5A      5B      �� 5D      -   5         ��Name$ 	BtnSearch��5E      $��34��5F      $	��134��5G      $��10 0 0 0q�5H      $��Right=�5I      
������� � Cursor$
 Hand��5K      .��5M      �� $��Center=�5N      $��Center=�5O      $ 
Horizontal=�5P      .+�5Q      �� $��/res/image/Ok.png��5R      $��12��5S      $��0 0 2 0q�5T      5U      �� 5W      $��
Поиск��5X      
���   �$
��12px(�5Z      $��Arial)�5[      5\      5]      5^      �� 5`      -   5        $ BtnClean��5a      $��34��5b      $	��134��5c      $��10 0 0 0q�5d      $��Right=�5e      
�������$
 Hand��5g      .��5i      �� $��Center=�5j      $��Center=�5k      $ 
Horizontal=�5l      .+�5m      �� $��/res/image/Ok.png��5n      $��12��5o      $��0 0 2 0q�5p      5q      �� 5s      $��Очистить��5t      
���   �$
��12px(�5v      $��Arial)�5w      5x      5y      5z      5{      &   System.Windows.Controls.DataGrid  5}   
   -   5          Name$ DtgTable��5~      $��1��5      $	��360��5�      $��Center=�5�      $	��Top=�5�      	   AutoGenerateColumns	 .  
   CanUserAddRows
 .     CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserResizeColumns .     
IsReadOnly . "   VerticalScrollBarVisibility$
 Auto=�5�      $   HorizontalScrollBarVisibility$ Visible=�5�         Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$# Создание заявки��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 135 6B      CellTemplate 5�      �� 5�      .R�5�      �� ��5�   !   �� *	StartDate+5�      5�      5�        5�      $ Тип техники��6)   $ * 6>    5�      �� 5�      .R�5�      �� ��5�   !   �� *HomeTech.Name+5�      5�      5�        5�      $ Модель��6)   $ * 69    5�      �� 5�      .R�5�      �� ��5�   !   �� *FirmModel.Model+5�      5�      5�        5�      $ Цвет��6)   $ 80 67    5�      �� 5�      .R�5�      �� ��5�   !   �� *
Color.Name+5�      5�      5�        5�      $ Подробнее��6)    5�      �� 5�      .R�5�      �� $ BtnEditOrder��5�   !   -   5        $��Подробнее��5�   !   $��20��5�   !   $
 Hand��5�   !   5�      5�      5�        5�      $ Удалить��6)    5�      �� 5�      .R�5�      �� $ BtnDeleteOrder��5�   !   -   5        $��Удалить��5�   !   $��20��5�   !   $
 Hand��5�   !   5�      5�      5�      5�      �� 5�   
   -   5        $ 	BtnUpdate��5�      $��2��5�      $��34��5�      $	��134��5�      $��Center=�5�      $��Center=�5�      
�������$
 Hand��5�      .��5�      �� $��Center=�5�      $��Center=�5�      $ 
Horizontal=�5�      .+�5�      �� $��/res/image/Ok.png��5�      $��12��5�      $��0 0 2 0q�5�      5�      �� 5�      $��Обновить��5�      
���   �$
��12px(�5�      $��Arial)�5�      5�      5�      5�      5�      5�      
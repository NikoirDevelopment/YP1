   M S B A M L   `   `   `  ����J  FRepairEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullw@clr-namespace:RepairEquipment.programm.App.SystemPagesAndWindows2RepairEquipment.programm.App.SystemPagesAndWindows  5   	   Q    KRepairEquipment.programm.App.SystemPagesAndWindows.WindowsCheckPasswordRoot   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Rlocal@clr-namespace:RepairEquipment.programm.App.SystemPagesAndWindows     5   	     � Title$%  Проверка доступа��5   	   $	��150��6"   $	��400��6/    � WindowStyle$ SingleBorderWindow=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��36* �6   �� 5      $	��57* �6   �� 5      $	��41* �6   .+�5   
   �� $��Center=�5      $��Center=�5      $��32��6(   $	��204��64   .+�5      �� $��0 5 0 0q�5      $4��.Введите пароль менеджера��5      $
��14px(�5      $
��Bold"�5      $��Arial)�5      5      5      �� 5   
   $��1��5       $��Center=�5!      $��Center=�5"       �� Orientation$ 
Horizontal=�5#      .+�5$      �� $��Пароль:��5%      $
��14px(�5&      $
��Bold"�5'      $��Arial)�5(      5)      G� 5+      -   5         G�Name$ PabCheckPassword��5,      $	��200��5-      
�������$��1 1 1 1q�5/      $
��10px(�50      $
��Left=�51      $��Center=�52       G� 	MaxLength$ 30��53      54      55      �� 57   
   -   5         ��Name$ BtnCheckPassword��58      $��2��59      $��26��5:      $	��100��5;      $
��ОК��5<      $��Arial)�5=      $
��14px(�5>      $
��Bold"�5?      5A      5B      5C      
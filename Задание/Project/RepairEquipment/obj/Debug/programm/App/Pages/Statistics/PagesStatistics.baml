   M S B A M L   `   `   `  ����J  FRepairEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:RepairEquipment.programm.App.Pages.Statistics-RepairEquipment.programm.App.Pages.Statistics  5      C    =RepairEquipment.programm.App.Pages.Statistics.PagesStatistics   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:RepairEquipment.programm.App.Pages.Statistics     5        N� Title$  PagesStatistics��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��290* �6   �� 5      $	��79* �6   �� 5      $	��81* �6   .+�5   
   �� -   5         ��Name$ 	BtnUpdate��5      $��2��5      $��34��5      $	��134��5      $��Center=�5      $��Center=�5      
������� � Cursor$
 Hand��5      .��5      �� $��Center=�5      $��Center=�5       �� Orientation$ 
Horizontal=�5       .+�5!      �� $��/res/image/Ok.png��5"      $��12��5#      $��0 0 2 0q�5$      5%      �� 5'      $��Обновить��5(      
���   �$
��12px(�5*      $��Arial)�5+      5,      5-      5.      &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ DtgApplicationHistory��52      $��0��51      $	��290��53         AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�55      	   CanUserReorderColumns	 .  
   
IsReadOnly
 .    Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5:         Header$ Клиент��5;      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5<      �� *User.Surname+  5=      $ * 5>      $ Исполнитель��5?       5@      �� *User.Surname+  5A      $ * 5B      $ Заявка��5C       5D      �� *Id+  5E      $ * 5F      $ Запчасти��5G       5H      �� *RepairParts+  5I      $	 120 5J      $ Дата начало��5K       5L      �� *	StartDate+ �� StringFormat$ 
dd.MM.yyyy��  5M      $	 120 5N      $# Дата заверщения��5O       5P      �� *ComplectionDate+$ 
dd.MM.yyyy��  5Q      $ * 5R      $ Статус��5S       5T      �� *Status.Name+5V      �� 5X   
   $��1��5Y      
���iii�.+�5[      �� $ 
Horizontal=�5\      .+�5]      �� $&�� Заявок выполнено:��5^      $
��12pt(�5_      5`      �� 5b      -   5         ��Name$ TxtTotal��5c      $
��10pt(�5d      $��Italic$�5e      $��количество��5f      $��5,0,0,0q�5g      5h      5i      �� 5k      $ 
Horizontal=�5l      .+�5m      �� $C��=Среднее время выполнения заявки: ��5n      $
��10pt(�5o      $��Center=�5p      5q      �� 5s      -   5        $ TxtTime��5t      $
��10pt(�5u      $��Italic$�5v      $��
время��5w      $��5,0,0,0q�5x      5y      5z      5{      5|      5}      
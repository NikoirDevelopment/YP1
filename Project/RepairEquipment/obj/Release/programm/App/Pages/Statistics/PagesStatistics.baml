   M S B A M L   `   `   `  ���� J  FRepairEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:RepairEquipment.programm.App.Pages.Statistics-RepairEquipment.programm.App.Pages.Statistics  C    =RepairEquipment.programm.App.Pages.Statistics.PagesStatistics   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Mlocal;clr-namespace:RepairEquipment.programm.App.Pages.Statistics       N� Title$  PagesStatistics�� N� 
Background
 �����.���  � RowDefinitions �� $
��290* ��� $	��79* ��� $	��81* �.+��� -    ��Name$ 	BtnUpdate��$��2��$��34��$	��134��$��Center=�$��Center=�
������� � Cursor$
 Hand��.���� $��Center=�$��Center=� �� Orientation$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $��Обновить��
���   �$
��12px(�$��Arial)�&   System.Windows.Controls.DataGrid  -     Name$ DtgApplicationHistory��$��0��$	��290��   AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�	   CanUserReorderColumns	 .  
   
IsReadOnly
 .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ *    Header$ Клиент��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *User.Surname+  $ * $ Исполнитель�� �� *User.Surname+  $ * $ Заявка�� �� *Id+  $ * $ Запчасти�� �� *RepairParts+  $	 120 $ Дата начало�� �� *	StartDate+ �� StringFormat$ 
dd.MM.yyyy��  $	 120 $# Дата заверщения�� �� *ComplectionDate+$ 
dd.MM.yyyy��  $ * $ Статус�� �� *Status.Name+�� $��1��
���iii�.+��� $ 
Horizontal=�.+��� $&�� Заявок выполнено:��$
��12pt(��� -    ��Name$ TxtTotal��$
��10pt(�$��Italic$�$��количество��$��5,0,0,0q��� $ 
Horizontal=�.+��� $C��=Среднее время выполнения заявки: ��$
��10pt(�$��Center=��� -   $ TxtTime��$
��10pt(�$��Italic$�$��
время��$��5,0,0,0q�
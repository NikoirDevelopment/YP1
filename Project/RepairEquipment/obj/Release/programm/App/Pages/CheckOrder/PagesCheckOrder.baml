   M S B A M L   `   `   `  ���� J  FRepairEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:RepairEquipment.programm.App.Pages.CheckOrder-RepairEquipment.programm.App.Pages.CheckOrder  C    =RepairEquipment.programm.App.Pages.CheckOrder.PagesCheckOrder   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Mlocal;clr-namespace:RepairEquipment.programm.App.Pages.CheckOrder       N� Title$  PagesCheckOrder�� N� 
Background
 �����.���  � RowDefinitions �� $	��49* ��� $
��363* ��� $	��38* �.+��� $��0��$��Center=� �� Orientation$ 
Horizontal=�$��10 0 0 0q�.+��� $ 
Horizontal=�.+��� $��34��$��55��
������� �� CornerRadius$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/User.png��$��23���� $��-5q�$��Название��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��180��
�������$ 0 4 4 0��._��� -    ��Name$ CmdHomeTech��
������ 
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"��� -    ��Name$ 	BtnSearch��$��34��$	��134��$��10 0 0 0q�$��Right=�
������� � Cursor$
 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $��
Поиск��
���   �$
��12px(�$��Arial)��� -   $ BtnClean��$��34��$	��134��$��10 0 0 0q�$��Right=�
�������$
 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $��Очистить��
���   �$
��12px(�$��Arial)�&   System.Windows.Controls.DataGrid  -     Name$ DtgTable��$��1��$	��360��$��Center=�$	��Top=�	   AutoGenerateColumns	 .  
   CanUserAddRows
 .     CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserResizeColumns .     
IsReadOnly . "   VerticalScrollBarVisibility$
 Auto=�$   HorizontalScrollBarVisibility$ Visible=�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$# Создание заявки��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 135    CellTemplate �� .R��� ���� *	StartDate+  $ Тип техники��$ *  �� .R��� ���� *HomeTech.Name+  $ Модель��$ *  �� .R��� ���� *FirmModel.Model+  $ Цвет��$ 80  �� .R��� ���� *
Color.Name+  $ Подробнее�� �� .R��� $ BtnEditOrder��-   $��Подробнее��$��20��$
 Hand��  $ Удалить�� �� .R��� $ BtnDeleteOrder��-   $��Удалить��$��20��$
 Hand���� -   $ 	BtnUpdate��$��2��$��34��$	��134��$��Center=�$��Center=�
�������$
 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $��Обновить��
���   �$
��12px(�$��Arial)�
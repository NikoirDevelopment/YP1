   M S B A M L   `   `   `  ���� J  FRepairEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:RepairEquipment.programm.App.Pages"RepairEquipment.programm.App.Pages  3    -RepairEquipment.programm.App.Pages.PagesUsers   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Blocal0clr-namespace:RepairEquipment.programm.App.Pages       N� Title$  	PagesUser�� N� 
Background
 �����.��� .+��� $��Center=�$	��Top=� �� Orientation$ Vertical=�.+�&   System.Windows.Controls.DataGrid  -     Name$ DtgTable��$	��370��$��Center=�$	��Top=�   AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .  	   CanUserResizeColumns	 .  
   
IsReadOnly
 . $   HorizontalScrollBarVisibility$ Disabled=�"   VerticalScrollBarVisibility$ Visible=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 56 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *id+  $ Имя��$	 117  �� *Name+  $ Фамилия��$	 117  �� *	Surname+  $ Отчество��$	 117  �� *
Patronymic+  $ Отношение��$ 76  �� *	Role.Name+4  .System.Windows.Controls.DataGridTemplateColumn  $ Подробнее��   CellTemplate �� .R���  ��Name$ BtnDetailUser��-   $��Подробнее��$��20�� � Cursor$
 Hand��  $ Удалить�� �� .R��� $ BtnDeleteUser��-   $��Удалить��$��20��$
 Hand���� -   $ 	BtnUpdate��$��34��$	��135��$��0 5 0 0q�
�������$
 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $��Обновить��
���   �$
��12px(�$��Arial)�
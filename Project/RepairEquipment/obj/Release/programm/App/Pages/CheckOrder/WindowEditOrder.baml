   M S B A M L   `   `   `  ���� J  FRepairEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:RepairEquipment.programm.App.Pages.CheckOrder-RepairEquipment.programm.App.Pages.CheckOrder  C    =RepairEquipment.programm.App.Pages.CheckOrder.WindowEditOrder   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Mlocal;clr-namespace:RepairEquipment.programm.App.Pages.CheckOrder       � Title$#  Изменение зявки��$	��448��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�$��4 4 4 4q�
�������.���  � ColumnDefinitions �� $
��263* ��� $
��383* � � RowDefinitions �� $	��19* ��� $	��45* ��� $	��11* �.+�� $��0��$��1��.+��� $��0 0 0 10q�$��Center=�$��Center=� �� Orientation$ Vertical=�.+��� $ 
Horizontal=�.+��� $��34��$��55��
������� �� CornerRadius$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/User.png��$��23���� $��-5q�$��Название��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��180��
�������$ 0 4 4 0��._��� -    ��Name$ CmdHomeTech��
������ 
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"��� $��0 10 0 0q�$ 
Horizontal=�.+��� $��34��$��55��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/User.png��$��23���� $��-5q�$��Модель��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��180��
�������$ 0 4 4 0��._��� -   $ CmdModelTechFactory��
������ 
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"��� $��0 10 0 0q�$ 
Horizontal=�.+��� $��34��$��55��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/User.png��$��23���� $��-5q�$��Цвет техники��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��180��
�������$ 0 4 4 0��._��� -   $ CmdTechColor��
������ 
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"��� -   	 ��Name$	 StcpTxbMaster��$��0 10 0 0q�$ 
Horizontal=�.+��� $��34��$��55��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/User.png��$��23���� $��-5q�$��Мастер��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��180��
�������$ 0 4 4 0��._��� -   $ 	CmdMaster��
������ 
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"��� $��0 10 0 0q�$ 
Horizontal=�.+��� $��34��$��55��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/User.png��$��23���� $��-5q�$��Статус��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��180��
�������$ 0 4 4 0��._��� -   $ CmdOrderStatus��
������ 
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�� $��2��$��0��.+��� $��0 5 0 0q�$%��Изменение заявки��$
��24px(�$��Arial)�$
��Bold"�$��Center=�$��Center=�� $��1��$��1��.+��� $ Vertical=�.+��� $��Center=�$��Center=�$ Vertical=�.+��� $��0 0 0 2q�$'��!Описание проблемы��$
��16px(�$��Arial)�$��Center=�$��Center=��� -   
 ��Name$
 TxbProblemeDescryption��$	��100��$	��300��
�������$��2 2 2 2q�
���iii�$��Arial)�$
��16px(� �� TextWrapping$
 Wrap=�" �� VerticalScrollBarVisibility$
 Auto=�.���� $��Center=�$��Center=�$ Vertical=�$��0 10 0 0q�.+��� $��0 0 0 2q�$)��#Выявленная причина��$
��16px(�$��Arial)�$��Center=�$��Center=��� -   $"
 TxbProblemeDescryptionMaster��$	��100��$	��300��
�������$��2 2 2 2q�
���iii�$��Arial)�$
��16px(�$
 Wrap=�$
 Auto=�.��� $��2��$��2��.+��� $��Center=�$	��Top=�$ 
Horizontal=�.+��� -	    ��Name$ BtnBack��$��34��$	��135��$��0 0 20 0q�
������� � Cursor$
 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $��Отмена��
���   �$
��12px(�$��Arial)��� -
   $ BtnCreateEdit��$��34��$	��135��
�������$
 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $#��Изменить заявку��
���   �$
��12px(�$��Arial)�
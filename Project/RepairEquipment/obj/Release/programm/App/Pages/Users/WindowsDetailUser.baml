   M S B A M L   `   `   `  ���� J  FRepairEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:RepairEquipment.programm.App.Pages.Users(RepairEquipment.programm.App.Pages.Users  @    :RepairEquipment.programm.App.Pages.Users.WindowsDetailUser   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Hlocal6clr-namespace:RepairEquipment.programm.App.Pages.Users       � Title$D  >Профиль пользователя: | Нет данных��$	��360��$	��410�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�$��4 4 4 4q�
���iii�
�������.���  � RowDefinitions �� $	��20* ��� $	��79* ��� $	��15* �.+��� $��0��$��Center=�$��Center=� �� Orientation$ Vertical=�.+��� $F��@Подробная информация пользователя��$
��14px(�$
��Bold"�$��Arial)��� -    ��Name$ TxbSurnameNameMiddlename��$��0 2 0 2q�$��Нет данных��$
��12px(�$
��Bold"�$��Arial)�$��Center=�$��Center=��� $��1��$��Center=�$��Center=�$ Vertical=�.+��� $��Center=�$��Center=�$ Vertical=�.+��� $��Center=�$��Center=�$ 
Horizontal=�.+��� $ 
Horizontal=�.+��� $��34��$��45��
������� �� CornerRadius$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/User.png��$��23���� $��-5q�$��
Логин��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -    ��Name$ TxbUser��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�	 �� 	MaxLength$	 20��.���� -   
 ��Name$
 StcpTxbMaster��$ 
Horizontal=�$��10 0 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/User.png��$��23���� $��-5q�$��Роль��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -    ��Name$ CmdRole��
�������
������ $��Center=�$��Center=�$��Arial)�$
��13px(�$
��Bold"��� $ 
Horizontal=�.+��� $��Center=�$��Center=�$ 
Horizontal=�$��0 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $*��$/res/image/NameSurnameMiddlename.png��$��23���� $��-5q�$��Имя��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ TxbName��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$	 50��.���� $��Center=�$��Center=�$ 
Horizontal=�$��10 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $*��$/res/image/NameSurnameMiddlename.png��$��23���� $��-5q�$��Фамилия��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ 
TxbSurname��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$	 50��.���� $ 
Horizontal=�.+��� $��Center=�$��Center=�$ 
Horizontal=�$��0 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $*��$/res/image/NameSurnameMiddlename.png��$��23���� $��-5q�$��Отчество��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ TxbMiddlename��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$	 50��.���� $��Center=�$��Center=�$ 
Horizontal=�$��10 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/Phone.png��$��23���� $��-5q�$��Телефон��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ TxbPhone��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$	 11��.���� $ 
Horizontal=�.+��� -	   $
 StcOdbPassword1��$��Center=�$��Center=�$ 
Horizontal=�$��0 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/Password.png��$��23���� $��-5q�$��Пароль��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._�G� -
    G�Name$ TxbOdbPassword1��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"� G� 	MaxLength$ 30���� -   $
 StcOdbPassword2��$��Center=�$��Center=�$ 
Horizontal=�$��10 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/Password.png��$��23���� $��-5q�$��Пароль��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._�G� -   $ TxbOdbPassword2��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$ 30���� $ 
Horizontal=�.+��� -   $
 StcPassword1��$��Center=�$��Center=�$ 
Horizontal=�$��0 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/Password.png��$��23���� $��-5q�$��Пароль��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ TxbPassword1��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$	 30��.���� -   $
 StcPassword2��$��Center=�$��Center=�$ 
Horizontal=�$��10 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/Password.png��$��23���� $��-5q�$��Пароль��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ TxbPassword2��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$	 30��.���� $��2��$��Center=�$��Center=�$ 
Horizontal=�.+��� -    ��Name$ BtnBack��$��34��$	��135��
������� � Cursor$
 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $��Отмена��
���   �$
��12px(�$��Arial)��� -   $ BtnEdit��$��34��$	��110��$��2.5 0 2.5 0q�
�������$
 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Edit.png��$��12��$��0 0 2 0q��� $��Изменить��
���   �$
��12px(�$��Arial)��� -   $ BtnSave��$��34��$	��135��
�������$
 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $��Сохранить��
���   �$
��12px(�$��Arial)�
   M S B A M L   `   `   `  ���� J  FRepairEquipment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:RepairEquipment.programmRepairEquipment.programm  '    !RepairEquipment.programm.PagesReg   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     8local&clr-namespace:RepairEquipment.programm       N� Title$  PagesRegistration��.���� 
���iii�._��  � RowDefinitions �� $
��143* ��� $
��154* ��� $	��40* ��� $	��43* �.+��� $��0��
�������._��� $��Center=�$��Center=� �� Orientation$ Vertical=�.+��� $	��100��$	��100��$��0 10 0 0q�
������� �� CornerRadius$	 100��._��� $)��#/res/image/Authorization_static.png��$��60���� $��0 8 0 5q�$��Регистрация��
�������$
��20px(�$��Arial)��� $��1��$��Center=�$��Center=�$ Vertical=�.+��� $��Center=�$��Center=�$ Vertical=�.+��� $ 
Horizontal=�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/User.png��$��23���� $��-5q�$��
Логин��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -    ��Name$ TxbUser��
������ 
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"� �� 	MaxLength$ 20��.���� $ 
Horizontal=�.+��� $��Center=�$��Center=�$ 
Horizontal=�$��0 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $*��$/res/image/NameSurnameMiddlename.png��$��23���� $��-5q�$��Имя��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ TxbName��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$ 50��.���� $��Center=�$��Center=�$ 
Horizontal=�$��10 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $*��$/res/image/NameSurnameMiddlename.png��$��23���� $��-5q�$��Фамилия��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ 
TxbSurname��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$ 50��.���� $ 
Horizontal=�.+��� $��Center=�$��Center=�$ 
Horizontal=�$��0 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $*��$/res/image/NameSurnameMiddlename.png��$��23���� $��-5q�$��Отчество��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ TxbMiddlename��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$ 50��.���� $��Center=�$��Center=�$ 
Horizontal=�$��10 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/Phone.png��$��23���� $��-5q�$��Телефон��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._��� -   $ TxbPhone��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$ 11��.���� $ 
Horizontal=�.+��� $��Center=�$��Center=�$ 
Horizontal=�$��0 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/Password.png��$��23���� $��-5q�$��Пароль��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._�G� -    G�Name$ TxbPassword1��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"� G� 	MaxLength$ 30���� $��Center=�$��Center=�$ 
Horizontal=�$��10 8 0 0q�.+��� $��34��$��45��
�������$ 4 0 0 4��._��� $ Vertical=�.+��� $��/res/image/Password.png��$��23���� $��-5q�$��Пароль��$��Center=�$��Center=�$	��8px(�$��Arial)�$
��Bold"��� $��34��$	��140��
�������$ 0 4 4 0��._�G� -   $ TxbPassword2��
�������
������ $��Center=�$��Center=�$��Arial)�$
��14px(�$
��Bold"�$ 30���� $��2��
�������._��� -    ��Name$ BtnOk��$��34��$	��135��
�������	 � Cursor$
	 Hand��.���� $��Center=�$��Center=�$ 
Horizontal=�.+��� $��/res/image/Ok.png��$��12��$��0 0 2 0q��� $��Регистрация��
���   �$
��12px(�$��Arial)��� -	   $ BtnAuth��$��34��$��95��$��3��
�������$��Авторизация��
�������$
��12px(�$��Arial)�$
	 Hand��
   M S B A M L   `   `   `  ���� @  <Maths, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MathsMaths      Maths.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   !localclr-namespace:Maths     � Title$  
MainWindow��$	��720��$
��1080�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������ .���� -    ��Name$ 
MainBorder�����#e6ecf5 �� CornerRadius$ 30��._��  � ColumnDefinitions �� $	��190 ��� $��* �.+��  � RowDefinitions �� $
��auto ��� $��* �.+��� $��
10 60 0 35q� �� Orientation$ 
Horizontal=�$��Center=��� $��1�����#426dc2$ 	0 50 0 30��._�]� .+��� $��80��$��80��	 �� Padding$	 3q�
�������$	 100��$	��Top=�$
��Left=�$��
20 -30 0 0q�._�A� ���� 
 �� ImageSource$,
 &pack://application:,,,/Images/Logo.png���� $��Maths��
�������$��22(�$��SemiBold"�$	��Top=� �� TextAlignment$ Center=�$��	5 25 0 10q��� $��Moscow, Kulakov Street�����#bfe0ff$��14(�$��SemiBold"�$	��Top=�$ Center=��� $��25q�$	��Top=�$	��0.8�����#7e5fdc�� $	��Top=�.+��� -      
menuButton#��[   � Cursor$
 Hand��.���� $ 
Horizontal=�.+�.  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Home=�  menuButtonIcon#��[ �� $��Главная���� -   #��[  $
 Hand��.���� $ 
Horizontal=�.+�  $ BookOpenVariant=�#��[ �� $��Справочник���� -   #��[  $
 Hand��.���� $ 
Horizontal=�.+�  $ 
Calculator=�#��[ �� $%��Решение примеров���� -   #��[  $
 Hand��.���� $ 
Horizontal=�.+�  $ NoteText=�#��[ �� $��Решение задач���� -   #��[  $
 Hand��.���� $ 
Horizontal=�.+�  $ FunctionVariant=�#��[ �� $'��!Решение уравнений���� -    ��Name$ Button_Administration��$y�Hidden=�#��[  $
 Hand��.���� $ 
Horizontal=�.+�  $ TuneVariant=�#��[ �� $��Управление���� -   #��[  $��Bottom=�$��Bottom=�$��
10 5 15 20q�$
 Hand��.���� $ 
Horizontal=�.+�  $ Logout=�#��[ �� $��
Выход���� -	    ��Name$ textTime��$��15:20��$	��Top=�$��114,10,-14,0q�$	��Top=�$��20(�$��SemiBold"����#bfe0ff$��1��$��42��� $��1��$��30 20 20 20q� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $
��auto �.+���   	topButton#��[ $��0 0 20 0q����#dcdcdc$��Right=�$
 Hand��.��  $	 Cog=��� -
   #��[ $��0 0 60 0q�$��Right=�$
 Hand��.���� -    ��Name$ Image_Style��$,��&pack://application:,,,/Images/Moon.png���� -   $ 	TitleText��$%��Главная страница��$��1��$��32(�$��SemiBold"�$��0 20 0 0q�$
��Left=����#4A4A4A � -     �Name$ Frame_W��$��
-5,120,0,0q�  � NavigationUIVisibility$ Hidden=�$��1������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ #e6ecf5�� � Offset$ 0.004Q�� $ #426dc2��$ 0.939Q��� -    ��Name$ MainSeparator��$��-5,110,250,585q�$	��Top=�$	��1.5�����	#FF5A87E0$��1�� J� Opacity$	 0.3Q�
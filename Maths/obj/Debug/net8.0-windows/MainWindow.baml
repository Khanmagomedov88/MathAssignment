   M S B A M L   `   `   `  ����@  <Maths, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MathsMaths  5   	       Maths.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a;Icons-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   !localclr-namespace:Maths   5   	     � Title$  
MainWindow��5	   	   $	��720��6   $
��1080��6)    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6[    � AllowsTransparency$
 True��5
   	   
������ .��5      �� -   5         ��Name$ 
MainBorder��5      ���#e6ecf5 �� CornerRadius$ 30��66   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��190 �6#   �� 5      $��* �6#   .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      �� $��
10 60 0 35q�6    �� Orientation$ 
Horizontal=�61   $��Center=�6J   5      �� 5       $��1��6   ���#426dc2$ 	0 50 0 30��6;   ._�5!      ]� .+�5"      �� $��80��6!   $��80��6,   	 �� Padding$	 3q�68   
�������$	 100��6[   $	��Top=�5#      $
��Left=�6*   $��
20 -30 0 0q�6E   ._�5$      A� ��5%   "   �� 5&   &   
 �� ImageSource$,
 &pack://application:,,,/Images/Logo.png��61   5(      5)      �� 5/      $��Maths��6$   
�������$��22(�6D   $��SemiBold"�6R   $	��Top=�50       �� TextAlignment$ Center=�6-   $��	5 25 0 10q�6D   �� 51      $��Moscow, Kulakov Street��6$   ���#bfe0ff$��14(�6W   $��SemiBold"�6e   $	��Top=�52      $ Center=�6-   �� 55      $��25q�6$   $	��Top=�60   $	��0.8��6E   ���#7e5fdc6R   �� 59      $	��Top=�6%   .+�5:      �� -   5           
menuButton#��[  5:   %    � Cursor$
 Hand��6I   .��5;   "   �� $ 
Horizontal=�6-   .+�5<   &   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Home=�6=     menuButtonIcon#��[ 6I   �� 5=   &   $��Главная��60   5>   #   5?      �� 5A      -   5        #��[  5A   %   $
 Hand��6I   .��5B   "   �� $ 
Horizontal=�6-   .+�5C   &     $ BookOpenVariant=�6=   #��[ 6T   �� 5D   &   $��Справочник��60   5E   #   5F      �� 5H      -   5        #��[  5H   %   $
 Hand��6I   .��5I   "   �� $ 
Horizontal=�6-   .+�5J   &     $ 
Calculator=�6=   #��[ 6O   �� 5K   &   $%��Решение примеров��60   5L   #   5M      �� 5O      -   5        #��[  5O   %   $
 Hand��6I   .��5P   "   �� $ 
Horizontal=�6-   .+�5Q   &     $ NoteText=�6=   #��[ 6M   �� 5R   &   $��Решение задач��60   5S   #   5T      �� 5V      -   5        #��[  5V   %   $
 Hand��6I   .��5W   "   �� $ 
Horizontal=�6-   .+�5X   &     $ FunctionVariant=�6=   #��[ 6T   �� 5Y   &   $'��!Решение уравнений��60   5Z   #   5[      �� 5]      -   5         ��Name$ Button_Administration��5]   %   $y�Hidden=�6D   #��[  6X   $
 Hand��6|   .��5^   "   �� $ 
Horizontal=�6-   .+�5_   &     $ TuneVariant=�6=   #��[ 6P   �� 5`   &   $��Управление��60   5a   #   5b      5d      �� 5f      -   5        #��[  5f   !   $��Bottom=�6E   $��Bottom=�6`   $��
10 5 15 20q�6x   $
 Hand��6�   .��5h      �� $ 
Horizontal=�6)   .+�5i   "     $ Logout=�69   #��[ 6G   �� 5j   "   $��
Выход��6,   5k      5l      5n      5p      �� 5q      -	   5         ��Name$ textTime��5q   )   $��15:20��6   $	��Top=�6;   $��114,10,-14,0q�6S   $	��Top=�6i   $��20(�6~   $��SemiBold"�5r      ���#bfe0ff$��1��6;   $��42��6H   5s      � 5u      $��1��6   $��30 20 20 20q�6#    5v      �� 5w      $
��auto �6$   �� 5x      $
��auto �6$   �� 5y      $
��auto �6$   �� 5z      $
��auto �6$   �� 5{      $��* �6$   �� 5|      $
��auto �6$   .+�5~      ��   	topButton#��[ 6   $��0 0 20 0q�6<   ���#dcdcdc$��Right=�6c   $
 Hand��6   .��5        $	 Cog=�6-   5�      �� 5�      -
   5        #��[ 5�      $��0 0 60 0q�6<   $��Right=�6N   $
 Hand��6j   .��5�      �� -   5         ��Name$ Image_Style��5�      $,��&pack://application:,,,/Images/Moon.png��61   5�      �� 5�      -   5        $ 	TitleText��5�      $%��Главная страница��6/   $��1��6G   $��32(�6T   $��SemiBold"�6b   $��0 20 0 0q�6x   $
��Left=�5�      ���#4A4A4A6   5�       � 5�      -   5          �Name$ Frame_W��5�      $��
-5,120,0,0q�6%     � NavigationUIVisibility$ Hidden=�69   $��1��6Y   ��5�      �� 5�       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5�      �  � Color$ #e6ecf5��6'    � Offset$ 0.004Q�67   � 5�      $ #426dc2��6'   $ 0.939Q�67   5�      5�      �� 5�      -   5         ��Name$ MainSeparator��5�      $��-5,110,250,585q�6/   $	��Top=�6G   $	��1.5��6\   ���	#FF5A87E0$��1��6�    J� Opacity$	 0.3Q�6�   5�      5�      5�      
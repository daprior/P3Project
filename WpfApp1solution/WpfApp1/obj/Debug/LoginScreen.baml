   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.LoginScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $	��900��6   $
��1600��6$   $��14(�61   ���	#FF6AB1CF.��5      �� ���#2e3137 �� CornerRadius$ 20��6"   $��20q�64   ._�5   
   �  � ColumnDefinitions 5   
   �� 5      $	��200 �6#   61   �� 5      $��* �6#   6/   �� 5      $	��200 �6#   61    � RowDefinitions 5      �� 5      $	��100 �6    �� 5      $	��150 �6    �� 5      $��50 �6    �� 5      $	��150 �6    �� 5      $��50 �6    �� 5      $��* �6    .+�5      �� $��Login��6   
����ح�$��75(�6;   $��Center=�6I   $��0��6m   $��1��6z   $��Center=�6�   $	��150��6�   $��0 0 0 0q�6�   $��Center=�6�   �� 5       $��Username��6   
�������$��25(�6:   $��Center=�6H   $��Center=�6j   $��Center=�6�   $��1��6�   $��1��6�   �� 5"      -   5         ��Name$ txtUsername��5"      $��100 0q�6+   $��22(�6:   $��2q�6I   
�������
�������$��2��6�   $��1��6�    �� TextAlignment$ Center=�6�   �� 5$      $��Password��6   
�������$��25(�6:   $��Center=�6H   $��3��6l   $��1��6y   $��Center=�6�   �� 5&      -   5        $��txtPassword��5&      $��100 0q�6)   $��22(�68   $��2q�6F   
�������
�������$��4��6�   $��1��6�   $ Center=�6�   �� 5(      -   5         ��Name$ 	btnSubmit��5(      $��Submit��6(   
���   �$��18(�6d   
�������
�������$��35��6�   $��5��6�   $��1��6�   $	��300��6�   �� 5+      $	��100��6   $
��Left=�6%   .+�5,      �� -   5        $ BtnExit��5,   �   $��
40,10,10,0q�6    &  "MaterialDesignFloatingActionButton#��[  6-   ���	#FF6AB1CF
������� � ToolTip$ Close��6�   $��45��6�   $
��Auto��6�   .��5-      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   $��30��6;   $��30��6F   5/      51      53      54      55      
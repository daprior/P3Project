   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  5   	   -clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	   7 clr-namespace:WpfApp1.ConvertersWpfApp1.Converters  5	   	       WpfApp1.TableMenuForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   7
viewmodels clr-namespace:WpfApp1.ViewModels     5   	   -viewsclr-namespace:WpfApp1.Views     5   	   7
Converters clr-namespace:WpfApp1.Converters     5	   	     � Title$  TableMenuForm��5   	   $	��900��6   $
��1600��6,   ���	#FF6AB1CF � 	Resources 5      ��%    5      .��5      �  5   
   2   ,WpfApp1.Converters.ByteArrayToImageConverter   ByteArrayToImageConverter��%   &	          5      63   5       � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   �� 5      $	��150 �6   .+�5"   
   �� -   5        $��CallWaiterButton��5"   �   $��4��6   $��0��6   $��1��6.   $��1��6?   ���#2e3137$
��Auto��6h   $��10,10,10,10q�6v   $��Call waiter��6�   $��20(�6�   
�������6�   �� 5&   
   $��	0 10 10 0q�6   ���#2e3137
�������$��Order��6K   $��Apple Braille)�6[   $��40(�6v   $��Center=�6�   $��Center=�6�   $��0��6�   $��4��6�   $��1��6�   $��1��6�   6  &   System.Windows.Controls.DataGrid  5(   
   -   5        $��	orderGrid��5(   �   $��0 0 10 0q�6   $��1��6%   $��4��62   $��1��6B   $��3��6S      
IsReadOnly . ���#525252
���������6g   �� *
OrderTable+   Columns 5*      4  .System.Windows.Controls.DataGridTemplateColumn  5+         CellTemplate 5,      �� 5-      .R�5.      �� $��	btnRemove��6%   -   5        $��Remove��5.   6   $��0q�6o   ���#2e3137
�������
 � Tag 6G   �� 6�   5/      51      53      �� 56   
   -   5        $��4��56      $��4��6   $��1��6.   $��1��6?   ���#2e3137$
��Auto��6h   $��10,10,10,10q�6v   $��Proceed��6�   $��20(�6�   
�������6�     59   
   -   5        $��dataGrid��59   '   $��
10 10 10 0q�6      AutoGenerateColumns .  	   CanUserAddRows	 .  $��Stretch=�5:      $��Stretch=�6,   
   RowBackground
 �#525252$
��Bold"�5;   %   
����������#525252��. $	��800��5<   2      AlternatingRowBackground �#525252���#000$��1q�5=   C   $��Visible=�5>      $
��Auto=�5?      $��0��6=   $��0��6J   $��2��6Z   $��2��6k   ��6   �� *	MenuTable+ 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ��  �� Path$
 name�6S     5B      $ Price��6%    .  64   �� $ price�6U     5C         Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 6)      MinWidth$ 64Q�65    5D      �� 5E      .R�5F      �� ��6$   �� *img+ �� 	Converter# [  5G      5I        5J      $	 Add��6)    5K      �� 5L      .R�5M      �� $��btnAddToOrder��6%   -   5        $	��Add��5M   J   ���#2e3137
�������$��0q�6�    6:   �� 6�   5N      5P      5R      5S      5T      
   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5      7 clr-namespace:WpfApp1.ConvertersWpfApp1.Converters  5      !    WpfApp1.Views.AdminMenuView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Views     5      7
Converters clr-namespace:WpfApp1.Converters     5      
�������.��5
      �   � 	Resources  5   
   2   ,WpfApp1.Converters.ByteArrayToImageConverter   ByteArrayToImageConverter��%   &	          5      63   5       � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      $	��200 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��40 �6   6*   �� 5      $��50 �6   6*   �� 5      $��40 �6   6*   �� 5      $��50 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $	��150 �6   6+   �� 5      $��* �6   6)   .+�5   
   �� 
���   �$��	Food Name��6#   $��Center=�67   $��Center=�6[   $��15(�6}   $��0��6�   $��2��6�   �� 5    
   -   5        $��txtFoodName��5       $��20(�6%   ���#2e3137$��2q�6H   
�������$��1��6p   $��2��6}   
�������$��Center=�6�   $��Center=�6�   �� 5!   
   
���   �$��Price��6#   $��Center=�63   $��Center=�6W   $��15(�6y   $��2��6�   $��2��6�   6�   �� 5"   
   -   5        $��txtPrice��5"      ���#2e3137$��2q�68   
�������$��3��6`   $��2��6m   $��Center=�6�   $��Center=�6�   
�������$��20(�6�   6�   �� 5$   
   -   5        $��4��5$      $	��Add��6   
�������$��2q�6>   
�������$��Center=�6~   $��	50 0 50 0q�6�   $��Center=�6�   $��2��6�   6�   �� 5%   
   -   5        $��5��5%      $��Delete��6   
�������$��2q�6A   
�������$��Center=�6~   $��	50 0 50 0q�6�   $��2��6�   �� 5'   
   -   5        $��6��5'      $��Browse��6   
�������$��2q�6A   
�������$��Center=�6~   $��	50 0 50 0q�6�   $��2��6�   �� 5(   
   -   5        $��image1��5(      $��7��6   $
��Fill=�6+   $��2��6:   $��75 10 75 10q�6N   &   System.Windows.Controls.DataGrid  5*   
   -   5        $��dtGrid��5*   L   $��9��6   $��2��6$   ��64   ��    Columns 5,      4  .System.Windows.Controls.DataGridTemplateColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Image��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 68      MinWidth$ 64Q�6D      CellTemplate 5.      �� 5/      .R�50      �� ��6$   �� *img+ �� 	Converter# [  51      53      56      57      58      
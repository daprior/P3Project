   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  5   	   -clr-namespace:WpfApp1.ViewsWpfApp1.Views  5   	       WpfApp1.KitchenForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   7
viewmodels clr-namespace:WpfApp1.ViewModels     5   	   -viewsclr-namespace:WpfApp1.Views     5   	     � Title$  KitchenForm��5
   	   $	��900��6   $
��1600��6*   ���	#FF6AB1CF.��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��* �6   6)   .+�5   
   �� $��1��69   ��6   �� *	AllOrders+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   5      ��5      �� 5      .R�5      � $	��250��6   
�������$��5 0 0 0q�69    5      �� 5      $��* �6,   �� 5      $��50 �6,   �� 5       $��50 �6,   �� 5!      $��50 �6,   .+�5#      �� $��1q�6#   
���   �
���   �$��Center=�6|   $��Center=�6�   ��6^   �� *Names+5$      �� 5%      $��1q�6    
���   �$��1��6H   
�������$��Table:��6h   
�������$��Center=�6�   $��Center=�6�   6�   �� 5&      $��1q�6    
���   �$��2��6H   
�������
�������$��Center=�6�   $��Center=�6�   ��6h   ��  �� Path$ UserId�6�   �� 5'      $��Remove��6V   -   5        $��1q�5'   !   
���   �$��3��6I   $��Remove��6y   5)      5*      5+      5-      �� 5/   
   $��0��6   $��
All orders��6   
���   �$��20(�6E   $��Center=�6S   $��Center=�6u   6�   50      52      
   M S B A M L   `   `   `  ����?  ;zad5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:zad5zad5  5   	       zad5.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:zad5     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $	��120 �6   �� 5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      �� 5      $��30 �6   .+�5   
   �� $��Пример 4��6   $��0��6$   $��1��61   $��Center=�6A   $��Center=�6^   $��18��6y   $��	2,6,116,6q�6�   $��56��6�   �� 5   
   -   5         ��Name$ TextBlockAnswer��5      $��Ответ: ��6-   $��3��6<   $��0��6I   $��2��6Y   $��Stretch=�6m   $��Stretch=�6�   $��10q�6�   �� 5   
   $��4��6   $��0��6"   $��2��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   $
��61,0q�6|   $	��172��6�   .+�5      �� -   5         ��Name$ BtnOK��5      $��OK��6$   $��80��61   $��24��6<   $��3q�6H   ���	#FF3985B0
������� �� 	IsDefault . 6�   �� 5      -   5        $ 	BtnCancel��5      $��Cancel��6(   $��80��69   $��24��6D   $��3q�6P   ���	#FF3985B0
������� �� IsCancel . 6�   5      5       5!      
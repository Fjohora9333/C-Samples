   M S B A M L   `   `   `  ����O  KZisa_pennies_for_pay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Zisa_pennies_for_payZisa_pennies_for_pay  5   	   %    Zisa_pennies_for_pay.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Zisa_pennies_for_pay     5   	     � Title$  Pennies For Pay��5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $��2* �6   6*   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   ��5   
   �� 5       �� ImageSource$ 
images.jpg��6    �� Opacity$ .4Q�62   6A   .+�5   
   ]� $��2��6   .+�5      �� $��Pennies for pay ��6   $��40(�6/   $��Center=�6=   6\   5      �� 5   
   $��0��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Bottom=�6O   .+�5      �� $��Enter Number of workdays=��6   $��30(�68   $��50��6F   $	��550��6R   $��Right=�6^   $
��10 5q�6�   6�   �� 5      -   5        $��TxtDayNumber��5      $��30(�6*   $��50��68   $	��150��6D   ��6P   �� *Day+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5      �� 5   
   -   5        $��LbResult��5      $��1��6    $��2��6-   $��50��6A   $��Center=�6h   $��30(�6�   ��6M   �� *Result+6�   �� 5   
   -   5        $��BtnSave��5      $��2��6    $��0��6-   $��50��6=   $	��150��6I   $
��Save��6U   $��30(�6d   
�������$y�Hidden=�6�   6�   �� 5   
   -   5        $��BtnClear��5      $��2��6!   $��1��6.   $��50��6>   $	��150��6J   $��Clear��6V   $��30(�6f   
�������6�   �� 5    
   -   5        $��BtnCalculate��5       $��2��6%   $��0��62   $��50��6B   $	��150��6N   $��	Calculate��6Z   $��30(�6n   
�������6�   5"      5#      
   M S B A M L   `   `   `  ����X  TZisa_Change_for_a_doller_game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Zisa_Change_for_a_doller_gameZisa_Change_for_a_doller_game  5   	   .    (Zisa_Change_for_a_doller_game.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:Zisa_Change_for_a_doller_game     5   	     � Title$  
DollerGame��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   6)   �� 5      $	��.5* �6   6+   �� 5      $��* �6   6)   �� 5      $��2* �6   6*    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��4��6   $��Please enter your guess��61   $��30(�6S   6c   �� 5   
   $��1��6   $��Pennies��6   $��30(�6/   6?   �� 5   
   $��1��6   $��1��6   $��Nickles��6-   $��30(�6?   6O   �� 5   
   $��1��6   $��2��6   $��Dimes��6-   $��30(�6=   6M   �� 5   
   $��1��6   $��3��6   $��Quarter��6-   $��30(�6?   6O   �� 5   
   $��2��6   $��50��6   $	��150��6h   $��30(�6t   ��6+   �� *Pennie+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��2��6   $��1��6   $��50��6/   $	��150��6x   $��30(�6�   ��6;   �� *Nickle+$ PropertyChanged=�6�   �� 5   
   $��2��6   $��2��6   $��50��6/   $	��150��6w   $��30(�6�   ��6;   �� *Dimes+$ PropertyChanged=�6�   �� 5   
   $��2��6   $��3��6   $��50��6/   $	��150��6y   $��30(�6�   ��6;   �� *	Quarter+$ PropertyChanged=�6�   �� 5   
   $��3��6   $��4��6"   .+�5       �� -   5        $��Result��5       $��30(�6=   $��50��6K   $��5q�6W   ��6"   �� *Result+6d   �� 5!      -   5        $��	BtnSubmit��5!      $��Submit��6&   $	��150��67   $��20(�6C   $��5q�6R   6w   �� 5"      -   5        $��BtnAgain��5"      $��Again��6%   $	��150��65   $��20(�6B   $��5q�6P   6t   5%      5&      5'      
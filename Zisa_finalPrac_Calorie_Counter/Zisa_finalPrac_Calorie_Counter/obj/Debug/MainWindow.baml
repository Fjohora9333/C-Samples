   M S B A M L   `   `   `  ����Y  UZisa_finalPrac_Calorie_Counter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Zisa_finalPrac_Calorie_CounterZisa_finalPrac_Calorie_Counter  5   	   /    )Zisa_finalPrac_Calorie_Counter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Zisa_finalPrac_Calorie_Counter     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��2* �6   6*   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��BtnApple��5      $��	50 5 25 5q�6%   .��5      �� $��images/AppleCalories.bmp��6   6=   5      �� 5      -   5        $��	BtnBanana��5      $
��25 5q�6&   .��5      �� $��images/BananaCalories.bmp��6   6>   5      �� 5      -   5        $��	BtnOrange��5      $
��25 5q�6'   .��5      �� $��images/OrangeCalories.bmp��6   6>   5      �� 5      -   5        $��BtnPear��5      $
��25 5q�6$   .��5      �� $��images/PearCalories.bmp��6   6<   5      5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5      �� -   5        $��LbNumOfApple��5      $��25(�6(   $��5q�66   ��6A   �� *
NumOfApple+6b   �� 5       -   5        $��LbNumOfBanana��5       $��25(�6)   $��5q�67   ��6B   �� *NumOfBanana+6d   �� 5!      -   5        $��LbNumOfOrange��5!      $��25(�6)   $��5q�67   ��6B   �� *NumOfOrange+6d   �� 5"      -   5        $��LbNumOfPear��5"      $��25(�6'   $��5q�65   ��6@   �� *	NumOfPear+6`   5#      �� 5$   
   -	   5        $��LbTotalCalorie��5$      $��2��6&   $��25(�63   $��5q�6A   ��6L   �� *TotalCalorie+6o   �� 5%   
   -
   5        $��BtnClear��5%      $��3��6   $��Clear��6.   $��50��6>   $��25(�6J   $	��200��6X   6}   5&      5'      
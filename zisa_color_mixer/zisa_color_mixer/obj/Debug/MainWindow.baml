   M S B A M L   `   `   `  ����K  Gzisa_color_mixer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:zisa_color_mixerzisa_color_mixer  5   	   !    zisa_color_mixer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:zisa_color_mixer     5   	     � Title$  Color Mixer��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $��3* �6   6*   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��RecOutputColor��5      $��0��6*   
���   �$��3��6F   $��5q�6Z   6g   �� 5   
   -   5        $��SldRed��5      $��1��6   
���  �� � Maximum$	 255Q�6=    � Minimum$ 0Q�6K    �� IsSnapToTickEnabled . $
��10 5q�5   ,   $��40��6:   $	��600��6F   $
��Left=�6R   6o   �� 5   
   -   5        $��SldGreen��5      $��2��6!   
��� � �$	 255Q�6A   $ 0Q�6O    . $
��10 5q�5   ,   $��40��6:   $	��600��6F   $
��Left=�6R   6o   �� 5   
   -   5        $��SldBlue��5      $��3��6    
����  �$	 255Q�6?   $ 0Q�6M    . $
��10 5q�5   ,   $��40��6:   $	��600��6F   $
��Left=�6R   6o   �� 5   
   -   5        $��TxtRed��5      $��1��6    $��Right=�6-   $��40��6I   $	��150��6U   $��30(�6a   $
��Left=�6o   $��Center=�6�   ��5      ��  �� ElementName$ SldRed�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $��TxtGreen��5      $��2��6"   $��Right=�6/   $��40��6K   $	��150��6W   $��30(�6c   $
��Left=�6q   $��Center=�6�   ��5      �� $ SldGreen��$ Value�$ PropertyChanged=�6�   �� 5    
   -   5        $��TxtBlue��5       $��3��6!   $��Right=�6.   $��40��6J   $	��150��6V   $��30(�6b   $
��Left=�6p   $��Center=�6�   ��5!      �� $ SldBlue��$ Value�$ PropertyChanged=�6�   �� 5"   
   -   5        $��BtnReset��5"      $��4��6!   $��Reset��6.   $��40��6>   $	��150��6J   $��30(�6V   6}   5#      5$      
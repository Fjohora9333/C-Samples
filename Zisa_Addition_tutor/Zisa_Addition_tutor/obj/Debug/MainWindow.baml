   M S B A M L   `   `   `  ����N  JZisa_Addition_tutor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Zisa_Addition_tutorZisa_Addition_tutor  5   	   $    Zisa_Addition_tutor.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Zisa_Addition_tutor     5   	   -   5          � Title$  Addition Tutor��5	   	   $	��450��6    $	��800��6-   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��LbTitle��5      $��0��6   $��Center=�6F   $��Center=�6j   $��30(�6�   $
��10 5q�6�   ��6,   �� *Title+6�   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� $��30(�6   $
��Left=�6"   $��Right=�6=   $��50��6}   $	��500��6�   $
��10 5q�6�   ��6`   �� *
Question+6�   �� 5      -   5        $��	TxtAnswer��5      $��30(�6'   $��50��65   $	��150��6A   $��Right=�6M   $
��20 5q�6�   ��6i   �� *Answer+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5      �� 5   
   -   5        $��LbResult��5      $��2��6    $��30(�6-   $��10q�6;   $��Center=�6G   $��Center=�6�   ��6k   �� *Result+6�   �� 5   
   $��3��6   $ 
Horizontal=�6#   .+�5      �� -   5        $��BtnViewResult��5      $��50��6*   $	��200��66   $��View Result��6B   $��30(�6X   $
��Left=�6�   $
��50 5q�6�   6�   �� 5      -   5        $��BtnNewProblem��5      $��50��6*   $	��200��66   $��New Problem��6B   $��30(�6X   $��Right=�6�   $
��50 5q�6�   6�   5      5      5      
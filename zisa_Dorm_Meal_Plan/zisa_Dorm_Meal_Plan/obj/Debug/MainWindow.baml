   M S B A M L   `   `   `  ����N  Jzisa_Dorm_Meal_Plan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:zisa_Dorm_Meal_Planzisa_Dorm_Meal_Plan  5   	   $    zisa_Dorm_Meal_Plan.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:zisa_Dorm_Meal_Plan     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5       � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $��2* �6   6*   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��2��6#   $��0,0,0.333,0q�67   .+�5      �� $��20(�6   $��Select a Dormetory��6"   
�������6T   �� 5      ��6   �� *Dorms+ �� SelectedItem 65   �� *SelectedDorm+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��20(�6A   ��6$   �� *
DormName+6Q   �� 5      $��20(�6C   ��6$   �� *
DormCharge+6S   5      5      5      5      �� 5    
   $��1��6   $��2��6#   $��0,0,0.333,83.667q�67   $��2��6Q   .+�5!      �� $��20(�6   $��Select a Meal Plan��6"   
�������6T   �� 5"      ��6   �� *	MealPlans+ 69   �� *SelectedMealPlan+��5#      �� 5$      .R�5%      �� $ 
Horizontal=�6%   .+�5&      �� $��20(�6E   ��6$   �� *MealPlanName+6U   �� 5'      $��20(�6G   ��6$   �� *MealPlanCharge+6W   5(      5)      5+      5,      �� 5-   
   -   5        $��BtnCalcTotal��5-      $��2��6%   $��Calculate Total Charge��62   $��20(�6S   $��50��6a   $	��300��6m   $��2��6�   $��247,17.333,246.333,16.667q�6�   6�   5.      5/      
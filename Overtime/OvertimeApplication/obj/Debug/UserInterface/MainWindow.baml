   M S B A M L   `   `   `  ����N  JOvertimeApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:OvertimeApplicationOvertimeApplication  5   	   $    OvertimeApplication.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:OvertimeApplication     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $��467.907��6   $	��350��6(    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $��Segoe UI Emoji)�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��31* �6   �� 5      $
��219* �6   .+�5   
   �� $	��300��6   $	��Top=�6   $:��4/OvertimeApplication;component/Assets/overtimebg.jpg��65   $��2��6s   �� 5   
   $	��280��6   $	��223��6    $��Bottom=�6-   $��
35,0,35,80q�6H    �� RadiusY$ 10��6\    �� RadiusX$ 10��6i   
�������$��1��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#   	   	Direction$	 0Q�63   
   RenderingBias$
 Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      � 5   
   $��Bottom=�6   $��
35,0,35,80q�6*   $	��240��6>   $��1��6K   .+�5      �� $��Overtime Login��6   $��Center=�6-   $	��Top=�6J   $��
72,24,74,0q�6b   
�������$��18(�6�   $	��134��6�   �� 5      $��Center=�6   $��15q�64   .+�5      �� -   5         ��Name$ textbox_email��5      $
��0,10q�61   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ EMAIL��6?    %  !MaterialDesignFloatingHintTextBox#��[  6f   $��Champagne & Limousines)�6�   $��18(�6�   G� 5      -   5         G�Name$ passwordbox_email��5      $
��0,10q�69   $ PASSWORD��6G    ) %MaterialDesignFloatingHintPasswordBox#��[ 6q   $��Champagne & Limousines)�6�   $��18(�6�   �� 5       $��Remember Me��6   $	��Top=�61   5!      5"      �� 5#   
   -   5        $	��150��5#      $��Center=�6   $��Bottom=�6:   $��100,0,100,65q�6U   $��LOGIN��6k   $��1��6�   �� 5$   
   $��FORGET PASSWORD?��6   $��Center=�6,   $��Bottom=�6I   $��118,0,117,30q�6d   
������� � Cursor$
 Hand��6�   $��1��6�   5%      5&      
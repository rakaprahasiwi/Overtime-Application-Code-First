   M S B A M L   `   `   `  ����N  JOvertimeApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:OvertimeApplication.UserControlEmployee'OvertimeApplication.UserControlEmployee  5      A    ;OvertimeApplication.UserControlEmployee.UCDashboardEmployee   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:OvertimeApplication.UserControlEmployee     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��auto��5	      $
��auto��6   .��5      � z�5   
   V� 5      .~�5      �� �� 5      �� 5      T� 5      5        � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $	��250 �6   .+�5   
   � .+�5      �� $��	DASHBOARD��6   ���	#FF3580BF$��30(�6@   $
��Bold"�6N   $��5q�6`   $��1��6k   5      �� 5   
   -   5         ��Name$ button_print��5       0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6'   $��1��6m   $
��Left=�6}   $��187,108,0,0q�6�   $	��Top=�6�   $��50��6�   $��40��6�   ��6�   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Printer=�6&   ���	#FF3580BF$��40��6L   $��40��6X   5      �� 5    
   -   5         ��Name$ textBox_search��5       $��1��6*   $
��Left=�6:   $��31��6U   $��
90,156,0,0q�6a    �� TextWrapping$
 Wrap=�6u   $	��Top=�6�   $	��150��6�   �� 5!   
   -   5        $ button_search��5!      #��[  6(   $
��Left=�6n   $��
54,156,0,0q�6�   $	��Top=�6�   $��26��6�   $��1��6�   $��31��6�   ���	#FFF7F7F7 J� RenderTransformOrigin$ 0.799,-0.515&�6�   .��5"        $ Search=�6&   ���	#FF3580BF64   5#      &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ dataGrid_item��5$      $
��Left=�6*   $	��Top=�6E      AutoGenerateColumns .     
IsReadOnly . $	��128��6�   $	��427��6�   $��
10,199,0,0q�6�   $��2��6�   	   Columns	 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn
   Header$
 No��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ No�6O     5'      $	
 NIK��6%    62   �� $	 NIK�6Q     5(      $

 Name��6%    63   �� $
 Name�6S     5)      $
 Status��6%    65   �� $ Status�6W   5+      5,      5.      
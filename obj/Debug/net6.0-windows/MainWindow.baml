   M S B A M L   `   `   `  ����I  EWpfTaskDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfTaskDesktopWpfTaskDesktop  5   	       WpfTaskDesktop.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfTaskDesktop     5   	   -   5          � Title$  
MainWindow��5	   	   $	��650��6   $
��1030��6)    � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%�   '��       �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 10��6!   #��z��63   ._�5      �� #��z��6/   #��z��6r   5      5      5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��250 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5       $	��150 �6   .+�5"   
   �� $?��9C:\Users\st310-05\Documents\WpfTaskDesktop\Image\logo.png��6   $	��200��6S   $	��200��6_   �� 5#   
   $'��!Планировщик задач��6   $��SemiBold"�6,   $��64(�6B   $��1��6P   $��Center=�6`   $��Center=�6}   �� 5$   
   $��Email:��6   $��0��6!   $��1��61   $��24(�6>   $��Right=�6L   $��Center=�6h   $��0 0 70 0q�6�   �� 5%   
   $��Пароль:��6   $��0��6"   $��2��62   $��24(�6?   $��Right=�6M   $��Center=�6i   $��0 0 70 0q�6�   �� 5&   
   -   5        	 ��Name$	 textbox_Email��5&      ���#86DDFF$��1��6>   $��1��6N   $	��657��6[   $��50��6g   $��32(�6s   �� 5'   
   -   5        $	 passwordbox_Password��5'      ���#86DDFF$��1��6E   $��2��6U   $	��657��6b   $��50��6n   $��32(�6z   �� 5(   
   -   5        ���#00A9EC$"��Войти в систему��5(   &   $��1��6@   $��3��6P   $	��249��6]   $��53��6i   $��24(�6u   
�������$��Right=�6�   $��	0 0 40 0 q�6�   6�   5)      5*      
   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	       WpfApplication2.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	   -   5        $��windowframe��5   .     � Title$	  SMS��6	   $	��250��6   $	��350��6"   .��5	      � $��
0,0,-8,-31q�6   
����ح���66   �� *ActualWidth+ �� ElementName$ windowframe����6m   �� *ActualHeight+$ windowframe�� � RowDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$	 tmp��5      $�� ��6   $
��Left=�6)   $y�Hidden=�6D   $��0,20,0,0q�6X   $	��Top=�6j   $��80��6�   $��30��6�   $��17(�6�   �� 5   
   -   5        $
 tmp2��5      $�� ��6   $
��Left=�6*   $y�Hidden=�6E   $��0,20,0,0q�6Y   $	��Top=�6k   $	��300��6�   $��90��6�   $��17(�6�   �� 5   
   -   5         ��Name$ txt_SMS��5      $��	20,50,0,0q�6#    �� TextWrapping$
 Wrap=�6f   $
��Left=�6z   $	��Top=�6�   ��66   �� *
FontSize+$
 tmp2����6�   �� *ActualHeight+$
 tmp2����6�   �� *ActualWidth+$
 tmp2���� 5   
   -   5        $
 bSMS��5      $
��Left=�6   $��110,150,0,70q�6:   ��6P   �� *ActualWidth+$	 tmp����6   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp��.��6�   	Send S_MS6�   �� 5   
   -   5        $ bCancel��5      $
��Left=�6"   $��210,150,0,70q�6=   ��6S   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp��.��6�   	Cance_l6   �� 5   
   -   5        $ 
bBackspace��5      $
��Left=�6%   $��20,150,0,70q�6@   ��6U   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp��.��6�   	_Delete6  �� 5   
   -   5         ��Name$ label1��5      $	��To:��6    $
��Left=�6.   $��	20,10,0,0q�6I   $	��Top=�6\   ��6t   �� *
FontSize+$	 tmp����6�   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp���� 5   
   -	   5        $ txtPhone_W1��5      $��65,5,0,0q�6'   $
 Wrap=�6�   $
��Left=�6�   $	��Top=�6�   ��6:   �� *ActualHeight+$	 tmp����6k   �� *
FontSize+$	 tmp����6�   �� *ActualWidth+$	 tmp��r� 5   
   -
   5        $��	SMS_sound��5   @    r� Source$ SMS.mp3?�6    r� LoadedBehavior$ Manual=�6(   	 r� Volume$	 1Q�6Q   $��0,0,184,400q�6\   6s   5      5      
   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication2WpfApplication2  5   	        WpfApplication2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication2     5   	   -   5        $��windowframe��5   ?     � Title$  VoIP (Voice over IP)��6	   $	��420��6&   $	��210��63   .��5	      � -   5        $��raster��5	      $��	0,-3,0,-1q�6   $	��Top=�6,   $
��Left=�6D   ��6_   �� *ActualWidth+ �� ElementName$ windowframe����6�   �� *ActualHeight+$ windowframe��.+�5
   
   ]� $��	1,2,-1,40q�6   .+�5      o� $��-5,0,-7,-20q�6   $��20��6(   $	��Top=�64   .@�5      m� $��_File��6   $��20��6*   $��30��66   .@�5      m� -   5        $��_Save��5       m� InputGestureText$ ALT+S��6C   m� 5      -   5        $��_Call��5      $ ALT+C��6C   m� 5      -   5        $��	Send S_MS��5      $ ALT+M��6F   �� 5      m� 5      -   5        $��E_xit��5      $ ALT+X��6A   5      m� 5      $��_Help��6   $��20��6*   $��40��66   $ ALT+H��6A   5      5      �� 5   
   -   5         ��Name$	 tmp��5      $�� ��6   $
��Left=�6)   $y�Hidden=�6D   $��0,20,0,0q�6X   $	��Top=�6j   $��40��6�   $��40��6�   $��17(�6�   �� 5   
   -   5         ��Name$ txtPhone��5      $	��Top=�6S   $
��Left=�6k   $��	20,40,0,0q�6�   $	��100��6�   ��6$   �� *
FontSize+$	 tmp����6�   �� *ActualHeight+$	 tmp���� 5   
   -	   5        $ 
bBackspace��5      $
��Left=�6%   $��
140,40,0,0q�6@   $	��Top=�6T   ��6l   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp��.��6  _Del6  �� 5   
   -
   5        $ button1��5      $��1��6"   $
��Left=�6.   $��
20,100,0,0q�6I   $	��Top=�6]   ��6u   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5   
   -   5        $ button2��5      $��2��6"   $
��Left=�6.   $��
80,100,0,0q�6I   $	��Top=�6]   ��6u   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5   
   -   5        $ button3��5      $��3��6"   $
��Left=�6.   $��140,100,0,0q�6I   $	��Top=�6^   ��6v   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5   
   -   5        $ button4��5      $��4��6"   $
��Left=�6.   $��
20,160,0,0q�6I   $	��Top=�6]   ��6u   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5    
   -   5        $ button5��5       $��5��6"   $
��Left=�6.   $��
80,160,0,0q�6I   $	��Top=�6]   ��6u   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5!   
   -   5        $ button6��5!      $��6��6"   $
��Left=�6.   $��140,160,0,0q�6I   $	��Top=�6^   ��6v   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5"   
   -   5        $ button7��5"      $��7��6"   $
��Left=�6.   $��
20,220,0,0q�6I   $	��Top=�6]   ��6u   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5#   
   -   5        $ button8��5#      $��8��6"   $
��Left=�6.   $��
80,220,0,0q�6I   $	��Top=�6]   ��6u   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5$   
   -   5        $ button9��5$      $��9��6"   $
��Left=�6.   $��140,220,0,0q�6I   $	��Top=�6^   ��6v   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5%   
   -   5        $ bStern��5%      $��*��6!   $
��Left=�6-   $��
20,280,0,0q�6H   $	��Top=�6\   ��6t   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5&   
   -   5        $ button0��5&      $��0��6"   $
��Left=�6.   $��
80,280,0,0q�6I   $	��Top=�6]    J� RenderTransformOrigin$ 0,0.4&�6�   ��6u   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6	  �� *
FontSize+$	 tmp���� 5'   
   -   5        $ 	bHashtag1��5'      $��#��6$   $
��Left=�60   $��140,280,0,0q�6K   $	��Top=�6`   ��6x   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp���� 5(   
   -   5        $ bSave��5(      $
��Left=�6    $��
20,340,0,0q�6;   $	��Top=�6O   ��6g   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp��.��6	  _Save6  �� 5)   
   -   5        $ bCall��5)      $
��Left=�6    $��
80,340,0,0q�6;   $	��Top=�6O   ��6g   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp��.��6
  _Call6  �� 5*   
   -   5        $
 bSMS��5*      $
��Left=�6   $��140,340,0,0q�6:   $	��Top=�6O   ��6g   �� *ActualWidth+$	 tmp����6�   �� *ActualHeight+$	 tmp����6�   �� *
FontSize+$	 tmp��.��6  S_MS6  r� 5,   
   -   5        $��
Call_sound��5,   B    r� Source$ 	Anruf.mp3?�6    r� LoadedBehavior$ Manual=�6*    r� Volume$ 1Q�6T   $��0,0,184,400q�6_   6v   5-      5/      
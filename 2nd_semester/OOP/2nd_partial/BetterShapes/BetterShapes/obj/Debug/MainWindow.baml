   M S B A M L   `   `   `  ����G  CBetterShapes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BetterShapesBetterShapes  5   	       BetterShapes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BetterShapes     5   	   -   5          � Title$  BetterShapes��5   	   $	��450��6   $	��800��6+    � Icon$ icon.png��6N   $	��800��6^   $	��450��6m   .��5	      � .+�5
   
   �� -   5         ��Name$ canvas��5
      
���   �6r   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Bottom=�6.   $��Right=�6I   $��75��6e   .+�5      �� $��10q�6   $��Center=�6%   $��Center=�6B   .+�5      �� $��Center=�6   $��Center=�69   $
��Wrap=�6T   
�������$,��&Left Mouse Button Down : Remove Shapes��6{   �� 5      $��Center=�6   $��Center=�69   $
��Wrap=�6T   
�������$*��$Right Mouse Button Down : Add Shapes��6{   5      �� 5      $��10q�6   $��Center=�6%   $��Center=�6B   .+�5      �� -   5         ��Name$ CanvasMarginLabel��5      $��Center=�67   $��Center=�6T   $
��Wrap=�6o   
�������$��Canvas Margin: 10��6�   �� 5      -   5         ��Name$ CanvasMarginSlider��5      $��Center=�65   $	��100��6P    � Value$ 10Q�6\    � Minimum$ 0Q�6g    � Maximum$	 100Q�6s   	 �� AutoToolTipPlacement$	 TopLeft=�6�   6�   5      �� 5      $��10q�6   $��Center=�6%   $��Center=�6B   .+�5      �� -   5        $ ShapesCountLabel��5      $��Center=�66   $��Center=�6S   $
��Wrap=�6n   
�������$��Amount of Shapes: 1500��6�   �� 5      -   5        $ ShapesCountSlider��5      $��Center=�64   $	��150��6O   $
 1500Q�6[   $ 1Q�6h   $	 TopLeft=�6t   6�   5      �� 5      $��10q�6   $��Center=�6%   $��Center=�6B   .+�5      �� -   5        
 ��Name$
 AnimateShapes��5      $��Center=�62   $��Center=�6O   
�������$��Animate Shapes��6}   6�   �� 5      -   5        $ AnimateShapesSpeedLabel��5      $��Center=�6=   $��Center=�6Z   $
��Wrap=�6u   
�������$��Speed of Shapes: 10��6�   �� 5      -	   5        $ AnimateShapesSpeed��5      $��Center=�65   $��Center=�6R   $	��150��6m   $ 1Q�6y   $ 10000Q�6�   $	 TopLeft=�6�   6�   5      �� 5      -
   5         ��Name$ RecreateShapesButton��5      $��5, 25, 5, 25q�63   $	��2.5q�6I   $��Recreate��6W   6j   5      5      5       
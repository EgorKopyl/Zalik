   M S B A M L   `   `   `  ����?  ;boat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:boatboat  5   	       boat.BoatOrder   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:boat     5   	     � Title$  FurnitureOrder��5   	   $
��1080��6    $
��1920��6.    � WindowState$ 	Maximized=�6<   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6   
������� � RowDefinitions 5      �� 5      $��* �6    �� 5      $��5* �6    �� 5      $��2* �6    .+�5      �� -   5         ��Name$ TypeItemList��5   4   $��Time New Roman)�6    �� DisplayMemberPath$
 Name��6J   $��Center=�6c   $��Center=�6�   $	��250��6�   $��40��6�   $��	150,0,0,0q�6�   �� 5      $��Type: ��6   $��Center=�6%   $��Center=�6B   $��	0,0,200,0q�6]   $��Times New Roman)�6q   �� 5      -   5         ��Name$ BoatsItemList��5      $��
10,5,10,10q�6c   $��1��6w    �� View 5      �� 5      .P�5      �� $
��Name��6)    �� Width$	 150��67   	 �� DisplayMemberBinding	 6C   �� *Name+�� 5      $��Price��6)   $	 150��68   	 6D   �� *Price+5      5      ]� 5      $��Center=�6   $��30,0,0,0q�63   $��2��6E   $	��300��6R   $
��Left=�6^   .+�5      �� $��Right=�6w   
 �� TextAlignment$
 Right=�6�   $��40��6�   $��Time New Roman)�6�   $��Center=�6�   ��6   ��  �� ElementName$ QuantitySlider�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5       -   5        $��QuantitySlider��5    ]    � Minimum$ 0Q�6    �� TickPlacement$ BottomRight=�6%    �� IsSnapToTickEnabled$
 True��6B   6s   5!      �� 5"      $��2��6   $��Amount: ��6"   $��Center=�65   $��0,0,0,0q�6R   $��Center=�6c   $��Times New Roman)�6   �� 5#      -   5         ��Name$ AmountForProduct��5#      $��2��6.   $��0��6<   $��Center=�6H   $��	110,0,0,0q�6e   $��Center=�6x   $��Times New Roman)�6�   �� 5'      -   5        $	��Add��5'      $��2��6#   $	��150��60   $��50��6<   $��Right=�6H   $��Center=�6d   $��	0,0,100,0q�6   
������$��Times New Roman)�6�   5*      � 5,   
   $��1��6   
�������.+�5-      � -   5         �Name$ grid1��5-      .+�5/      �� $
��List��6   $��48��6'   $	��Top=�64   $��Center=�6L   $��20(�6i   $��Times New Roman)�6y   $��0,50,0,0q�6�   �� 50      -   5        $ OrderBoatItemList��50      $	��650��66   $	��Top=�6C   $��20,141,20,0q�6[    51      �� 52      .P�53      �� $��Name оf Product��6-   $	 150��6F   	 6R   �� *	Boat.Name+�� 54      $��Price��6-   $	 150��6<   	 6H   �� *
Boat.Price+�� 55      $��Quantity��6-   $	 150��6?   	 6K   �� *
Quantity+�� 56      $��Amount��6-   $	 150��6=   	 6I   �� *Amount+57      59      �� 5:      $��Amount: ��6   $��Right=�6,   $��0,0,459,193q�6H   $��Bottom=�6]   $��20(�6x   $��Times New Roman)�6�    J� RenderTransformOrigin$ 0.559,0.424&�6�   �� 5;      -   5        $ Amount��5;      $��0��6)   $��Right=�65   $��0,0,423,193q�6Q   $��Bottom=�6f   $��24(�6�   $��Times New Roman)�6�   $ 0.614,0.521&�6�   5<      �� 5=      -	   5        $��Delete from list��5=      $��44��60   $	��129��6=   $��
41,0,0,110q�6I   $��Bottom=�6]   $
��Left=�6x   ���	#FFFF8484$��Times New Roman)�6�   $ 0.531,-0.523&�6�   �� 5>      -
   5        $��Confirm purchase��5>      $��44��60   $	��128��6=   $��Bottom=�6I   $��Right=�6d   $��
0,0,64,110q�6�   ���	#FF7FFD00$��Times New Roman)�6�   �� 5?      -   5        $��Cancel purchase��5?      $��44��6/   $	��128��6<   $	��Top=�6H   $��Center=�6`   $��	0,910,0,0q�6�   
��� ���$��Times New Roman)�6�   5A      5C      5D      
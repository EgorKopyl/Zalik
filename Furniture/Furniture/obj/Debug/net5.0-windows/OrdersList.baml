   M S B A M L   `   `   `  ����?  ;boat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:boatboat  5   	       boat.OrdersList   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:boat     5   	     � Title$  
OrdersList��5   	   $
��1080��6   $
��1920��6*    � WindowState$ 	Maximized=�67   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $��5* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ OrderItemList��5      $��10,10,10,10q�6\    �� View 5      �� 5      .P�5      �� $��Id��6%    �� Width$	 150��61    �� DisplayMemberBinding 6=   �� *Id+�� 5      $��DateTime��6%   $	 150��67    6C   �� *
DateTime+�� 5      $��Amount��6%   $	 150��65    6A   �� *Amount+5      5      �� 5   
   -   5        $ OrderBoatItemList��5      $��1��6.   $��10,10,10,10q�6;    5      �� 5      .P�5      �� $��Name of Product��6%   $	 150��6>    6J   �� *	Boat.Name+�� 5      $��Price��6%   $	 150��64    6@   �� *
Boat.Price+�� 5       $��Quantity��6%   $	 150��67    6C   �� *
Quantity+�� 5!      $��Amount��6%   $	 150��65    6A   �� *Amount+5"      5$      �� 5%   
   -   5        $��New purchase��5%      $��1��6(   $��1��68   $��50��6E   $��Center=�6Q   ���	#FF66BD6A$��	30,0,31,0q�6�   6�   �� 5&   
   -   5        $��Delete purchase��5&      $��1��6+   $��50��6<   $��Center=�6H   ���	#FFE66A46$��	30,0,30,0q�6z   6�   5(      5)      
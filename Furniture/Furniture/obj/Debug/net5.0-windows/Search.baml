   M S B A M L   `   `   `  ����?  ;boat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:boatboat  5   	       boat.Search   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:boat     5   	     � Title$  Search��5   	   $
��1080��6   $
��1920��6&    � WindowState$ 	Maximized=�63   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��5* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ BoatItemList��5       �� View 5      �� 5      .P�5      ��  �� Width$	 150��6%   $��Id��61    �� DisplayMemberBinding 6>   �� *Id+�� 5      $	 150��6%   $
��Name��61    6@   �� *Name+�� 5      $	 150��6%   $��Price��61    6A   �� *Price+�� 5      $	 150��6%   $
��Type��61    6@   �� *TypeBoat.Name+5      5      � 5   
   $��1��6   $��Center=�6   $��Center=�67   $
��Auto��6T   .+�5      �� -   5        $��Search��5      $	��200��6&   $
��Left=�62   $��	-66,5,0,5q�6M   $��15(�6`   $��Times New Roman)�6n   
������$��30��6�   �� 5      -   5        $��Search��5      $	��200��6'   $
��Left=�63   $��	487,5,0,5q�6N   $��15(�6a   $��Times New Roman)�6o   
������$��30��6�   �� 5      $
��Name��6   $
��Left=�6#   $��Center=�6>   $��15(�6Y   $��Times New Roman)�6g   $��
-360,0,0,0q�6�   �� 5      -   5         ��Name$ 	SerchText��5   @   $��15(�6   $��Time New Roman)�6$   $
��Left=�6T   $	��200��6o   $��24��6{   $��Center=�6�   $��
-293,0,0,0q�6�   �� 5      -   5         ��Name$ SerchComboBox��5   A   $��15(�6   $��Time New Roman)�6%   	 �� DisplayMemberPath$
	 Name��6X   $��Center=�6q   $��Center=�6�   $	��250��6   $��36��6  
 �� SelectedValue
 6�   �� *SelectedItem.TypeBoat+ �� ElementName$ BoatItemList�� �� Mode$ OneWay=�6  �� 5      $
��Type��6   $
��Left=�6#   $��Center=�6>   $��15(�6Y   $��Times New Roman)�6g   $��	157,0,0,0q�6�   5      5       5!      
   M S B A M L   `   `   `  ����E  Ahockey_nhl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:hockey_nhl
hockey_nhl  5   	       hockey_nhl.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:hockey_nhl     5   	     � Title$  	NHLRoster��5   	   $	��350��6   $	��525��6(   .��5	      � .+�5
   
   �� -   5         ��Name$ 
PlayersBox��5
      $
��Left=�6&   $	��270��6A   $	��Top=�6N   $	��256��6f   $��	10,15,0,0q�6r   ��5      �� 5      .R�5      � $��45��6   $	��224��6'    � ColumnDefinitions 5      �� 5      $��* �6/   �� 5      $
��Auto �6/    � RowDefinitions 5      �� 5      $��* �6,   �� 5      $
��Auto �6,   .+�5      �� $
��Left=�6:   $	��Top=�6U   $	��3,3q�6m   ��6$   �� *Name+6m   �� 5      $	��Top=�6<   $��Right=�6T   $	��3,3q�6q   ��6$   �� *Height+6q   �� 5      $��Bottom=�6>   $
��Left=�6Y   $	��3,3q�6u   ��6$   �� *
Position+6u   �� 5      $��Right=�6<   $��Bottom=�6X   $	��3,3q�6s   ��6$   �� *Status+6s   ��5      �� 5       �� 
TargetType" �6$   .�5   "   ��  �� Property � �� �� Value
 �����6?    �� Triggers 5   "   �� 5   &    �� Binding 62   �� *Status+	 �� Value	 Injured6M   .a�5   *   ��  � �� �	#FFF080806G   5    '   �� 5!   &    62   �� *Status+
	 Active6M   .a�5"   *   ��  � �� �	#FF8FBC8F6G   5#   '   5%      5'      5(      5*      �� 5+   
   -   5        $ 	ActualBox��5+      $
��Left=�6%   $	��270��6@   $	��Top=�6M   $	��130��6e   $��
271,15,0,0q�6q   ��5,      �� 5-      .R�5.      � $��45��6   $
��Auto��6'    5/      �� 50      $��* �6/   �� 51      $
��Auto �6/   .+�53      �� $
��Left=�6:   $	��Top=�6U   $	��3,3q�6m   ��6$   �� *Name+6m   �� 54      $
��Left=�6>   $��Bottom=�6Y   $	��3,3q�6t   ��6$   �� *
Position+6t   55      56      58      �� 59   
   -   5        
 ��Name$	
 Add��59      $	��Add��6   $
��Left=�6,   $	��Top=�6G   $��81��6_   $��
417,16,0,0q�6j   6~   �� 5:   
   -   5        $	
 Mod��5:      $	��Mod��6   $
��Left=�6,   $	��Top=�6G   $��81��6_   $��
417,41,0,0q�6j   6~   �� 5;   
   -   5        $
 Remove��5;      $��Remove��6!   $
��Left=�62   $	��Top=�6M   $��81��6e   $��
417,66,0,0q�6p   6�   �� 5<   
   -   5        $
 MoveFromPlayersToActual��5<      $��Move >>��62   $
��Left=�6J   $	��Top=�6e   $��81��6}   $��
417,91,0,0q�6�   6�   �� 5=   
   -   5        $
 MoveFromActualToPlayers��5=      $��Move <<��62   $
��Left=�6J   $	��Top=�6e   $��81��6}   $��417,116,0,0q�6�   6�   5@      5A      
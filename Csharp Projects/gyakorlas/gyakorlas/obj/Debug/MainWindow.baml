   M S B A M L   `   `   `  ����D  @gyakorlas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:gyakorlas	gyakorlas  5   	       gyakorlas.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:gyakorlas     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��5* �6   .+�5   
   ]� $��2��6   $��20��6(   $	��Top=�64   .+�5      o� $	��Top=�6   .@�5      m� $��Fájl��6   .@�5      m� -   5        $��Mentés másként...��5      6:   m� 5      -   5        $��Megnyitás...��5      65   5      m� 5      $��Szerkesztés��6   .@�5      m� $��Visszavonás��6   m� 5      $��Újra��6   �� 5      m� 5      $��	Kivágás��6   m� 5      $��	Másolás��6   m� 5      $��Beillesztés��6   �� 5      m� 5       $��Törlés��6   5!      5"      5#      �� 5$   
   -   5         ��Name$ focim��5$      $��Ez egy főcím��6   $��2��66   $
��Left=�6J   $	��Top=�6e   $��Times New Roman)�6}   $��30(�6�   $
��Bold"�6�   $��Italic$�6�   
�������$��
316,23,0,0q�6�    � ContextMenu 5%      �� 5&      .@�5'      m� -   5         m�Name$ elso_stilus��5'      $��Első stílus��6N   
�������6c   �� 5(      m� 5)      -   5        $ masodik_stilus��5)      $��Második stílus��6T   
��� ��6l   �� 5*      m� 5+      -   5        $ harmadik_stilus��5+      $��Harmadik stílus��6V   
����� �6o   5,      5.      �� 5/   
   -   5         ��Name$ szoveg��5/      $��0��6&   $��1��66   $��2��6C   $��20(�6W   
���   �
��� � � 50      �� 51      .@�52      m� -   5        $��
Mentés...��52      62   m� 53      -	   5        $��Megnyitás...��53      65   54      56      57      58      
   M S B A M L   `   `   `  ����>  :vpn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:vpnvpn  5   	       vpn.StartMenuFolder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:vpn     5   	     N� Title$!  Setup - VPN Unlimited 8.5.3��5   	   $	��480��6-   $	��600��6:    N� 
Background �#1a1a1a.��5	      � ���#fdfdfd � RowDefinitions 5
   
   �� 5      $��80 �6   �� 5      $	��300 �6   �� 5      $��90 �6   .+�5   
   �� $��0��6   .+�5      �� $��0��6   $
��Left=�6!   $��Select Start Menu Folder��6=   $
��Bold"�6`   $��20 5 0 0q�6r   $��14(�6�   �� 5      $��0��6   $
��Left=�6!   $��Regular"�6<   $7��1Where should Setup place the program's shortcuts?��6Q   $��40 0 0 0q�6�   $��12(�6�   $
��auto��6�   5      �� 5   
   $��0��6   $��Right=�6   $��80��69   $��vpnUnlimited.png��6D   �� 5   
   $��1��6   $��2��6   ���	#FFF0F0F06H   �� 5   
   $��1��6   $��0,1,0,1q�6   ���	#FFACACAC$y�Visible=�6P   ._�5      �� $	��450��6   .+�5      � $��	0 10 0 15q�6    � ColumnDefinitions 5      �� 5      �� 5      $	��415 �6+   .+�5      �� $��Center=�6   $��0��67   $��30��6G   $��30��6R   $��startMenu.png��6^   �� 5      $��Center=�6    $��1��6;   
������ $
��Wrap=�6d   OMSetup will create the program's shortcuts in the following Start Menu Folder.6�   5      �� 5      $��1��6   $��0 0 0 10q�6,   
������ $
��Wrap=�6W   WUTo continue, click Next. If you would like to select a different folder, click Browse6�   � 5       $��22��6    5!      �� 5"      $	��330 �6+   �� 5#      .+�5%      �� -   5         ��Name$	 Url��5%      $��0��6+   $	��330��6;   $
��Left=�6G   .��6b   VPN Unlimited6q   �� 5&      -   5         ��Name$ Browse��5&      $��1��6-   $��80��6=   $��	Browse...��6H    � Cursor$
 Hand��6\   6j   5'      5(      5)      �� 5*   
   $��2��6   $��0,0,0,18q�6   ._�5+      � $	��260��6   $��Right=�6   $��0 0 20 0q�6;   .+�5,      �� -   5        $
 Back��5,      $
��Left=�6'   $��25��6B   $��80��6N   $
��Back��6Y   $
 Hand��6h   6v   �� 5-      -   5        $
 Next��5-      $��Center=�6'   $��25��6D   $��80��6P   $
��Next��6[   $
 Hand��6j   6x   �� 5.      -   5        $ Cancel��5.      $��Right=�6)   $��25��6E   $��80��6Q   $��Cancel��6\   $
 Hand��6m   6{   5/      50      51      52      
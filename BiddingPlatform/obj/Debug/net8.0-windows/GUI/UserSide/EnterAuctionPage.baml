   M S B A M L   `   `   `  ����J  FBiddingPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BiddingPlatform.GUIBiddingPlatform.GUI  5      *    $BiddingPlatform.GUI.EnterAuctionPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:BiddingPlatform.GUI     5        N� Title$  EnterAuctionPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��Bid History��6   $��0��6&   $��0��63   $��2��6C   $	��150��6W   $��40��6c   $��Center=�6o   $��Center=�6�   $��Center=�6�   $��Center=�6�   ${�False��6�    K� ZIndex$ 2��6�   $��24(�6  $��	Agency FB)�6  �� 5   
   -   5         ��Name$ 
BidHistory��5      $��0��6&   $��0��63   $��2��6C   $��5��6W   $��20q�6h   ${�False��6t   �� 5    
   -   5        $ 
CurrentBid��5       $��1��6&   $��2��63   $��55 30 20 20q�6C   ${�False��6X   6l   �� 5#   
   -   5        $ TimeLeft��5#      $��1��6$   $��3��61   $��20 30 55 20q�6A   ${�False��6V   6j   �� 5&   
   -   5        $ AuctionNameBid��5&      $��2��6*   $��2��67   $��2��6G   $��
20,0,20,30q�6[   ${�False��6o   6�   �� 5)   
   -   5        $ SumInput��5)      $��2��6$   $��2��61   $��2��6A   $��100,65,100,65q�6U    �� TextAlignment$ Center=�6l   $��36(�6�   $��	Agency FB)�6�   $��2��6�   �� 5,   
   -   5        $��3��5,      $��60,30,60,22q�6!   $��3��66   $	��Bid��6C   $��	Agency FB)�6Q   $��24(�6h   6v   �� 5/   
   -   5        $��3��5/      $��4��6!   $��85 20 20 20q�6.   $
��Back��6C   $��22(�6R   $��	Agency FB)�6`   6�   50      51      
   M S B A M L   `   `   `  ����E  AJust_Click, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Just_Click
Just_Click  5   	       Just_Click.GameWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Just_Click     5   	     � Title$  
GameWindow��5   	   $	��450��6   $	��800��6)   
�����p� � 
ResizeMode$ NoResize=�5	   	    � WindowStyle$
 None=�6    � 	Resources 5         	imgSource  backgroundImage �� ImageSource �� Opacity��%j   &	        &	 (     ��5   
   secret_backg.png��6:   �� 5   
   # �   6-   $	 0.3Q�6W   6g   5      .��5      � .+�5   
   �� -   5         ��Name$
 sbtn��5      $��Click��6   $
��Left=�6/   $��277,287,0,0q�6J   $	��Top=�6_   $	��208��6w   $��94��6�   
��� ���6�   �� 5   
   -   5         ��Name$ score��5      $��Score:��6   $
��Left=�60   $��
363,78,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $
 xbtn��5      $��Exit and save score��6   $
��Left=�6=   $��
10,406,0,0q�6X   $	��Top=�6l   $	��119��6�   $��34��6�   
���  ��6�   � 5   
   $��565,142,126,175q�6   .+�5      �� -   5        $ twobtn��5      $��+2��6%    � ToolTip$ Unlocked at 100 clicks!��62   $
��Left=�6T   $	��Top=�6o   $	��106��6�   $��43��6�   6�   �� 5      -   5        $ tenbtn��5      $	��+10��6%   $ Unlocked at 1000 clicks!��63   $
��Left=�6V   $��0,59,0,0q�6q   $	��Top=�6�   $	��106��6�   $��43��6�   6�   �� 5      -   5        $ secbtn��5      $��
Useless...��6%   $1 +Unlocked at 10000 clicks! Warning: Useless!��6:   $
��Left=�6p   $��0,111,-27,-21q�6�   $	��Top=�6�   $	��106��6�   $��43��6�   6�   5      �� 5   
   $��Upgrades��6   $
��Left=�6#   $��588,111,0,0q�6>   $	��Top=�6S   5      5      
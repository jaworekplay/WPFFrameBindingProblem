   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApplication1.ViewsWpfApplication1.Views  5      !    WpfApplication1.Views.Page2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfApplication1.Views     5        N� Title$  Page2��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%T   '��       �� 5   
   " ��6   .�5      ��  � ��
 ���� 6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� ��6   �� *	SearchKey+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��Search��6!   ��62   �� *LoginCommand+�� 5   
   $��1��6   $��3��6    �� DisplayMemberPath$
 Name��6P   ��63   �� *List+��5      �� 5       " ��6   .�5!      ��  �@J�Opacity$	 0.5Q�60   �� 5"       � ��$ 50��62   �� 5#       � �� 5$      �� 5%      	 �� 
TargetType"	 ��6.   .R�5&   "   �� $��_Border��6)   
 �� Padding$
 2q�5'   %    J� SnapsToDevicePixels . ._�5)   &   �� 5*   #    �� Triggers 5+   "   P� 5,   &    P� Property �@��
IsSelected P� Value . . �5-   *   ��  �@J�Opacity$	 1.0Q�6D   �� 5.   *    � ��$	 100��6F   �� 5/   *    �� 
TargetName$ _Border��61    �@J�Effect 50   .   3  -System.Windows.Media.Effects.DropShadowEffect  51   2      
BlurRadius$ 25Q�6C      ShadowDepth$ 8Q�6S      	Direction$	 270Q�6c      Color$ Black��6s      Opacity$	 .42Q�6�      RenderingBias$ Performance=�6�   53   +   54   '   56      58      59      5;      5<      5=      
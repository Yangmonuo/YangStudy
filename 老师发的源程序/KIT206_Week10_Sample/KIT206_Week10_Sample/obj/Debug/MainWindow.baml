   M S B A M L   `   `   `  ����O  KKIT206_Week10_Sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:KIT206_Week10_SampleKIT206_Week10_Sample  5   	   %    KIT206_Week10_Sample.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   4local"clr-namespace:KIT206_Week10_Sample     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��637��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��130* �6   �� 5	      $
��270* �6   �� 5
      $
��200* �6   .+�5   
   �� -   5         ��Name$ sampleListBox��5      $��0q�6)   ��5      ��    	staffList �� Source# [  �� 5   
   -   5         ��Name$ sampleTextBox��5      $��1��6)   $
��Left=�69   $��23��6T   $��	42,19,0,0q�6`    �� TextWrapping$
 Wrap=�6s   $��TextBox��6�   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5         ��Name$ sampleButton��5      $��Button��6'   $��1��68   $
��Left=�6H   $��
167,19,0,0q�6c   $	��Top=�6w   $��75��6�   $��22��6�   -   'KIT206_Week10_Sample.ExampleUserControl  5   
   $��1��6#   $
��Left=�63   $��
52,170,0,0q�6N   $	��Top=�6b   $	��190��6z   $��49��6�   �� 5   
   -   5        $ btnDeleteOne��5      $��
Delete One��6'   $��1��6<   $
��Left=�6L   $��
119,71,0,0q�6g   $	��Top=�6{   $��75��6�   $��20��6�   �� 5   
   -   5         ��Name$ DetailsPanel��5       �� Orientation$ Vertical=�6+   $��2��6B   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Name:��6   6*   �� 5      ��6   �� 	 �� Path$
	 Name�68   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Gender:��6   6,   �� 5      ��6   �� $	 Gender�6:   5      �� 5      $��Work Times:��6   �� 5      $��70��6   ��6"   �� $	 	WorkTimes��� 5      $"��Work Times using a DataGrid:��6   &   System.Windows.Controls.DataGrid  5      
   
IsReadOnly
 .    AutoGenerateColumns .  $��90��6E   ��6Q   �� $	 	WorkTimes�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$	 Day��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Day+  5!      $ Start��6)    68   �� *Start+  5"      $	 End��6)    66   �� *End+5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� $��Total Work (hours):��6   68   �� 5'      ��6   �� $	 TotalWorkHours�6B   5(      �� 5)      $ 
Horizontal=�6   .+�5*      �� $��	Workload:��6   6.   �� 5+       �� ContentStringFormat$ {0:0.0}%��6:   ��6   �� $	 Workload�6]   5,      5-      5.      5/      
   M S B A M L   `   `   `  ����G  CZzaDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ZzaDashboard.ProductsZzaDashboard.Products  5      (    "ZzaDashboard.Products.ProductsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ZzaDashboard.Products     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5        � DataContext  5      ,   &ZzaDashboard.Products.ProductViewModel  5   
      	ProductId$* $11DA4696-CEA3-4A6D-8E83-013F1C479618��6!   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      4  .Microsoft.Xaml.Behaviors.Core.CallMethodAction     
MethodName$ LoadProduct��5   "      TargetObject 5   !   �� 5   "   5      .��5      � .+�5   
   � .+�5      � -   5         �Name$ grid1��5      $
��Left=�5      $��	10,10,0,0q�5      $	��Top=�5       � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5      $
��Auto �6'   	 � RowDefinitions	 5      �� 5      $
��Auto �6$   �� 5       $
��Auto �6$   �� 5!      $
��Auto �6$   �� 5"      $
��Auto �6$   �� 5#      $
��Auto �6$   .+�5%      �� 
 �� Orientation$
 
Horizontal=�6   $��0��66   $��2��6F   .+�5&      �� $��Product Information��6    6?   5'      �� 5(      $�� Name:��6   $��0��5)      $
��Left=�5*      $��3q�5+      $��1��5,      $��Center=�5-      �� 5.      -   5         ��Name$ firstNameTextBox��5.      $��1��5/      $
��Left=�50      $��23��51      $��3q�52      $��1��53      $��Center=�55      $	��120��56      ��54      �� *Product.Name+56      �� 57      $�� Type:��6   $��0��58      $
��Left=�59      $��3q�5:      $��2��5;      $��Center=�5<      �� 5=      -   5        $ lastNameTextBox��5=      $��1��5>      $
��Left=�5?      $��23��5@      $��3q�5A      $��2��5B      $��Center=�5D      $	��120��5E      ��5C      �� *Product.Type+5E      �� 5F      $��Image:��6   $��0��5G      $
��Left=�5H      $��3q�5I      $��3��5J      $��Center=�5K      �� 5L      -   5        $ phoneTextBox��5L      $��1��5M      $
��Left=�5N      $��23��5O      $��3q�5P      $��3��5Q      $��Center=�5S      $	��120��5T      ��5R      �� *Product.Image+5T      �� 5U      $��4��6   $��0��5V      $��2��5W      $��Right=�5X      $
 Vertical=�5Y      $��3q�5Z      .+�5[      �� -   5         ��Name$ 
saveButton��5[      $
��Save��5\      $	��175��5]      ��5^      �� *SaveCommand+5_      5`      5a      5b      5c      
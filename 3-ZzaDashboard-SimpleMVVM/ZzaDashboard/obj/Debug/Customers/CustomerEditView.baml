   M S B A M L   `   `   `  ����G  CZzaDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ZzaDashboard.CustomersZzaDashboard.Customers  5      -    'ZzaDashboard.Customers.CustomerEditView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:ZzaDashboard.Customers     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5        � DataContext  5      2   ,ZzaDashboard.Customers.CustomerEditViewModel  5   
      
CustomerId$* $11DA4696-CEA3-4A6D-8E83-013F1C479618��6&   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      4  .Microsoft.Xaml.Behaviors.Core.CallMethodAction     
MethodName$ LoadCustomer��5   "      TargetObject 5   !   �� 5   "   5      .��5      � .+�5   
   � -   5         �Name$ grid1��5      $
��Left=�5      $��	10,10,0,0q�5      $	��Top=�5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   	 � RowDefinitions	 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5#      �� $��First Name:��6   $��0��5$      $
��Left=�5%      $��3q�5&      $��0��5'      $��Center=�5(      �� 5)      -   5        
 ��Name$
 firstNameTextBox��5)      $��1��5*      $
��Left=�5+      $��23��5,      $��3q�5-      $��0��5.      $��Center=�50      $	��120��51      ��5/      �� *Customer.FirstName+51      �� 52      $��
Last Name:��6   $��0��53      $
��Left=�54      $��3q�55      $��1��56      $��Center=�57      �� 58      -   5        $
 lastNameTextBox��58      $��1��59      $
��Left=�5:      $��23��5;      $��3q�5<      $��1��5=      $��Center=�5?      $	��120��5@      ��5>      �� *Customer.LastName+5@      �� 5A      $��Phone:��6   $��0��5B      $
��Left=�5C      $��3q�5D      $��2��5E      $��Center=�5F      �� 5G      -   5        $
 phoneTextBox��5G      $��1��5H      $
��Left=�5I      $��23��5J      $��3q�5K      $��2��5L      $��Center=�5N      $	��120��5O      ��5M      �� *Customer.Phone+5O      �� 5P      $��3��6   $��0��5Q      $��2��5R      $��Right=�5S       �� Orientation$ 
Horizontal=�5T      $��3q�5U      .+�5V      �� -   5         ��Name$ 
saveButton��5V      $
��Save��5W      $��75��5X      ��5Y      �� *SaveCommand+5Z      5[      5\      5]      
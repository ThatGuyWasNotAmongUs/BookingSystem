   M S B A M L   `   `   `  ����Z  VWesAlipio.BookingSystem.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:WesAlipio.BookingSystem.Windows.Customers)WesAlipio.BookingSystem.Windows.Customers  5   	   <    6WesAlipio.BookingSystem.Windows.Customers.CustomerList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:WesAlipio.BookingSystem.Windows.Customers     5   	     � Title$  CustomerList��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ btnLast��5
      $
��Last��6"   $
��Left=�61   $��27��6L   $��
10,296,0,0q�6X   $	��Top=�6l   $��84��6�   6�   �� 5   
   -   5        $ btnNext��5      $
��Next��6"   $
��Left=�61   $��27��6L   $��
10,264,0,0q�6X   $	��Top=�6l   $��84��6�   6�   �� 5   
   -   5        $ btnPrev��5      $��Previous��6"   $
��Left=�65   $��27��6P   $��
10,232,0,0q�6\   $	��Top=�6p   $��84��6�   6�   �� 5   
   -   5        $ btnFirst��5      $��First��6#   $
��Left=�63   $��27��6N   $��
10,200,0,0q�6Z   $	��Top=�6n   $��84��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgCustomers��5      $
��Left=�6(   $	��373��6C   $��
104,36,0,0q�6P   $	��Top=�6d   $	��678��6|      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   5   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *	FirstName+65     5      $ 	Last Name��6%   $ * 5   4    6   �� *
LastName+64     5      $ Email Address��6%   $ * 5   8    6   �� *EmailAddress+68     5      $ HomeAddress��6%   $ * 5   7    6   �� *HomeAddress+67     5      $ ContactNumber��6%   $ * 5   9    6   �� *ContactNumber+69   4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� $ 	btnUpdate��6%   -   5        .��5   P   Update6X   5      5       5"      �� 5#   
   -   5        
 ��Name$
 	txtSearch��5#      $
��Left=�6%   $��26��6@   $��
104,10,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��407��6�   6�   �� 5$   
   -   5        $
 txtPageSize��5$      $
��Left=�6'   $��26��6B   $��
10,377,0,0q�6N    �� TextAlignment$ Center=�6b   $
 Wrap=�6y   $��5��6�   $	��Top=�6�   $��84��6�   6�   �� 5%   
   -	   5         ��Name$ lblPageSize��5%      $��	Page Size��6%   $
��Left=�69   $��38��6T   $��
15,353,0,0q�6`   $	��Top=�6t   $��84��6�   �� 5&   
   $��Search:��6   $
��Left=�6"   $	��Top=�6=   $��53,5,0,0q�6U   $��26��6g   $��51��6s   �� 5'   
   -
   5         ��Name$ 	cboSortBy��5'      $
��Left=�6&   $	��Top=�6A   $��84��6Y   $��
10,103,0,0q�6d   6x   �� 5(   
   -   5        $ cboSortOrder��5(      $
��Left=�6)   $	��Top=�6D   $��84��6\   $��
10,156,0,0q�6g   6{   �� 5)   
   -   5        $ 	lblSortBy��5)      $��Sort By:��6#   $
��Left=�66   $��24��6Q   $��	10,74,0,0q�6]   $	��Top=�6p   $��84��6�   �� 5*   
   -   5        $ lblSortOrder��5*      $��Sort Order:��6&   $
��Left=�6<   $��24��6W   $��
10,127,0,0q�6c   $	��Top=�6w   $��84��6�   �� 5+   
   -   5        $ btnAdd��5+      $��Add New��6!   $
��Left=�63   $��27��6N   $��	687,5,0,0q�6Z   $	��Top=�6m   $��84��6�   6�   5-      5.      
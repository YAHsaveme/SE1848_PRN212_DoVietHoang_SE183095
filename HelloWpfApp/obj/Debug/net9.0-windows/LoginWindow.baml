   M S B A M L   `   `   `  ����F  BHelloWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HelloWpfAppHelloWpfApp  5   	       HelloWpfApp.LoginWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HelloWpfApp     5   	     � Title$   Đăng nhập hệ thống��5   	   $	��235��6$   $	��450��61    � WindowStartupLocation$ CenterScreen=�6=   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��4* �6   �� 5      .+�5   
   �� $+��%Đăng nhập hệ thống quản lý��6   $
��Left=�65   $��40,9,0,0q�6P   $	��Top=�6b   $��20(�6z   $
��Bold"�6�   ���	#FF217B4C$��2��6�   ���	#FFE4DDB9$	��324��6�   $��Center=�6�   �� 5   
   $��
_Username:��6   $
��Left=�5      $��	57,60,0,0q�6+   $	��Top=�6>   $��20(�6V    �� Target 5      ��  �� ElementName$ txtUserName��5   V   �� 5   
   -   5         ��Name$ txtUserName��5      $
��Left=�6'   $��
187,64,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��230��6�   $��20(�6�   $��2��6�   �� 5   
   $��
_Password:��6   $
��Left=�5      $��
70,109,0,0q�6+   $	��Top=�6?   $��20(�6W    5      �� $ txtPassword��5   W   G� 5   
   -   5         G�Name$ txtPassword��5      $
��Left=�6+   $��187,109,0,0q�6F   $	��Top=�6[   $	��230��6s   $��20(�6   $��2��6�   �� 5   
   -   5         ��Name$ btnDangNhap_��5      $��Đăng Nhập��6'   $
��Left=�6;   $��173,162,0,0q�6V   $	��Top=�6k   $��20(�6�   6�   �� 5   
   -   5        $ btnThoat��5      $��Thoát��6#   $
��Left=�63   $��325,162,0,0q�6N   $	��Top=�6c   $��20(�6{   $��92��6�   $��2��6�   6�   5      5      
   M S B A M L   `   `   `  ����   SimpleBookkeeping"    SimpleBookkeeping.EditWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  添加新记账��$	��400��$��209.6��.���  � ColumnDefinitions �� $	��45* ��� $	��26* ��� $
��322* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* �.+��� $��日期:��$��0��$��10,10,9.6,9.8q�$��3��(  "System.Windows.Controls.DatePicker  -     Name$ 
datePicker��$��0��$��8.8,10,9.6,9.8q�$��2��   SelectedDate �� *Date+�� $��详情:��$��1��$��10,10.2,9.6,10.2q�$��3���� -    ��Name$ descriptionTextBox��$��1��$��8.8,10.2,9.6,9.2q�$��2������ *Description+�� $��金额:��$��2��$��10,9.8,9.6,10q�$��3���� -   $ amountTextBox��$��2��$��8.8,9.8,9.6,10q�$��2������ *Amount+�� $��2��$��Right=� �� Orientation$ 
Horizontal=�$��0,40.8,9.6,0q�$	��133��$��4��$��2��.+��� -    ��Name$ OK��$��确认��$��
0 10 10 10q�$��14(�$��60���� -   $ Cancel��$��取消��$��
0 10 10 10q�$��14(�$��60��
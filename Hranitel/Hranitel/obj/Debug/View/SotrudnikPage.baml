   M S B A M L   `   `   `  ????C  ?Hranitel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Hranitel.ViewHranitel.View  5      !    Hranitel.View.SotrudnikPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Hranitel.View     5        N? Title$  SotrudnikPage??5	       N? 
Background
 ?????.??5      ?  ? RowDefinitions 5   
   ?? 5      $	??20* ?6   ?? 5      $	??60* ?6   ?? 5      $	??20* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgridZayavk??5       $??1??6      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Тип заявки??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6C   ?? *TypeZayavk.Name+
 ?? UpdateSourceTrigger$
 PropertyChanged=?6?     5      $# Выполнил заявку??6%   $ * 6>    . 	 6H   ?? *
User.FIO+$
 PropertyChanged=?6?     5      $ Дата заявки??6%   $ * 6:    . 	 6D   ?? *Dates+$
 PropertyChanged=?6?     5      $ Статус заявки??6%   $ * 6<   	 6G   ?? *Status+$
 PropertyChanged=?5      ?? 5   
   -   5        $??
Назад??5   #   $	??Top=?63   $??Right=?6K   $??20q?6h   5      5      
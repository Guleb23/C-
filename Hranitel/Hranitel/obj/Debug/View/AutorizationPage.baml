   M S B A M L   `   `   `  ????C  ?Hranitel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Hranitel.ViewHranitel.View  5      $    Hranitel.View.AutorizationPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Hranitel.View     5        N? Title$  AutorizationPage??5	       N? 
Background
 ?????.??5      ?  ? RowDefinitions 5   
   ?? 5      $	??20* ?6   ?? 5      $	??60* ?6   ?? 5      $	??20* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgridZayavk??5       $??1??6      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Тип заявки??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6C   ?? *TypeZayavk.Name+  5      $# Выполнил заявку??6%   $ * 6>   	 6H   ?? *
User.FIO+  5      $ Дата заявки??6%   $ * 6:   	 6D   ?? *Dates+  5      $ Статус заявки??6%   $ * 6<   	 6G   ?? *Status+5      ?? 5   
   -   5        $??
Назад??5      
???????$??Right=?64   $??20q?6P   6k   ?? 5   
   -   5        $??BtnAdd??5   ~   $??2??6   $??Подать заявку??6   
???????$??Right=?6I   $??20q?6e   6?   5      5      
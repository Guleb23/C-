   M S B A M L   `   `   `  ????C  ?Hranitel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Hranitel.ViewHranitel.View  5          Hranitel.View.ForOnePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Hranitel.View     5        N? Title$  
ForOnePage??5	       N? 
Background
 ?????.??5      ?  ? RowDefinitions 5   
   ?? 5      $	??30* ?6   ?? 5      $	??60* ?6   ?? 5      $	??10* ?6   .+?5   
   ? $??0,0,0,24q?6    ? ColumnDefinitions 5      ?? 5      $	??40* ?6#   ?? 5      $	??60* ?6#   .+?5      ??  ?? Orientation$ 
Horizontal=?6   
???????.+?5      ?? $??Выберите цель??6   $??20q?61   $??Center=?6>   $??Center=?6Y   6y   ?? 5      -   5         ??Name$ CmbCel??5   4   $	??150??6   $??20??6'    ?? DisplayMemberPath$
 Name??6D   6`   5      ?? 5      $??1??6   
???????$ 
Horizontal=?6@   .+?5      ?? $2??,Имя выполняющего заявку??6   $??21??6;   $??30q?6G   6V   ?? 5      -   5        $ CmbFio??5   3   $	??150??6   $??20??6'   $	 FIO??6C   6^   5      5      ? 5    
   $??	0,112,0,0q?6   $??2??6"   $	??237??63   $	??Top=?6@    5!      ?? 5"      $	??50* ?6#   ?? 5#      $	??50* ?6#   .+?5%      ?? $??0??6   $ Vertical=?6)   $	??237??6@   $??Center=?6M   $??	20 0 20 0q?6h   .+?5&      ?? $ 
Horizontal=?6   $??0 30 0 0q?66   .+?5'      ?? $??80??6    $??Имя??6+   68   ?? 5(      -   5         ??Name$ TxbName??5(   >   $	??150??6   $??
10 0 10 0 q?6*   6>   5)      ?? 5*      $ 
Horizontal=?6   $??0 20 0 0q?66   .+?5+      ?? $??80??6    $??Фамилия??6+   6<   ?? 5,      -   5        $ TxbLastName??5,   =   $	??150??6   $??	10 0 10 0q?6*   6U   5-      ?? 5.      $ 
Horizontal=?6   $??0 20 0 0q?66   .+?5/      ?? $??80??6    $??Отчество??6+   6=   ?? 50      -   5        $ TxbOtchestvo??50   =   $	??150??6   $??	10 0 10 0q?6*   6V   51      ?? 52      $ 
Horizontal=?6   $??0 20 0 0q?66   .+?53      ?? $??80??6    $??Телефон??6+   6<   ?? 54      -   5        $ TxbPhone??54   =   $	??150??6   $??	10 0 10 0q?6*   6R   55      ?? 56      $ 
Horizontal=?6   $??0 20 0 0q?66   .+?57      ?? $??80??6    $??
Емаил??6+   6:   ?? 58      -   5        $ TxbEmail??58   =   $	??150??6   $??	10 0 10 0q?6*   6R   59      5:      ?? 5;      $??1??6   $ Vertical=?6)   $	??237??6@   $??Center=?6M   .+?5<      ?? $ 
Horizontal=?6   $??0 30 0 0q?66   .+?5=      ?? $??80??6    $??Организация??6+   6@   ?? 5>      -   5        $ TxbOrganization??5>   =   $	??150??6   $??	10 0 10 0q?6*   6Y   5?      ?? 5@      $ 
Horizontal=?6   $??0 20 0 0q?66   .+?5A      ?? $??80??6    $??Примечание??6+   6?   ?? 5B      -	   5        $ 
TxbComment??5B   =   $	??150??6   $??	10 0 10 0q?6*   6T   5C      ?? 5D      $ 
Horizontal=?6   $??0 20 0 0q?66   .+?5E      ?? $??89??6    $??Дата рождения??6+   6B   (  "System.Windows.Controls.DatePicker  5F      -
   5          Name$ DatePic??5F   L   $	??150??6!   $??	10 0 10 0q?6-   $??30??6@   6`   5G      ?? 5H      $ 
Horizontal=?6   $??0 20 0 0q?66   .+?5I      ?? $??80??6    $??
Серия??6+   6:   ?? 5J      -   5        $ TxbSeria??5J   =   $	??150??6   $??	10 0 10 0q?6*   6R   5K      ?? 5L      $ 
Horizontal=?6   $??0 20 0 0q?66   .+?5M      ?? $??80??6    $??
Номер??6+   6:   ?? 5N      -   5        $ TxbNomer??5N   =   $	??150??6   $??	10 0 10 0q?6*   6R   5O      5P      5Q      ?? 5R   
   $??2??6   $??Center=?6"   .+?5S      ?? -   5        $??Подать??5S      
???????$	??100??6O   $??30??6[   $??20q?6h   5T      5U      5V      
   M S B A M L   `   `   `  ????C  ?Hranitel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Hranitel.ViewHranitel.View  5          Hranitel.View.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Hranitel.View     5        N? Title$  	LoginPage??5	       ? 	Resources 5
         Button.MouseOver.Background ?? Color  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  
CornerButt ?? 
TargetType ??Name ?? CornerRadius J? SnapsToDevicePixels ??Name ?? Triggers	 P? Property
 P? Value ?? 
TargetName ?? Value ?? Property??%?  &	        &	 #     &	 F     &	 i     &	 ?     &	 ?     &	 ?     &	 ?     7   7  7  7  7  7  7  ?? 5   
   $ 	#FFBEE6FD??6>   ?? 5   
   $ 	#FF3C7FB1??6:   ?? 5   
   $ 	#FFC4E5F6??6<   ?? 5   
   $ 	#FF2C628B??68   ?? 5   
   $ 	#FFF4F4F4??6=   ?? 5   
   $ 	#FFADB2B5??69   ?? 5   
   $ 	#FF838383??6=   ?? 5   
   " ??6-   .R?5      ?? $ border??6   $ 5??6%   #??z??67   
?????? #??z??6{    . ._?5      ?? $ contentPresenter??6#   |?.  #??z??6O   #??z??6?   ??. # z 6?   #??z??6  5       5      P? 5      	 ?@??IsDefaulted
 . . ?5      ?? $ border??64   # ? ??6H    ? ??5      P? 5      	 ?@J?IsMouseOver
 . . ?5      ?? $ border??63   8    ? ??6G   ?? 5      $ border??64   8   ? ??6H   5      P? 5      	 ? ??
 . . ?5      ?? $ border??63   8   ? ??6G   ?? 5       $ border??64   8   ? ??6H   5!      P? 5"      	 ? {?
 .  . ?5#      ?? $ border??63   8   ? ??6G   ?? 5$      $ border??64   8   ? ??6H   ?? 5%      $ contentPresenter??6?   8   ? ??6]   5&      5(      5)      .??5+      ? 
??????? ? ColumnDefinitions 5-   
   ?? 5.      $	??30* ?6   ?? 5/      $	??70* ?6   .+?51   
   ? $??0??6    ? RowDefinitions 52      ?? 53      $	??80* ?6    ?? 54      $	??20* ?6    .+?57      ?? $??0??6   $??15,100,15,10q?6&   $??2??6<   .+?58      ?? $??1??6   $???9Добро пожаловать в ХраниельПРО??6)   $??Bahnschrift SemiBold)?6O   $??12(?6q   $??0 0 0 10q?6   6?   ?? 59      $
??Left=?6   $??Введите логин??63   6N   ?? 5:      -   5         ??Name$ TxbLogin??5:   M   $??25??6   $	??200??6&   $
??Left=?62   .??6_    5;       ?? 
TargetType??%c   '??       ?? 5<      " ??6    .?5=      ??  ?@??CornerRadius$ 5??6=   6I   5>      5?      .??6)   5@      ?? 5A      $!??Введите пароль??6   $
??Left=?61   6O   G? 5B      -   5         G?Name$ TxbPassword??5B        PasswordBoxTemplate1#???  63   $??25??6f   $	??200??6r   $
??Left=?6~   5C      ?? 5D      -   5        $??1??5D      #???  6&   $??DemiBold"?6N   
??????? K? ZIndex$ 10??5E   $   $??Center=?66   $??Right=?6Q   $??	0 30 15 0q?6m   .??6?   
Войти6?   5F      ?? 5G      $??1??6    ?? Orientation$ 
Horizontal=?6&   $??Center=?6?   .+?5H      ?? $??1??6   $'??!Еще нету аккаунта???6*   $??16??6D   $??0 0 20 0q?6P   6d   ?? 5I      -   5        $??1??5I      #???  6&   
???????$??Регистрация??6b   $??30??5J   *   $	??100??66   6D   5K      5L      ?? 5M   
   $??2??6   $??UniformToFill=?6    ??5N      ?? 5O       ?? 	UriSource$ \Resources\img.jpg??6    ?? Rotation$ Rotate90=?6=   6S   5Q      5R      5S      
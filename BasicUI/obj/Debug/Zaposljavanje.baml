   M S B A M L   `   `   `  ????B  >BasicUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BasicUIBasicUI  5   	       BasicUI.Zaposljavanje   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BasicUI     5   	     ? Title$  Zaposljavanje??5   	   $	??450??6   $	??800??6,   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??1* ?6   6,   ?? 5      $??1* ?6   6,   ?? 5      $??1* ?6   6,   ?? 5      $??1* ?6   6,   ?? 5      $??1* ?6   6,   ?? 5      $??1* ?6   6,   ?? 5      $??1* ?6   6,    ? RowDefinitions 5   
   ?? 5      $??1* ?6   6*   ?? 5      $??1* ?6   6*   ?? 5      $??1* ?6   6*   ?? 5      $??1* ?6   6*   ?? 5      $??1* ?6   6*   ?? 5      $??1* ?6   6*   .+?5   
   ?? $??0??6   $??2??6   $??30(?5      $??Right=?5      $??Center=?5      $??DemiBold"?5       .??5!      Ime:6   ?? 5#   
   -   5         ??Name$ 
TextboxIme??5#      $??0??6&   $??2??63   $??4??6C   $	??300??6W    ?? TextAlignment$ Center=?6c   $??
ExtraLight"?5%      $??30(?5&      $??Center=?5'      $??Center=?5(      $??Italic$?5)      5*      ?? 5,   
   $??1??6   $??2??6   $??30(?5.      $??Right=?5/      $??Center=?50      $??DemiBold"?51      .??52      
Prezime:6   ?? 54   
   -   5        $ TextboxPrezime??54      $??1??6*   $??2??67   $??4??6G   $	??300??6[   $ Center=?6g   $??
ExtraLight"?56      $??30(?57      $??Center=?58      $??Center=?59      $??Italic$?5:      5;      ?? 5=   
   $??2??6   $??2??6   $??30(?5?      $??Right=?5@      $??Center=?5A      $??DemiBold"?5B      .??5C      
Kontakt:6   ?? 5E   
   -   5        $ TextboxKontakt??5E      $??2??6*   $??2??67   $??4??6G   $	??300??6[   $ Center=?6g   $??
ExtraLight"?5G      $??30(?5H      $??Center=?5I      $??Center=?5J      $??Italic$?5K      5L      ?? 5M   
   $??3??6   $??2??6   $??1??61   $??30(?5O      $??Center=?5P      $??Center=?5Q      $??DemiBold"?5R      .??5S      Odjel6   ?? 5T   
   $??3??6   $??2??6   $??4??61   $??30(?5V      $??Center=?5W      $??Center=?5X      $??DemiBold"?5Y      .??5Z      	Zanimanje6   ?? 5[   
   -   5         ??Name$ ComboboxOdjel??5[      $??4??5\      $??1??6    $??2??60   $??30??5]      $	??Top=?6   $??Stretch=?67    ?? 
IsEditable .  $??15(?5a      $??Center=?5b      $??Center=?5c      ??5^      ?? *Odjeli+5f      ?? 5g   
   -   5        $ ComboboxZanimanja??5g      $??4??6.   $??4??6;   $??2??6K   $??30??5h      $	??Top=?6   $??Stretch=?67    .  $??15(?5l      $??Center=?5m      $??Center=?5n      ??5i      ?? *	Zanimanja+5p      ?? 5q   
   -   5         ??Name$ 
GumbSpremi??5q      $??3??6%   $??5??65   $??50??6B   $	??Top=?6N   $	??100??6f   $??25(?5s      $??DemiBold"?5t      .??5v      Spremi6   5x      5y      
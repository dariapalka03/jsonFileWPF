   M S B A M L   `   `   `  ????C  ?JSONSave, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:JSONSaveJSONSave  5   	       JSONSave.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:JSONSave     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    J? CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$ local:CustomCommands.Add??5
      5        5   
   -   5        $ local:CustomCommands.Save??5      5      .??5      ]? .+?5   
   o? $	??Top=?6   .@?5      m? $??_Funkcje??6   .@?5      m?  m? Command$ local:CustomCommands.Save??6   m? 5      $ local:CustomCommands.Add??6   5      5      ?? 5   
   .+?5      ?? -   5         ??Name$ 
myListView??5       ?? View 5      ?? 5      P?5      ?? 5      $
??Imie??6-    ?? DisplayMemberBinding 6;   ?? *imie+?? 5      $??Nazwisko??6-    6?   ?? *
nazwisko+?? 5       $??Klasa??6-    6<   ?? *klasa+5"      5$      5%      5&      5'      
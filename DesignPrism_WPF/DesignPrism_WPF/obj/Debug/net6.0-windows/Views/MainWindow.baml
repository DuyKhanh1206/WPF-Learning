   M S B A M L   `   `   `  ����J  FDesignPrism_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DesignPrism_WPF.ViewsDesignPrism_WPF.Views  5   	   K*clr-namespace:DesignPrism_WPF.User_ControlDesignPrism_WPF.User_Control  5   	   &     DesignPrism_WPF.Views.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:DesignPrism_WPF.Views     5   	   Z VPrism.Unity.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5
   
   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   _	 [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 5   	   3uc*clr-namespace:DesignPrism_WPF.User_Control 	 5   	   -   5        $��frmMain_Window��5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ ホーム画面��5   	   $	��700��6   $	��900��6$   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadCommand+	   CommandParameter	 6D   �� 
 �� ElementName$
 frmMain_Window��6~   5      .��5       �  � RowDefinitions 5!   
   �� 5"      $
��auto �6   6,   �� 5#      6   .+�5&   
   � $��0��6   .+�5'      (   "DesignPrism_WPF.User_Control.BarUs  
 � Tag 6   �� *Title+$
 frmMain_Window��6L   5(      � 5)   
   $��1��6    � ColumnDefinitions 5*      �� 5+      $��8* �6#   60   �� 5,      $��* �6#   6/   .+�5/      � $��0��6    50      �� 51      $
��1.2* �6$   64   �� 52      $	��11* �6$   63   �� 53      $
��0.7* �6$   64   .+�56      � $��0��6   .+�57      )   #DesignPrism_WPF.User_Control.HeadUs  6"   58      � 5:      $��1��6   .+�5;      �� !  Prism.Regions.RegionManager   
RegionName$ ContentRegion��6$   5<      � 5>      $��2��6   .+�5?      1	   +DesignPrism_WPF.User_Control.CheckConnectUs	  $��Stretch=�6(   6I   5@      5A      � 5C      $��1��6   $��3q�6#   .+�5E      '
   !DesignPrism_WPF.Views.AllButtonUs
  6&   5F      5G      5H      5I      
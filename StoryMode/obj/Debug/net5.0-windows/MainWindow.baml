   M S B A M L   `   `   `  ����D  @StoryMode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Halcyon.StoryModeHalcyon.StoryMode  5   	   G(clr-namespace:Halcyon.StoryMode.RendererHalcyon.StoryMode.Renderer  5   	   A%clr-namespace:Halcyon.StoryMode.LogicHalcyon.StoryMode.Logic  5   	   "    Halcyon.StoryMode.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Halcyon.StoryMode     5   	   =renderer(clr-namespace:Halcyon.StoryMode.Renderer     5   	   7logic%clr-namespace:Halcyon.StoryMode.Logic     5   	   -   5          � Title$  
MainWindow��5
   	   $	��830��6   $
��1476��6)    � WindowState$ 	Maximized=�5   
    � WindowStyle$
 None=�5   	   .��5      � -   5        $
��grid��5      .+�5   
   (  "Halcyon.StoryMode.Renderer.Display  -   5          Name$ display��5      �� 5   
   $"��/Images/surfaceCollision.png��6   $
��Fill=�66   �� 5   
   -   5         ��Name$ 	dialogBox��5      $
��Fill=�6#   $	��266��62   $
��1309��6?   $��Bottom=�6L   $y�Hidden=�6g   .   (Halcyon.StoryMode.Logic.NavigationButton  5   
   -   5          Name$ trainingButton��5   !   .   (Halcyon.StoryMode.Logic.NavigationButton   Click$ EnterTraining_Click��69   $��980,990,197,27q�6U   $	��132��6m   $��64��6y   ${�False��6�   $y�Hidden=�6�     5   
   -   5        $ leaveButton��5   !   $ Leave_Click��66   $��1143,990,34,27q�6J   $	��132��6b   $��64��6n   ${�False��6z   $y�Hidden=�6�   5      5      
   M S B A M L   `   `   `  ����E  ALessonMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LessonMVVM.Views.WindowsLessonMVVM.Views.Windows  5   	   )    #LessonMVVM.Views.Windows.AddCarView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LessonMVVM.Views.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
AddCarView��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   �� $	��500��6   $��Center=�6!   $��Center=�6>   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��10 20q�62   .+�5      �� $��0 0 10 0q�6   $��70��6*   $
��Make��65   $��18(�6D   $
��Left=�6R   �� 5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Enter Make��5      $��Right=�5      $��18(�5      $	��400��5      ��5      �� *
car.Make+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      5      �� 5      $ 
Horizontal=�6   $��10 20q�62   .+�5      �� $��0 0 10 0q�6   $��70��6*   $��Model��65   $��18(�6E   $
��Left=�6S   �� 5      $ Enter Model��5      $��Right=�5      $��18(�5      $	��400��5       ��5      �� *	car.Model+$ TwoWay=�$ PropertyChanged=�5       5"      �� 5%      $ 
Horizontal=�6   $��10 20q�62   .+�5&      �� $��0 0 10 0q�6   $��70��6*   $
��Date��65   $��18(�6D   $
��Left=�6R   (  "System.Windows.Controls.DatePicker  5'      $��Right=�5)      $	��400��5*      $��18(�5+      $ 	Pick Date��5,         SelectedDate 5(      �� *
car.Date+$ TwoWay=�$ PropertyChanged=�5,      5.      �� 50      $ 
Horizontal=�6   $��Center=�62   $��10q�6O   .+�54      �� $
��Save��56      $	��100��6$   $��10q�60   ��55      �� *SaveCommand+56   0   �� 58      $��Cancel��5<      $	��100��6&   $��10q�62   ��59      �� *CancelCommand+��5:      ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �5<   2   5?      5A      5C      5D      
   M S B A M L   `   `   `  ����L  HEstacionamientoNe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EstacionamientoNeEstacionamientoNe  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	   I EMetroChart.WPF, Version=0.0.0.3, Culture=neutral, PublicKeyToken=nullG4clr-namespace:MetroChart.WPF;assembly=MetroChart.WPFMetroChart.WPF 5	   	   !    EstacionamientoNe.Historial   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:EstacionamientoNe     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   >Wpf4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5   	   E
MetroChart4clr-namespace:MetroChart.WPF;assembly=MetroChart.WPF  5	   	     � Title$  	Historial��5   	   $	��600��6   $
��1080��6(    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � WindowStyle$
 None=�6p   
�������.��5      � 
�������$��
0,-12,0,12q�6"   .+�5   
   � $��60��6   $	��Top=�6   ���	#FF3A49DE.+�5      �� $��Estacionamiento��6   $��Center=�6/   $��Center=�6L   $��22(�6g   �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5      �� -   5         ��Name$ BtnRegresarMenu��5      $��60��6H   $��30��6S   $��Center=�6`   $��Right=�6{   ��62   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF0A1636�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6F   $��25��6S   $��25��6^   5      5      5      �� 5   
   $��30(�6   $��Generar Reporte��6   $
��Left=�69   $��51��6T   $��419,505,0,0q�6`   $	��Top=�6u   $	��276��6�   � 5   
   $��240,90,240,150q�6   $	��600��6'    J� OpacityMask 5      !� 5       !� Visual 6   �� 	 �� ElementName$	 BorderG2��.+�5      �� -   5        
 ��Name$
 BorderG2��5       �� CornerRadius$ 15��6'   ���	#FF340051$��-194,0,194,0q�6P   %  MetroChart.WPF.RadialGaugeChart  5        MetroChart.WPF.ChartBase   
ChartTitle$ Disponibilidad��6@      ChartSubTitle$  ��6\   
�������$��
-80,0,80,0q�6�   ��6*   Z�    Series 5!         MetroChart.WPF.ChartSeries     DisplayMember$ Titulo��5"   )      SeriesTitle$ Consumo��5$   )      ValueMember$ Porcentagem��5%   )   $��Center=�6C   ��5#   )   ��  �� Path$ Consumo�5%   C   5'      �� 5(      $��132,89,212,68q�6   $%��PARKING_CENTROS_COMERCIALES.jpg��6+   $
��Fill=�6T   5)      &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ llenar��5*      $
��Left=�6#   $	��360��6>   $��
664,90,0,0q�6K   $	��Top=�6_   $	��406��6w   5,      5-      
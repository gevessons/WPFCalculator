   M S B A M L   `   `   `  ����F  BCalculadora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CalculadoraCalculadora  5   	       Calculadora.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Calculadora     5   	     � Title$  
MainWindow��5   	   $	��525��6   $	��350��6)   .��5	      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ resultadoLabel��5"      $��0��5      $��Right=�5      $��Bottom=�5      $��60(�5       $��4��5!      5"      �� 5$   
   -   5         ��Name$ acBoton��5$      $��AC��5%      $��1��5&      $��5q�5'      $
��Bold"�5(      $��14(�5)      �� 5+   
   -   5        $ negativoBoton��5+      $	��-/+��5,      $��1��5-      $��1��5.      $��5q�5/      $
��Bold"�50      $��14(�51      �� 53   
   -   5        $ porcentagemBoton��53      $��%��54      $��1��55      $��2��56      $��5q�57      $
��Bold"�58      $��14(�59      �� 5<   
   -   5        $ divisionBoton��5<      $��/��5>      $��1��5?      $��3��5@      $��5q�5A      $
��Bold"�5B      $��14(�5C      �� 5E   
   -   5        $ multiplicacaoBoton��5E      $��*��5G      $��2��5H      $��3��5I      $��5q�5J      $
��Bold"�5K      $��14(�5L      �� 5N   
   -   5        $ 
menosBoton��5N      $��-��5P      $��3��5Q      $��3��5R      $��5q�5S      $
��Bold"�5T      $��14(�5U      �� 5W   
   -   5        $ 	maisBoton��5W      $��+��5Y      $��4��5Z      $��3��5[      $��5q�5\      $
��Bold"�5]      $��14(�5^      �� 5`   
   -	   5        $ 
igualBoton��5`      $��=��5a      $��5��5b      $��3��5c      $��5q�5d      $
��Bold"�5e      $��14(�5f      �� 5h   
   -
   5        $ 
pontoBoton��5h      $��,��5i      $��5��5j      $��2��5k      $��5q�5l      $
��Bold"�5m      $��14(�5n      �� 5r   
   -   5        $ 	zeroBoton��5r      $��0��5t      $��2��5u      $��5��5v      $��0��5w      $��5q�5x      $
��Bold"�5y      $��14(�5z      �� 5|   
   -   5        $ umBoton��5|      $��1��5~      $��4��5      $��0��5�      $��5q�5�      $
��Bold"�5�      $��14(�5�      �� 5�   
   -   5        $ 	doisBoton��5�      $��2��5�      $��4��5�      $��1��5�      $��5q�5�      $
��Bold"�5�      $��14(�5�      �� 5�   
   -   5        $ 	tresBoton��5�      $��3��5�      $��4��5�      $��2��5�      $��5q�5�      $
��Bold"�5�      $��14(�5�      �� 5�   
   -   5        $ quatroBoton��5�      $��4��5�      $��3��5�      $��0��5�      $��5q�5�      $
��Bold"�5�      $��14(�5�      �� 5�   
   -   5        $ 
cincoBoton��5�      $��5��5�      $��3��5�      $��1��5�      $��5q�5�      $
��Bold"�5�      $��14(�5�      �� 5�   
   -   5        $ 	seisBoton��5�      $��6��5�      $��3��5�      $��2��5�      $��5q�5�      $
��Bold"�5�      $��14(�5�      �� 5�   
   -   5        $ 	seteBoton��5�      $��7��5�      $��2��5�      $��0��5�      $��5q�5�      $
��Bold"�5�      $��14(�5�      �� 5�   
   -   5        $ 	oitoBoton��5�      $��8��5�      $��2��5�      $��1��5�      $��5q�5�      $
��Bold"�5�      $��14(�5�      �� 5�   
   -   5        $ 	noveBoton��5�      $��9��5�      $��2��5�      $��2��5�      $��5q�5�      $
��Bold"�5�      $��14(�5�      5�      5�      
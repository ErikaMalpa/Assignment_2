   M S B A M L   `   `   `  ���� A  =Tandem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Tandem.ViewTandem.View  3clr-namespace:Tandem.ViewModelTandem.ViewModel      Tandem.View.SignUp   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:Tandem.View     4	viewModelclr-namespace:Tandem.ViewModel       � Title$  Sign Up��$	��450��$	��625�� � 	Resources '   !Tandem.ViewModel.StudentViewModel   StudentViewModel  EllipseBlackStyle �� Property �� Value  	MenuStyle  TextBoxStyle  TextBlockStyle  ButtonStyle  ListViewStyle��%�  &	        &	      &	 �     &	 u    &	 �    &	 �    &	       �� .���  � �� �	#FF191919��  � ��$
 Left=���  � ��$ 159.226����  � ��$ -98.367,-53.166,-15.523,0q���  � ��$	 Top=���  � ��$ 732.49����  �@J�RenderTransformOrigin$ 0.5,0.5&��� .���  � ��$
 Left=���  � ��$
 22.4����  � ��$	 Top=���  � ��$ 128.933����  � �� �	#FF191919�� .���  � ��$ Right=���  � ��$
 Auto����  �@��TextWrapping$
 Wrap=��� .���  � ��$	 Top=���  � ��$ 17.457����  � ��$
 Wrap=���  �@J�RenderTransformOrigin$ 0.376,1.303&���  � ��$ 16(���  � ��$
 Bold"���  � �� �	#FF191919�� .���  � ��$	 Top=���  � ��$
 Left=���  � ��$ 210.6,294.096,0,0q���  � ��$ 147.2���� .���  � ��$
 Auto����  � ��$ 10,47.896,10,65.4q���  �@J�RenderTransformOrigin$ 
-0.55,3.17&�.��� ���	#FFDFE2DB � DataContext ��  �� Source# [   � ColumnDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 � � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �$��1���� �� $��20 �.+��� $
��Left=�$��50.693��$��10,85.533,0,0q�$
��Wrap=�$	��Top=�$��558.6��$��16(�$��5��$��7���� $�Are you ���� $J�Dinterested in learning a new language while also meeting new people?���� �� $V�PIf yes then please sign up and we will email you when we find a partner for you.��A� #��[ $��-94.967,-58.766,-18.923,0q�
���   �$��7��$��8��z�V� .~��� �� ��  �� Angle$ -5.622Q�T� �� -   $��TextBox1��#��[ $��5��$��0,144.2,309.4,214q�$��7��$	��165������ *Student.studentFirstName+�� #��[ $��5��$
��Left=�$��20.774��$��10,141.226,0,0q�$��7��$��90��
First Name�� #��[ $��5��$
��Left=�$��25.774��$��
10,167,0,0q�$��7��$��90��	Last Name�� -   $��TextBox2��#��[ $��5��$��0,170.2,308.4,188q�$��7��$	��165������ *Student.studentLastName+�� #��[ $��5��$
��Left=�$��25.774��$��10,192.774,0,0q�$��7��$��90��Email�� #��[ $��5��$
��Left=�$��25.774��$��10,218.548,0,0q�$��7��$��195.6��Language I can Teach:�� #��[ $��5��$
��Left=�$��25.774��$��10,244.322,0,0q�$��7��$	��186��Language that I want:�� -   $��TextBox3��#��[ $��5��$��0,196.2,308.4,162q�$��7��$	��165������ *Student.studentEmail+�� -   $��TextBox4��#��[ $��5��$��0,222.2,47.4,136q�$��7��$	��338������ *Student.studentMotherTongue+�� -   $��TextBox5��#��[ $��5��$��0,248.2,45.4,109q�$��7��$	��338������ *Student.studentLanguageWanted+�� -   #��[ $��Submit��$��5��$
��27.2��$��7������ *SubmitButton+o� #��[ $��5��$��	10,10,0,0q�$��7��$��176.933��.@�m� -   $
��Home��$
��22.4��$
��66.4�����	#FF191919���	#FFF4F4F5���	#FF191919m� -   $��Coffee Meeting��$
��22.4��$��110.533�����	#FF191919���	#FFF4F4F5���	#FF191919� -	   $��
TablePopup��$	��Top=�	 � AllowsTransparency	 . .��� $��250.176��$��496.77��.+��� #��[ ���� *
Students+
 �� View
 �� .P��� $��
First Name�� �� Width$
 Auto�� �� DisplayMemberBinding �� *studentFirstName+�� $��	Last Name��$
 Auto�� �� *studentLastName+�� $��Email��$
 Auto�� �� *studentEmail+�� $��Language Offered��$
 Auto�� �� *studentMotherTongue+�� $��Language Wanted��$
 Auto�� �� *studentLanguageWanted+
# App Theming in Xamarin.Forms 5
Xamarin.Forms 5 application that includes support for Dark and Light theme

This application uses two different Resource dictionaries and DynamicResource to change between Dark and Light Theme on iOS and Android (UWP is also supported but you should add the UWP head)

The application supports applying the Operating system Theme or you can manually change it

Whe you manually switch between Light and Dark there seems to be a bug in the Xamarin.Forms framework and the Background color of the page does not switch between Dark and LIght. This is why you will see that I have also applied the BackgroundColor at the Page level. It is not necessary to do that if you want to support only automatic theme changing by the OS (in that case the switch works correctly)

You can also use the AppThemeBinding extension (see MainPage.xaml) to change between Dark and Light colors but in this case you will need to have both dictionaries loaded in memory (Dark and Light colors). AppThemeBinding extension under the hood will have to listen to the changes of the theme and switch colors but I did not compare speed to see which of the two is more performant: DynamicResource or AppThemeBinding. 

I did not measure the performance impact when using DynamicResource or AppThemeBinding markup extension instead of using StaticResource.




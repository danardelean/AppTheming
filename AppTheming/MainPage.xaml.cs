using Xamarin.Forms;

namespace AppTheming
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();
        }

        public bool UseDarkMode
        {
            get=> App.Current.UserAppTheme == OSAppTheme.Dark;
            set
            {
                if (value)
                {
                    App.Current.UserAppTheme = OSAppTheme.Dark;
                    OnPropertyChanged(nameof(UseLightMode));
                    OnPropertyChanged(nameof(UseDeviceThemeSettings));
                    OnPropertyChanged(nameof(UseLightMode));
                }
            }
        }
        public bool UseLightMode
        {
            get => App.Current.UserAppTheme == OSAppTheme.Light;
            set
            {
                if (value)
                {
                    App.Current.UserAppTheme = OSAppTheme.Light;
                    OnPropertyChanged(nameof(UseDarkMode));
                    OnPropertyChanged(nameof(UseDeviceThemeSettings));
                    OnPropertyChanged(nameof(UseLightMode));
                }
            }
        }

        public bool UseCustomThemeSettings
        {
            get => !UseDeviceThemeSettings;
        }

        public bool UseDeviceThemeSettings
        {
            get => App.Current.UserAppTheme == OSAppTheme.Unspecified;
            set
            {
                if (value)
                {
                    App.Current.UserAppTheme = OSAppTheme.Unspecified;
                    OnPropertyChanged(nameof(UseDarkMode));
                    OnPropertyChanged(nameof(UseLightMode));
                }
                else
                    UseLightMode = true;

                OnPropertyChanged(nameof(UseCustomThemeSettings));
            }

        }
    }
}

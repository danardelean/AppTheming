using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTheming
{
    public partial class App : Application
    {
        public App()
        {
            // Device.SetFlags(new string[] { "AppTheme_Experimental" });
            Application.Current.RequestedThemeChanged += (s, a) =>
            {
                LoadResourceDictionaries();
            };
            LoadResourceDictionaries();

            MainPage = new MainPage();
        }
        OSAppTheme? currentLoaded;
        void LoadResourceDictionaries()
        {
            if (currentLoaded.HasValue && currentLoaded.Value == Application.Current.RequestedTheme)
                return;

            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                if (Application.Current.RequestedTheme == OSAppTheme.Dark)
                    mergedDictionaries.Add(new ResourceDictionaries.DarkColors());
                else
                    mergedDictionaries.Add(new ResourceDictionaries.LightColors());
            }
        }

       

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

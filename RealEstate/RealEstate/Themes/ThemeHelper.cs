using RealEstate.Models;
using Xamarin.Forms;

namespace RealEstate.Themes
{
    public static class ThemeHelper
    {
        public static void ChangeTheme(Theme theme, bool forceTheme = false)
        {
            // don't change to the same theme
            if (theme == Settings.ThemeOption && !forceTheme)
                return;

            //// clear all the resources
            var applicationResourceDictionary = Application.Current.Resources;



            ResourceDictionary newTheme;

            if (theme == Theme.Light)
            {
                newTheme = new LightTheme();
            }
            else
            {
                newTheme = new DarkTheme();
            }

            ManuallyCopyThemes(newTheme, applicationResourceDictionary);

            Settings.ThemeOption = theme;
        }

        static void ManuallyCopyThemes(ResourceDictionary fromResource, ResourceDictionary toResource)
        {
            foreach (var item in fromResource.Keys)
            {
                toResource[item] = fromResource[item];
            }
        }
    }
}

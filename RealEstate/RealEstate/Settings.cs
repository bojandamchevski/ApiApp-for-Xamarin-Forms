using RealEstate.Models;
using Xamarin.Essentials;

namespace RealEstate
{
    public static class Settings
    {
        public static Theme ThemeOption
        {
            get => (Theme)Preferences.Get(nameof(ThemeOption),  (int)Theme.Light);
            set => Preferences.Set(nameof(ThemeOption), (int)value);
        }
    }
}

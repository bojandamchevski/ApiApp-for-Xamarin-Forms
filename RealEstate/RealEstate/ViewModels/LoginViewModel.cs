using System.Windows.Input;
using RealEstate.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RealEstate.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            if (Preferences.ContainsKey(PreferenceKeys.IsUserLoggedInKey)
                && Preferences.Get(PreferenceKeys.IsUserLoggedInKey, false))
            {
                Shell.Current.GoToAsync($"//{nameof(ListPage)}");
            }
        }

        public ICommand LoginCommand => new Command(async () =>
        {
            Preferences.Set(PreferenceKeys.IsUserLoggedInKey, true);
            await Shell.Current.GoToAsync($"//{nameof(ListPage)}");
        });
    }
}

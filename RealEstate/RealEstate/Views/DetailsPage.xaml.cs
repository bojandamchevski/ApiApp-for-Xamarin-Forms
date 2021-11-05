using RealEstate.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace RealEstate.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var viewModel = (DetailsViewModel)BindingContext;

            var position = new Position(viewModel.Latitude, viewModel.Latitude);

            var pin = new Pin()
            {
                Type = PinType.Place,
                Position = position,
                Label = viewModel.ContactPersonName,
                Address = viewModel.Address
            };

            myMap.Pins.Add(pin);

            myMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(10)));
        }
    }
}

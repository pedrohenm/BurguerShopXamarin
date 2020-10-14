using BurguerShopXamarin.Model;
using BurguerShopXamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BurguerShopXamarin.ViewModel
{
    public class LandingViewModel : BaseViewModel
    {
        public LandingViewModel()
        {
            burgers = GetBurgers();
        }

        ObservableCollection<Burger> burgers;

        public ObservableCollection<Burger> Burgers
        {
            get { return burgers; }
            set
            {
                burgers = value;
                OnPropertyChanged();
            }
        }

        private Burger selectedBurger;

        public Burger SelectedBurger
        {
            get { return selectedBurger; }
            set
            {
                selectedBurger = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectedCommand => new Command(DisplayBurger);

        private void DisplayBurger()
        {
            if(selectedBurger != null)
            {
                var viewModel = new DetailsViewModel { SelectedBurger = selectedBurger, Burgers = burgers, Position = burgers.IndexOf(selectedBurger) };
                var detailsPage = new DetailsPage { BindingContext = viewModel };

                var navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(detailsPage, true);
            }
        }


        private ObservableCollection<Burger> GetBurgers()
        {
            return new ObservableCollection<Burger>
            {
                new Burger { Name = "CLASSIC", Price = 12.99f, Image = "classic.png", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea"},
                new Burger { Name = "DOUBLE", Price = 19.99f, Image = "two.png", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea"},
                new Burger { Name = "SHARK", Price = 17.99f, Image = "shark.png", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea"},
                new Burger { Name = "CHICKEN", Price = 15.99f, Image = "chicken.png", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea"},
                new Burger { Name = "MEAT", Price = 11.99f, Image = "meat.png", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea"},
                new Burger { Name = "BBQ", Price = 13.99f, Image = "bbq.png", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea"}
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DersTekrar.Models;
using DersTekrar.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersTekrar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentView : ContentPage
    {
        public StudentView()
        {
            InitializeComponent();
            
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;

            var name = (e.SelectedItem as Student).Name;
            DisplayAlert("Merhaba", "Merhaba " + name, "OK");
        }
    }
}
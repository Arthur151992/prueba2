using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using PMO2EXAMEN3.Models;
using PMO2EXAMEN3.controller;
using PMO2EXAMEN3.ModelView;

namespace PMO2EXAMEN3
{
    public partial class MainPage : ContentPage
    {  
 
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModelPersons();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void lista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}

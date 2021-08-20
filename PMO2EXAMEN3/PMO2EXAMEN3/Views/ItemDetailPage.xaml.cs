using PMO2EXAMEN3.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PMO2EXAMEN3.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
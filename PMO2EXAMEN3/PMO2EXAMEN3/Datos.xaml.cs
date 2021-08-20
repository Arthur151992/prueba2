using PMO2EXAMEN3.ModelView;
using PMO2EXAMEN3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PMO2EXAMEN3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Informacion : ContentPage
    {
        public Informacion()
        {
            InitializeComponent();
            BindingContext = new ViewModelPersons();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}

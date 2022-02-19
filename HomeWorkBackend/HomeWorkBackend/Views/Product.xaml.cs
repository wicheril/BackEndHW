using HomeWorkBackend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeWorkBackend.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Product : ContentPage
    {
        private readonly ProductViewModel _vm = new ProductViewModel();
        public Product()
        {
            InitializeComponent();
            BindingContext = _vm;
        }

    }
}
using System.ComponentModel;
using Xamarin.Forms;
using xshell10.ViewModels;

namespace xshell10.Views
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
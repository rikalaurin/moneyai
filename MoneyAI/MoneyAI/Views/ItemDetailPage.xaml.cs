using MoneyAI.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MoneyAI.Views
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
using CalculateurAge.ViewModels;
using CalculateurAge.Views;

namespace CalculateurAge;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var vm = new CalculateurViewModel();
        vm.DetailDemande += async (nom, age) =>
            await Shell.Current.GoToAsync($"{nameof(ResultatPage)}?nom={nom}&age={age}");
        BindingContext = vm;
    }
}

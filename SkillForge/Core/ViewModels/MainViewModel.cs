using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MPowerKit.Navigation.Interfaces;

namespace SkillForge.Core.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    private readonly INavigationService _navigationService;
    
    public MainViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        buttonColor = Colors.Red;
    }

    [ObservableProperty] 
    private Color buttonColor;

    [RelayCommand]
    private async Task OpenSecondPage()
    {
        var result = await _navigationService.NavigateAsync("SecondPage", null, false);
    }
}
using CommunityToolkit.Mvvm.ComponentModel;
using MPowerKit.Navigation.Awares;
using MPowerKit.Navigation.Interfaces;

namespace SkillForge.Core.ViewModels;

public partial class BaseViewModel : ObservableObject, IInitializeAware, INavigationAware
{
    [ObservableProperty]
    private bool isBusy;
    
    public virtual void OnNavigatedTo(INavigationParameters navigationParameters)
    {
    }

    public virtual void OnNavigatedFrom(INavigationParameters navigationParameters)
    {
    }

    public virtual void Initialize(INavigationParameters parameters)
    {
    }
}
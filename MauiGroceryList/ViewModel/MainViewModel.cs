using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiGroceryList.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        // add item to list
        Items.Add(Text);

        // clear text box
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (items.Contains(s))
        {
            Items.Remove(s);
        }
    }
}

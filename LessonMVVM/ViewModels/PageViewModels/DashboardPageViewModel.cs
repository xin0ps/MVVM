using LessonMVVM.Commands;
using LessonMVVM.Models;
using LessonMVVM.Services;
using LessonMVVM.ViewModels.WindowViewModels;
using LessonMVVM.Views.Pages;
using LessonMVVM.Views.Windows;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace LessonMVVM.ViewModels.PageViewModels;

public class DashboardPageViewModel : NotificationService
{
    public ObservableCollection<Car> Cars { get; set; }
  

    public ICommand? AddViewCommand { get; set; }
    public ICommand? RemoveCommand { get; set; }

    public ICommand? getAllCommand { get; set; }
    public ICommand? Back { get; set; }




    public DashboardPageViewModel()
    {
        Cars = new ObservableCollection<Car>()
        {
            new("Audi", "Q8", new DateTime(2022, 10, 11)),
            new("Audi", "Q7", new DateTime(2022, 10, 11)),
            new("Hyudai", "Accent", new DateTime(2022, 10, 11)),
            new("Hyudai", "Elantra", new DateTime(2022, 10, 11)),
            new("Kia", "K5", new DateTime(2022, 10, 11)),
        };

        AddViewCommand = new RelayCommand(AddCarView);
        getAllCommand = new RelayCommand(getAll);
        Back = new RelayCommand(back);
        RemoveCommand = new RelayCommand(Remove,CanRemove);
    }


    public void Remove(object? parameter)
    {
        Car? cr = parameter as Car;
        if(cr != null)
        {
            Cars.Remove(cr);
        }
    }
    private bool CanRemove(object? parameter)
    {
        return parameter != null;
    }
    public void back(object? parameter)
    {
        var window = parameter as Page;
        if (window != null)
        {
            window.NavigationService.GoBack();
        }
    }

    public void AddCarView(object? parameter)
    {
        var addView = new AddCarView();
        addView.DataContext = new AddCarViewModel(Cars);
        addView.ShowDialog();
    }

    public void getAll(object? parameter)
    {
        var window = parameter as Page;
     if(window != null)
        {
            window.NavigationService.Navigate(new GetAllPage());
        }
    }
    
}

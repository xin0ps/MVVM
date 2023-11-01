using LessonMVVM.Commands;
using LessonMVVM.Models;
using LessonMVVM.Services;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace LessonMVVM.ViewModels.WindowViewModels;

public class AddCarViewModel : NotificationService
{
    private Car? car1;
    public Car? car { get => car1; set { car1 = value; OnPropertyChanged(); } }

    public ObservableCollection<Car> Cars { get; set; }


    public ICommand? SaveCommand{ get; set; }
    public ICommand? CancelCommand{ get; set; }
    public AddCarViewModel()
    {
        
    }

    public AddCarViewModel(ObservableCollection<Car> cars)
    {
        Cars = cars;
        car = new();

        SaveCommand = new RelayCommand(Save, CanSave);
         CancelCommand = new RelayCommand(CancelWindow);

    }

    public void CancelWindow(object? parameter)
    {
        var window = parameter as Window;

        if(window != null)
        {
            window.Close();
        }
    }


    public void Save(object? parameter)
    {
        Cars.Add(car!);
        car = new();
    }
    public bool CanSave(object? parameter)
    {
        return !string.IsNullOrEmpty(car!.Make) && 
               !string.IsNullOrEmpty(car!.Model) &&
               car.Date != null;
    }




}

﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LessonMVVM.Services;

public abstract class NotificationService :INotifyPropertyChanged
{

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

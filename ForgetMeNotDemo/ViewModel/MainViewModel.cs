﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
namespace ForgetMeNotDemo.ViewModel;

[ObservableObject]
public partial class MainViewModel
{
    [ObservableProperty]
    private string fullName;

    [ObservableProperty]
    private string age;
}

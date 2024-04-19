using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppName.VIewModels;

public partial class NameViewModel : ObservableObject
{
    [ObservableProperty]
    string _name = string.Empty;


}

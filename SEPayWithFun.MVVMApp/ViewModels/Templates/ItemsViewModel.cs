﻿//@CodeCopy
using Avalonia.Controls;
using SEPayWithFun.MVVMApp.Models.Templates;
using System;

namespace SEPayWithFun.MVVMApp.ViewModels.Templates
{
    public partial class ItemsViewModel : GenericItemsViewModel<ItemModel>
    {
        protected override GenericItemViewModel<ItemModel> CreateViewModel()
        {
            throw new NotImplementedException();
        }

        protected override Window CreateWindow()
        {
            throw new NotImplementedException();
        }
    }
}

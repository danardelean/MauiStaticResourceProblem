using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace StaticResourceProblem.ViewModels
{
	public partial class BaseViewModel:ObservableObject
	{
		[ObservableProperty]
		string _title;

        [ObservableProperty]
        bool _isBusy;

	}
}


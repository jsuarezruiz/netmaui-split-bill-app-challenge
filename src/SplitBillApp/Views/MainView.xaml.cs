using SplitBillApp.ViewModels;

namespace SplitBillApp.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel viewModel)
	{
        InitializeComponent();

        BindingContext = viewModel;
    }
}
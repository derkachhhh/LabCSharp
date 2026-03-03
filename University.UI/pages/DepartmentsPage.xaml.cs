using University.Models.Data;
using University.Services.Storage;

namespace University.UI;

public partial class DepartmentsPage : ContentPage
{
    private readonly IUniversityStorageService _storage;

    public DepartmentsPage(IUniversityStorageService storage)
    {
        InitializeComponent();
        _storage = storage;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        DepartmentsList.ItemsSource = _storage.GetDepartments();
    }

    private async void OnDepartmentTapped(object sender, TappedEventArgs e)
    {
        if (sender is BindableObject bindable &&
            bindable.BindingContext is DepartmentData department)
        {
            await Navigation.PushAsync(new DepartmentDetailsPage(_storage, department));
        }
    }
}
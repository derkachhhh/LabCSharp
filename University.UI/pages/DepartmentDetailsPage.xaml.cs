using University.Models.Data;
using University.Services.Storage;
using University.UI.Helpers;

namespace University.UI;

public partial class DepartmentDetailsPage : ContentPage
{
    private readonly IUniversityStorageService _storage;
    private readonly DepartmentData _department;

    public DepartmentDetailsPage(IUniversityStorageService storage, DepartmentData department)
    {
        InitializeComponent();
        _storage = storage;
        _department = department;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        TitleLabel.Text = _department.Name;
        InfoLabel.Text = $"Тип: {TextFormat.DepartmentTypeUa(_department.Type)} | Корпус: {_department.Building}";

        TeachersList.ItemsSource = _storage.GetTeachersByDepartmentId(_department.Id);
    }

    private async void OnTeacherTapped(object sender, TappedEventArgs e)
    {
        if (sender is BindableObject b && b.BindingContext is TeacherData teacher)
        {
            await Navigation.PushAsync(new TeacherDetailsPage(teacher));
        }
    }
}
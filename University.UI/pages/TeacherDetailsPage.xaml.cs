using University.Models.Data;
using University.UI.Helpers;

namespace University.UI;

public partial class TeacherDetailsPage : ContentPage
{
    private readonly TeacherData _teacher;

    public TeacherDetailsPage(TeacherData teacher)
    {
        InitializeComponent();
        _teacher = teacher;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        NameLabel.Text = _teacher.FullName;
        RankLabel.Text = $"Посада: {TextFormat.RankUa(_teacher.Rank)}";
        EmailLabel.Text = $"Email: {_teacher.Email}";
        ExpLabel.Text = $"Досвід: {_teacher.ExperienceYears} років";
    }
}
namespace University.UI;

public partial class App : Application
{
    private readonly DepartmentsPage _startPage;

    public App(DepartmentsPage startPage)
    {
        InitializeComponent();
        _startPage = startPage;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var nav = new NavigationPage(_startPage);
        return new Window(nav);
    }
}
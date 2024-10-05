namespace ProgPals.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public string Greeting => "This is the Main Window! Huzzah!";
        public string ProfileName { get; set; } = "John Doe";
#pragma warning restore CA1822 // Mark members as static
    }
}


namespace XamarinPruebas.InfraStructure
{
    using ViewModels;

    class InstanceLocator
    {
        public MainViewModel Main { get; set; }
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}

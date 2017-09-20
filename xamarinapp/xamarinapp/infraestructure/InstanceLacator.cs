

namespace xamarinapp.infraestructure
{
    using ViewModel;
    public class InstanceLacator
    {
        public MainViewModel Main { get; set; }

        public InstanceLacator()
        {
            Main = new MainViewModel();
        }
    }
}

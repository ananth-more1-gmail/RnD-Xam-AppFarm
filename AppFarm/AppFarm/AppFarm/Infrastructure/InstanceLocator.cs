using AppFarm.ViewModels;

namespace AppFarm.Infrastructure
{
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }

        #endregion

        #region Constructor
        public InstanceLocator()
        {
        } 
        #endregion
    }
}

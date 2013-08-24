using Ninject;
using Ninject.Web;

namespace FootballSim
{
    public class View<T> : PageBase where T : IController
    {
        [Inject]
        public T Controller
        {
            get { return (T) Session[(typeof (T)).Name]; } 
            set { Session[(typeof (T)).Name] = value; }
        }
    }
}
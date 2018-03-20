using System.Windows.Forms;
using DBMS.Controllers.DB;

namespace DBMS.Controllers
{
    public interface IViewHandler
    {
        /// <summary>
        /// Navigates to the given form.
        /// </summary>
        /// <param name="form">The form to be navigated.</param>
        void NavigateTo(IViewHandler form);

        void Activate(Form sender, User user = null);
    }
}

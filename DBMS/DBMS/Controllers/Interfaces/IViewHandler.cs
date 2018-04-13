using System.Windows.Forms;

namespace DBMS.Controllers.Interfaces
{
    public interface IViewHandler : IDestroyable
    {
        /// <summary>
        /// Navigates to the given form.
        /// </summary>
        /// <param name="form">The form to be navigated.</param>
        void NavigateTo(IViewHandler form);

        void Activate(Form sender);
    }
}

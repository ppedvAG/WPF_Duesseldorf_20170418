using System.Windows;

namespace HalloMVVM.Helpers
{
    public class MessageBoxHelper : IMessageBoxHelper
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}

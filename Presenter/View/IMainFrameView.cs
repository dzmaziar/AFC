using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenterr.View
{
    public interface IMainFrameView
    {
        void SetComboBox(string[] list);
        string GetSelectedItem();
        void ViewMessageBox(string message);
        string GetFloatText();
        string GetdataText();
    }
}

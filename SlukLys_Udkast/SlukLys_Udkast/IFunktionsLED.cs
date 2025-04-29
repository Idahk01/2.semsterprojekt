using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using SlukLys_Udkast;

namespace SlukLys_Udkast
{
    public interface IFunktionsLED
    {
        void SetFunction(FunctionId fid);
        void ShowError();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlukLys_Udkast
{
    public enum FunctionId : byte
    {
       TurnOnLight = 1,
        TurnOffLight = 3,
        Error = 255
        // … tilføj flere hvis du får brug for dem
    }
}

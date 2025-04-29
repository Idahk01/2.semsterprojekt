using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlukLys_Udkast
{
    public interface IHomeAssistant
    {
        void TurnOnLight(string room);
        void TurnOffLight(string room);

    }
}

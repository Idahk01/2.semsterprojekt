using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlukLys_Udkast
{
    public interface ITiltSensor
    {
        event EventHandler TiltDetected;
        event EventHandler TiltDetectionFailed;
        Task DetectTiltAsync(TimeSpan timeout);
    }
}

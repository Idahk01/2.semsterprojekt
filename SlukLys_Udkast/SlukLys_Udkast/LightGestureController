using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using SlukLys_Udkast;


namespace SlukLys_Udkast
{
    public enum ErrorCode
    {
        NoHandDetected,
        NoTiltSignal,
        NoLightStateMismatch //tjekker om lampen er tændt i forvejen - måske ikke relevant
    }
    public class LightGestureController
    {
        private readonly IAfstandsSensor _afstand;
        private readonly ITiltSensor _tilt;
        private readonly IFunktionsLED _led;
        private readonly IHomeAssistant _ha;

        private readonly TimeSpan _tiltTimeout = TimeSpan.FromSeconds(3);

        //Constructor???
        public UC3_SlukLys(
            IAfstandsSensor afstand,
            ITiltSensor tilt,
            IFunktionsLED led,
            IHomeAssistant ha)
        {
            _afstand = afstand;
            _tilt = tilt;
            _led = led;
            _ha = ha;

            _afstand.DistanceMeasured += (_, cm) => ProcessDistance(cm);
            _afstand.DistanceMeasurementFailed += (_, __) => HandleError(ErrorCode.NoHandDetected);

            _tilt.TiltDetected += (_, __) => ProcessTilt();
            _tilt.TiltDetectionFailed += (_, __) => HandleError(ErrorCode.NoTiltSignal);
        }

        public async Task StartAsync() => await _afstand.MeasureDistanceAsync();

        private void ProcessDistance(double cm)
        {
            var fid = CalculateFunction(cm);
            _led.SetFunction(fid);
            _ = _tilt.DetectTiltAsync(_tiltTimeout);   // fire-and-forget
        }
        private FunctionId CalculateFunction(double cm) =>
        cm < 30 ? FunctionId.TurnOffLight : FunctionId.Error;

        private void ProcessTilt() => _ha.TurnOffLight("Stue");

        private void HandleError(ErrorCode code)
        {
            Console.WriteLine($"[Controller] Error: {code}");
            _led.ShowError();
        }
    }
}

using System;
using System.Threading.Tasks;

namespace Magellanic.ServoController.Interfaces
{
    public interface IServoController : IDisposable
    {
        int Frequency { get; set; }

        double MaximumDutyCycle { get; set; }

        double MinimumDutyCycle { get; set; }

        int ServoPin { get; set; }

        Task Connect();

        void Go();

        IServoController SetPosition(int degree);

        IServoController AllowTimeToMove(int pauseInMs);
    }
}
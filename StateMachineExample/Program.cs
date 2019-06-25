using System;
using Stateless;

namespace StateMachineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StatelessLightSwitch stateSwitch = new StatelessLightSwitch("Stateless Switch", true, true);

            Console.WriteLine("\n Toggling stateless switch at predefined time...\n");
            StartSwitchAtDefinedTime(stateSwitch);
            
            //Console.WriteLine("Graph >>>>>>>>>>>.");
            //Console.WriteLine(stateSwitch.ShowStateMachine());

            Console.Read();
        }

        static void StartSwitchAtDefinedTime(ALightSwitch mySwitch)
        {
            TimeSpan[] times =
            {
                new TimeSpan(4,30,30),
                new TimeSpan(9,45,0),
                new TimeSpan(14,2,6),
                new TimeSpan(19,21,34),
                new TimeSpan(23,46,0)
            };

            foreach (var time in times)
            {
                Console.WriteLine("Toggling switch at " + time.ToString());
                mySwitch.SetTimeOfDay(time);
                mySwitch.ToggleSwitch();
            }
        }
    }
}

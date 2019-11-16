using Command.Receivers;

namespace Command.Commands.GarageDoorCommands
{
    class GarageDoorLightOffCommand : ICommand
    {
        private GarageManager _garageManager;

        public GarageDoorLightOffCommand(GarageManager garageManager)
        {
            _garageManager = garageManager;
        }

        public void Execute()
        {
            if (_garageManager != null)
            {
                _garageManager.LightOff();
            }
        }

        public void Undo()
        {
            if (_garageManager != null)
            {
                _garageManager.LightOn();
            }
        }
    }
}


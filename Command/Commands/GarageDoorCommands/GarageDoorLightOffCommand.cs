using Command.Receivers;

namespace Command.Commands.GarageDoorCommands
{
    class GarageDoorLightOffCommand
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
    }
}


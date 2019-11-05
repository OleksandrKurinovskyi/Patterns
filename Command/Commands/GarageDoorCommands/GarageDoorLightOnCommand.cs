using Command.Receivers;

namespace Command.Commands.GarageDoorCommands
{
    class GarageDoorLightOnCommand
    {
        private GarageManager _garageManager;

        public GarageDoorLightOnCommand(GarageManager garageManager)
        {
            _garageManager = garageManager;
        }

        public void Execute()
        {
            if (_garageManager != null)
            {
                _garageManager.LightOn();
            }
        }
    }
}

using Command.Receivers;

namespace Command.Commands.GarageDoorCommands
{
    class GarageDoorLightOnCommand : ICommand
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

        public void Undo()
        {
            if (_garageManager != null)
            {
                _garageManager.LightOff();
            }
        }
    }
}

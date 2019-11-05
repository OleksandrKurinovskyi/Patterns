using Command.Receivers;

namespace Command.Commands.GarageDoorCommands
{
    class GarageDoorStopCommand
    {
        private GarageManager _garageManager;

        public GarageDoorStopCommand(GarageManager garageManager)
        {
            _garageManager = garageManager;
        }

        public void Execute()
        {
            if (_garageManager != null)
            {
                _garageManager.DoorStop();
            }
        }
    }
}

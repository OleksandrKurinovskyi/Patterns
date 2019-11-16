using Command.Receivers;

namespace Command.Commands.GarageDoorCommands
{
    class GarageDoorStopCommand : ICommand
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

        public void Undo()
        {
            if (_garageManager != null)
            {
                _garageManager.DoorUp();
            }
        }
    }
}

using Command.Receivers;

namespace Command.Commands.GarageDoorCommands
{
    class GarageDoorUpCommnad : ICommand
    {
        private GarageManager _garageManager;

        public GarageDoorUpCommnad(GarageManager garageManager)
        {
            _garageManager = garageManager;
        }

        public void Execute()
        {
            if (_garageManager != null)
            {
                _garageManager.DoorUp();
            }
        }
    }
}

using Command.Receivers;

namespace Command.Commands.GarageDoorCommands
{
    class GarageDoorDownCommnad : ICommand
    {
        private GarageManager _garageManager;

        public GarageDoorDownCommnad(GarageManager garageManager)
        {
            _garageManager = garageManager;
        }

        public void Execute()
        {
            if (_garageManager != null)
            {
                _garageManager.DooDown();
            }
        }
    }
}

using Command.Receivers;

namespace Command.Commands.LightInRoomCommands
{
    class LightInRoomOnCommand : ICommand
    {
        private LightInRoomManager _lightInRoomManager;

        public LightInRoomOnCommand(LightInRoomManager lightInRoomManager)
        {
            _lightInRoomManager = lightInRoomManager;
        }

        public void Execute()
        {
            if (_lightInRoomManager != null)
            {
                _lightInRoomManager.On();
            }
        }
    }
}

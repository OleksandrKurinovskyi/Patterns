using Command.Receivers;

namespace Command.Commands.LightInRoomCommands
{
    class LightInRoomOffCommand : ICommand
    {
        private LightInRoomManager _lightInRoomManager;

        public LightInRoomOffCommand(LightInRoomManager lightInRoomManager)
        {
            _lightInRoomManager = lightInRoomManager;
        }

        public void Execute()
        {
            if (_lightInRoomManager != null)
            {
                _lightInRoomManager.Off();
            }
        }
    }
}

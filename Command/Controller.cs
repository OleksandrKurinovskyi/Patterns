using Command.Commands;
using System.Text;

namespace Command
{
    class Controller
    {
        private static readonly int Quantity = 5;

        private ICommand[] _onCommands;

        private ICommand[] _offCommands;

        private ICommand _undoCommand;

        public Controller()
        {
            _onCommands = new ICommand[Quantity];
            _offCommands = new ICommand[Quantity];

            for (int i = 0; i < Quantity; i++)
            {
                _onCommands[i] = new EmptyCommand();
                _offCommands[i] = new EmptyCommand();
            }

            _undoCommand = new EmptyCommand();
        }

        public void SetComands(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnClick(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffClick(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void Reset()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(this.GetType().Name);
            s.AppendLine();
            for (int i = 0; i < Quantity; i++)
            {
                s.AppendLine(string.Format("slot #{0} : ON = {1}, OFF = {2}", i, _onCommands[i].GetType().Name, _offCommands[i].GetType().Name));
                s.AppendLine(); 
            }
            return s.ToString();
        }
    }
}

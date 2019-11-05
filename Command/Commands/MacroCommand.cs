using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    class MacroCommand : ICommand
    {
        private List<ICommand> _commands;

        public MacroCommand()
        {
            _commands = new List<ICommand>();
        }

        public void Execute()
        {
            foreach (var comand in _commands)
            {
                if (comand != null)
                {
                    comand.Execute();
                }
            }
        }

        public void AddComand(ICommand command)
        {
            if (command != null && !_commands.Contains(command))
            {
                _commands.Add(command);
            }
        }

        public void RemoveComand(ICommand command)
        {
            if (_commands.Contains(command))
            {
                _commands.Remove(command);
            }
        }

        public void Undo()
        {
            foreach (var comand in _commands)
            {
                if (comand != null)
                {
                    comand.Undo();
                }
            }
        }
    }
}

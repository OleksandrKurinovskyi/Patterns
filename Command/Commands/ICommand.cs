namespace Command.Commands
{
    interface ICommand
    {
        void Execute();

        void Undo();
    }
}

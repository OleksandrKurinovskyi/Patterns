using TitleLib;
using System.Reflection;
using Command.Commands.GarageDoorCommands;
using Command.Commands.LightInRoomCommands;
using Command.Receivers;
using Command.Commands;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Title.UpperIndent(Assembly.GetExecutingAssembly());

            Controller controler = new Controller();

            LightInRoomManager lightInRoomManager = new LightInRoomManager();
            LightInRoomOnCommand lightInRoomOnCommand = new LightInRoomOnCommand(lightInRoomManager);
            LightInRoomOffCommand lightInRoomOffCommand = new LightInRoomOffCommand(lightInRoomManager);
            controler.SetComands(0, lightInRoomOnCommand, lightInRoomOffCommand);

            System.Console.WriteLine(controler);

            controler.OnClick(0);
            controler.OffClick(0);

            GarageManager gm = new GarageManager();
            MacroCommand mc = new MacroCommand();
            mc.AddComand(new GarageDoorDownCommnad(gm));
            mc.AddComand(new GarageDoorUpCommnad(gm));
            mc.AddComand(new GarageDoorStopCommand(gm));
            mc.AddComand(new GarageDoorLightOnCommand(gm));
            mc.AddComand(new GarageDoorLightOffCommand(gm));

            controler.SetComands(1, mc, lightInRoomOffCommand);
            System.Console.WriteLine();
            controler.OnClick(1);

            Title.BottonIndent();
        }
    }
}

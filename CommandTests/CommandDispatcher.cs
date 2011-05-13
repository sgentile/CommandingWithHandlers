using System.Linq;
using Commands;
using StructureMap;

namespace CommandTests
{
    public class CommandDispatcher
    {
        public void SendCommand<T>(T command) where T : ICommand
        {
            var commandHandlers = ObjectFactory.GetAllInstances<ICommandHandler<T>>();
            var commandHandlersThatCanHandle = commandHandlers.Where(c => c.CanHandle(command));
            foreach (var commandHandler in commandHandlersThatCanHandle)
            {
                commandHandler.Execute(command);
            }
        }
    }
}
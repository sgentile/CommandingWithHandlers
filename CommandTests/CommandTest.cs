using Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;

namespace CommandTests
{
    #region Sample

    #endregion
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void TestSendCommand()
        {
            ObjectFactory.Initialize(registry =>
            {
                registry.Scan(x =>
                {
                    x.TheCallingAssembly();
                    x.AddAllTypesOf(typeof(ICommandHandler<>));
                    x.WithDefaultConventions();
                });
            });

            CommandDispatcher commandDispatcher = new CommandDispatcher();

            commandDispatcher.SendCommand(new AddUser { Name = "Steve", Password = "Test" });
            commandDispatcher.SendCommand(new AddUser { Name = "Joe", Password = "Test" });
        }
    }
}

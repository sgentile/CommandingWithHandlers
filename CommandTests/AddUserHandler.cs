using System;
using Commands;

namespace CommandTests
{
    public class AddUserHandler : ICommandHandler<AddUser>
    {
        public void Execute(AddUser command)
        {
            Console.WriteLine("{0} : Added User Name {1} , Password {2}", GetType(), command.Name, command.Password);
        }

        public bool CanHandle(ICommand command)
        {
            if (command is AddUser)
                return true;
            return false;
        }
    }
}
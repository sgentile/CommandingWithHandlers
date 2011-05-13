using Commands;

namespace CommandTests
{
    public class AddUser : ICommand
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
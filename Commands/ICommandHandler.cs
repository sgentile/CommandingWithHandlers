namespace Commands
{
    public interface ICommandHandler<T> : IHandler<T> where T : ICommand
    {
        void Execute(T command);
        bool CanHandle(ICommand command);
    }
}
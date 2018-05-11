namespace AddressManagementSystemApi.AddressBook.Interfaces
{
    public interface ICommand<T>
    {
        void ExecuteCommand(T command);
    }
}

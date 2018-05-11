namespace AddressManagementSystemApi.AddressBook.Interfaces
{
    public interface IQueryFor<Tin, Tout>
    {
        Tout ExecuteQuery(Tin input);
    }
}

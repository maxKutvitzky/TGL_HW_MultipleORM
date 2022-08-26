namespace MultipleORM.Dal.Interfaces.Initialization;

public interface IDbInitialization
{
    public void Initialize();
    public void InitializeWithRecreation();
}
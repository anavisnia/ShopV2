namespace ShopV2.Interfaces
{
    public interface IWriter
    {
        void Write(string input);

        void ListAllCommands();

        string Read();

        void Clear();
    }


}

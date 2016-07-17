using System.Threading.Tasks;

namespace SharedObjects.Esoterica {

    public interface IOWrapper {
        Task<char> ReadCharacter();
        Task<string> ReadString(string defaultIfEmpty = "");
        Task Write(string src);
        Task Write(char c);
    }

}

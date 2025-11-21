namespace Enigma;

public interface IMachine
{
    string Encode(string text);

    void Reset();
}

using Enigma;

PrintHelp();

// TODO - Create a proper implementation of IMachine.
IMachine machine = null!;

// TODO - Add better handling for invalid commands.
string command;
while (true)
{
    command = Console.ReadLine() ?? string.Empty;

    if (command.StartsWith("ENC ", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine(machine.Encode(command[4..]));
        Console.WriteLine();
    }

    if (command.Equals("RST", StringComparison.OrdinalIgnoreCase))
    {
        machine.Reset();
        Console.WriteLine("Machine reset");
        Console.WriteLine();
    }

    if (command.Equals("ESC", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
}

static void PrintHelp()
{
    Console.WriteLine("Type one of the following commands and press enter:");
    Console.WriteLine("\tENC <string> - encodes the plain text string to cipher text.");
    Console.WriteLine("\tRST - reset the Enigma machine to default settings and positions.");
    Console.WriteLine("\tESC - exit the simulation.");
    Console.WriteLine();
}
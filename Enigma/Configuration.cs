namespace Enigma;

public static class Configuration
{
    /// <summary>
    /// Each pair of characters notes the pins wired together inside the reflector.
    /// </summary>
    public static readonly IReadOnlyList<string> ReflectorConnections =
    [
        "AR",
        "BY",
        "CU",
        "DH",
        "EQ",
        "FJ",
        "GL",
        "IP",
        "SX",
        "KN",
        "MZ",
        "TV",
        "OW"
    ];

    /// <summary>
    /// Each pair of characters in this list is connected by a lead.
    /// </summary>
    public static readonly IReadOnlyList<string> PlugBoardConnections =
    [
        "BG",
        "TI",
        "EL",
        "RK"
    ];

    /// <summary>
    /// Each pair of characters notes the wiring between a pin on one side of the rotor and a pin on the opposite side.
    /// </summary>
    public static readonly IReadOnlyList<string> RotorXWiring =
    [
        "AX",
        "BS",
        "CG",
        "DV",
        "EF",
        "FO",
        "GH",
        "HU",
        "IM",
        "JI",
        "KR",
        "LN",
        "ML",
        "NQ",
        "OJ",
        "PZ",
        "QE",
        "RC",
        "SY",
        "TW",
        "UD",
        "VP",
        "WB",
        "XK",
        "YT",
        "ZA"
    ];

    /// <summary>
    /// Each pair of characters notes the wiring between a pin on one side of the rotor and a pin on the opposite side.
    /// </summary>
    public static readonly IReadOnlyList<string> RotorYWiring =
    [
        "AS",
        "BF",
        "CW",
        "DE",
        "EM",
        "FO",
        "GH",
        "HG",
        "IK",
        "JX",
        "KY",
        "LI",
        "MU",
        "NA",
        "OL",
        "PC",
        "QQ",
        "RB",
        "SN",
        "TR",
        "UV",
        "VP",
        "WZ",
        "XT",
        "YD",
        "ZJ"
    ];
}


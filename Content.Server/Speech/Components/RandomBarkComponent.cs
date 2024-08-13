namespace Content.Server.Speech.Components;

/// <summary>
///     Sends a random message from a list with a provided min/max time.
/// </summary>
[RegisterComponent]
public sealed partial class RandomBarkComponent : Component
{
    /// <summary>
    ///     Should the message be sent to the chat log?
    /// </summary>
    [DataField]
    public bool ChatLog = false;

    /// <summary>
    ///     Minimum time an animal will go without speaking
    /// </summary>
    [DataField]
    public int MinTime = 45;

    /// <summary>
    ///     Maximum time an animal will go without speaking
    /// </summary>
    [DataField]
    public int MaxTime = 350;

    /// <summary>
    ///     Accumulator for counting time since the last bark
    /// </summary>
    [DataField]
    public float BarkAccumulator = 8f;

    /// <summary>
    ///     Multiplier applied to the random time. Good for changing the frequency without having to specify exact values
    /// </summary>
    [DataField]
    public float BarkMultiplier = 1f;

    /// <summary>
    ///     List of things to be said. Filled with garbage to be modified by an accent, but can be specified in the .yml
    /// </summary>
    [DataField]
    public IReadOnlyList<string> Barks = new[]
    {
        "Лай",
        "Гав",
        "Уфф",
        "Рорл",
        "Уииии",
        "Лайкумс",
        "Ауууууууууууууууу ауу ауууу",
        "Грррррррррр",
        "Раррвраррвр",
        "Черт побери, как я люблю золотые рыбки-крекеры",
        "Борк борк гав гав борк борк гав гав гав борк",
        "Лай",
        "Гав",
        "Уфф",
        "Рорл",
        "Уииии",
        "Лайкумс"
    };
}

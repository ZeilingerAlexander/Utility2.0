/// <summary>
/// Checks if any key is pressed and puts that into a list
/// </summary>
/// <returns></returns>
List<Key> IsAnyKeyPressed()
{
	var allPossibleKeys = Enum.GetValues(typeof(Key));
        List<Key> results = new List<Key>();
        foreach (var currentKey in allPossibleKeys)
        {
            Key key = (Key)currentKey;
            if (key != Key.None)
            	// If Key exists
                if (Keyboard.IsKeyDown((Key)currentKey))
                // if that key is pressed
                { results.Add((Key)currentKey); }
        }
        return results;
}

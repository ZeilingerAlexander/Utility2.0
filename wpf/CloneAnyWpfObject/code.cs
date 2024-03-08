/// <summary>
/// Clones any WPF object.
/// </summary>
/// <param name="toBeCloned">The object to be cloned.</param>
/// <returns>A cloned object.</returns>
public object CloneAnyObject(object toBeCloned)
{
    string serializedObject = XamlWriter.Save(toBeCloned);
    
    using (StringReader stringReader = new StringReader(serializedObject))
    using (XmlReader xmlReader = XmlReader.Create(stringReader))
    {
        return XamlReader.Load(xmlReader);
    }
}

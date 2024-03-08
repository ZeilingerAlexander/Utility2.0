/// <summary>
/// Attempts to get image source from open file dialog returns null if failure
/// </summary>
/// <returns></returns>
public static ImageSource? GetImageSourceFromOpenFileDialoug()
{
    OpenFileDialog op = new OpenFileDialog();
    op.Title = "Select a picture";
    op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
      "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
      "Portable Network Graphic (*.png)|*.png";
    if (op.ShowDialog() == true)
    {
        try
        {
            return Converter.ConvertStringToImageSource(op.FileName);
        }
        catch (Exception)
        {
            return null;
        }
    }
    return null;
}




internal class Converter
{
    public static ImageSource? ConvertStringToImageSource(string imageSource)
    {
        try
        {
            return new BitmapImage(new Uri(imageSource, UriKind.RelativeOrAbsolute));
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
        return null;
    }
}
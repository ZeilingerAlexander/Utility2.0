public static ImageSource ConvertStringToImageSource(string imageSource)
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
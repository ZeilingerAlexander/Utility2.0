/// <summary>
/// Checks if a folder path exists
/// </summary>
/// <returns> true if exists, false if not existing</returns>
bool TryGettingFolderPath(string path)
{
if (Directory.Exists(path))
	return true;
return false;
}
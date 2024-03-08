private UIElement GetElementInGridPosition(int column, int row) 
{
    foreach (UIElement element in this.RootGrid.Children) {
        if (Grid.GetColumn(element) == column && Grid.GetRow(element) == row)
            return element;
    }
    return null;
}
Line DrawLine(Vector2 Start, Vector2 End)
{
    return new Line()
    {
        X1 = Start.X,
        X2 = End.X,
        Y1 = Start.Y,
        Y2 = End.Y,
        Stroke = Brushes.Green,
        StrokeThickness = 2
    };
}
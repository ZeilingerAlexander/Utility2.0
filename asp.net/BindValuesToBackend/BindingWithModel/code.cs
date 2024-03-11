// backend c# code

// Binding with model is straight-forward
// either use the names in the asp-for attribute for binding or the name property (html)
// Asp will automaticly find the attributes to bind to by the provided strings
// In this example it will Bind ExampleName (from asp-for or by name) to exampleModel.ExampleName
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> ExampleMethodPost([Bind("ExampleName")] ExampleModel exampleModel)
{
    var test = exampleModel.ExampleName;
}
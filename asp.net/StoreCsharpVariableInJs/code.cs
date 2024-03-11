// The backend c# code

// inside the Get - Method for that View
// Replace ExampleDict with your object you want to load in js
var ExampleDict = new Dictionary<int, string>();

// This is just for loading values from the object into the dict
// Replace this with anything filling the dictionary or another type
foreach (var exampleEntry in ExampleRetrieveObject)
{
    ExampleDict.Add(exampleEntry.value1, exampleEntry.value2);
}
// Adding to Viewbag under Entry "ExampleDict", replace with another name
ViewBag.ExampleDict = ExampleDict;
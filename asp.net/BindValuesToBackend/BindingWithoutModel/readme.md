# Binding Values to backend without model

## Doing this is not recommended, always create new classes as models if possible, you can even inherit a class from a pre-made model to include its properties
<br/>

## If you still want to do this, which you shouldnt read below
### In your cshtml frontend create inputs (binding on forms is only possible over input fields) that have the name property set to the name you want to bind over
### The associated value is inside the .value property
### In your post method you can just include that name and its type as a new parameter
### This should work, but in some cases it will throw an ambigious refference error, then just create a new model class
# Binding Values to backend without model

## Doing this is not recommended, always create new classes as models if possible, you can even inherit a class from a pre-made model to include its properties

## If you still want to do this, which you shouldnt read below
### In your cshtml frontend create elements that have the name property set to the name you want to bind over
### In your post method you can just include that name and its type as a new parameter
### This should work, but in some cases it will throw an ambigious refference error, then just create a new model class
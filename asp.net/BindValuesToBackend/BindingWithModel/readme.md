# Bind Values to Backend with Model

## In your cshtml frontend on the inputs (Binding with Forms is only possible over input fields) you would like to bind\ Add the asp-for="NameToBindTo" or name = "NameToBindTo" (prefferably the first) attribute.
## Now in your backend on the Post Method add / [Bind("NameToBindTo")] ModelClassname boundObject  / (without the / ) inside the attributes.
### This will bind NameToBindTo towards boundObject.NameToBindTo
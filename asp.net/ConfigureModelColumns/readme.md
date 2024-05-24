# Configure Model Columns
Configuring model columns can be useful to write sql-like properties inside your code to apply to migrations

## usage
this example will show setting the default property of a column

<br>
builder.Entity TYPECLASS (entity =><br>
{<br>
entity.Property(e => e.example)<br>
.HasDefaultValue("defaultval");<br>
});<br>

replace typeclass with your identity class inside < and >
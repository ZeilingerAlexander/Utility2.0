# Add Foreign key to model
adding a foreign key to a code-first database with mvc<br>
all pulled from some SO post :)

## solution 1 (simple)
If you have an Order class, adding a property that references another class in your model, for instance Customer should be enough to let EF know there's a relationship in there:
<br>
<code>
public class Order
{
public int ID { get; set; }

    // Some other properties

    // Foreign key to customer
    public virtual Customer Customer { get; set; }
}
</code>

## solution 2 (explicitly defining foreign key relation)
<code>
public class Order
{
    public int ID { get; set; }

    // Some other properties

    // Foreign key to customer
    [ForeignKey("Customer")]
    public string CustomerID { get; set; }
    public virtual Customer Customer { get; set; }
}
</code>
<br>

## further reading
read the SO post this was pulled from [link](https://stackoverflow.com/questions/5542864/how-should-i-declare-foreign-key-relationships-using-code-first-entity-framework/5543702#5543702)
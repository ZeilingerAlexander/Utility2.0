# Add Tables to existing db Context
This will showcase how to add tables from the c# enviornment to the database

## instructions
open an existing dbcontext thats linked to your database

override the on model creation
<code><br>
protected override void OnModelCreating(ModelBuilder builder)<br>
{<br>
base.OnModelCreating(builder);<br>
}<br>
</code>

add a dbset for the table this will allow access programmaticly over the context<br>
<code>public virtual DbSet<ExampleSet> exampleSet { get; set; }</code>
<br>

add the code for generating the table together with its columns, the below is just an example pulled from one of my repos<br>
<code>
modelBuilder.Entity<News>(entity =>
{
entity.HasKey(e => e.NewIdpk);

    entity.Property(e => e.NewIdpk).HasColumnName("NewIDPK");
    entity.Property(e => e.NewBody)
        .IsRequired()
        .IsUnicode(false);
    entity.Property(e => e.NewTitle)
        .IsRequired()
        .HasMaxLength(50)
        .IsUnicode(false);
});
</code>

now everything should generate if you migrate the database
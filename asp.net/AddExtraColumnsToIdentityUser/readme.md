# Add extra columns to identity user
## how to add extra columns to the asp.net identity framework generated user
certainly not over editing the sql database directly!

skip to [Step 2](#step-2-modifying-the-identity-object) if you already know about migrations
### Step 1 Explaining Database Migrations and applying them
Migrations basically take the state of the current project with the infos provided in it (objects bound to contexts, example : the identity object is bound to the default generated identity context, see below)

program.cs (entry point, adding the models)
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
.AddEntityFrameworkStores<ApplicationDbContext>();

As you can see this binds the model to the context in some weird microsoft way that they implement internally
#### How to apply migrations
##### package manager console <code>add-migration (name)</code>
name is just the name the migration will have, this is important if you want to keep the migrations to maybe go back to previous states at some time, then you need good naming.

running the command will create a new migration if building the project succeeds it will be added to /migrations/name.cs or another point if specifying is possible (idk).

please look inside the generated code and confirm that you want to apply those database changes, you can even write some custom stuff there but it might not be in tune with your object strucutre.
##### package manager console <code>update-database</code>
this will apply the changes made to the latest or current migration, im not sure since i only used one migration at a time if you want to use multiple look it up yourself
### Step 2 modifying the identity object
#### Inheriting
For this to work we first need to create a class inheriting from the base Identity class <code>public class ModifiedUserIdentity : IdentityUser</code>

This class can have any name but we just used this one for simplicity

Now go to your favourite IDE and search for all usages of the identity base class in YOUR CODE, yes do not modify the microsoft stuff since that may mess some things up and replace all entries with your new class
#### Adding Columns
To add columns you can now simple add an attribute to the class for example :<br>
<code>
public class ModifiedUserIdentity : IdentityUser<br>
{<br>
[MaxLength(250)]
public string example { get; set; }<br>
}<br>
</code>
this will when applying the migrations explained in [Step 1](#step-1-explaining-database-migrations-and-applying-them), add a column called example to the table
#### Adding Columns on different tables
Like you have probably already seen when working with foreign keys and mvc in asp.net foreign keys can be applied with the virtual object keyword

Since i currently have no use for it i cant explain it to you properly but read this [article](https://devblogs.microsoft.com/dotnet/customizing-profile-information-in-asp-net-identity-in-vs-2013-templates/)

Here is a dump of the code snippet pretty much self explenatory

<code>
    public class MyUser : IdentityUser<br>
        {<br>
            public virtual MyUserInfo MyUserInfo { get; set; }<br>
        }<br>
        public class MyUserInfo{<br>
            public int Id { get; set; }<br>
            public string FirstName { get; set; }<br>
            public string LastName { get; set; }<br>
        }<br>
        public class MyDbContext : IdentityDbContext<MyUser><br>
        {<br>
            public MyDbContext()<br>
                : base("DefaultConnection")<br>
            {<br>
            }<br>
            public System.Data.Entity.DbSet<MyUserInfo> MyUserInfo { get; set; }<br>
         }<br>
</code>
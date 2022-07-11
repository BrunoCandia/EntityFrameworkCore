
Entity Framework Core One To One Relationships Fluent API Configurations

Entity Framework Core configures one to one relationships by being able to detect the foreign key property, and thereby identify which is the principal and which is 
the dependent entity in the relationship. If it is unable to do this, either because the foreign key property name does not follow convention, 
or because it has not been included in the model, an error message is provided when you attempt to create a migration:

The child/dependent side could not be determined for the one-to-one relationship that was detected between '<entity1.property2>' and '<entity2.property1>'. 
To identify the child/dependent side of the relationship, configure the foreign key property.

In the following model, the AuthorRef foreign key property in the Biography entity (the dependant in the relationship) does not follow foreign key naming convention:

public class Author
{
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Biography Biography { get; set; }
}

public class Biography
{
    public int AuthorBiographyId { get; set; }
    public string Biography { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }
    public string Nationality { get; set; }
    public int AuthorRef { get; set; }
    public Author Author { get; set; }
}

As a result, EF Core will not be able to detect the dependent entity in the relationship. It is configured using the Fluent API like this:

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Author>()
        .HasOne(a => a.Biography)
        .WithOne(b => b.Author)
        .HasForeignKey<Biography>(b => b.AuthorRef);
}

The Has/With pattern is used to close the loop and fully define a relationship. In this case, since the relationship to be configured is a one-to-one, 
the HasOne method is chained with the WithOne method. Then the dependent entity (Biography) is identified by passing it in as a type parameter to the HasForeignKey method, 
which takes a lambda specifying which property in the dependent type is the foreign key.



Configuring a relationship that uses Table Splitting

Table splitting is a technique that enables you to use a single table to represent both entities in a one-to-one relationship. 
Using this feature, both entities in the one-to-one relationship illustrated above will be stored in a database table together:

public class Author
{
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Biography { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }
    public string Nationality { get; set; }
}

Both entities must share the same primary key, which is used as a foreign key in the dependent end of the relationship:

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
	modelBuilder.Entity<Author>()
		.HasOne(a => a.Biography).WithOne(b => b.Author)
		.HasForeignKey<Biography>(e => e.AuthorId);
	modelBuilder.Entity<Author>().ToTable("Authors");
	modelBuilder.Entity<Biography>().ToTable("Authors"); 
}

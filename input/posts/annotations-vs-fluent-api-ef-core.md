---
Title: Annotations vs Fluent API in EF Core
Published: 4/11/2099
Tags: [Csharp,Entity Framework Core]
author: Johan Vergeer
---
Entity Framework Core (EF Core) provides two ways to handle the mapping from your model to the database. The first way is by using annotations, and the second way is by using the fluent API. In this post we'll have a look at both of them.

<?# Note ?>
In this example we're using code first approach. When using database first approach the fluent API will be used by default.[^1]
<?#/ Note ?>

## The domain model

The domain model is fairly simple. Just a `Person` class, which can hold one or more `Addresses`.

### Person class

```csharp
public class Person {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public ICollection<Address> Addresses { get; set; }
}
```

### Address class

```csharp
public class Address {
    public int Id { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
}
```

## Data annotations

First we'll look at the approach with data annotations. Here are the domain classes. 

### Person class with data annotations

```csharp
[Table("people")]
public class Person {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public ICollection<Address> Addresses { get; set; }
}
```

### Address class with data annotations

```csharp
[Table("addresses")]
public class Address {
    public int Id { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
}
```

#### Sources

- [Relational Database Modeling- Microsoft](https://docs.microsoft.com/en-us/ef/core/modeling/relational/)

[^1]: [ASP.NET Core exising DB](https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/existing-db)
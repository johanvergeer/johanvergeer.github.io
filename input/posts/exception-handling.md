---
Title: Exception handling
Published: 4/7/2019
Tags: [General]
author: Johan Vergeer
---
A couple of weeks ago I had a discussion with one of my colleagues about exception handling. What we agreed on is that an exception should be thrown when an event occurs the system cannot recover from. Even so, exception handling is often used to pass.

There are a couple of disadvantages of throwing exceptions:

- Exceptions are costly
- You cannot tell if a method will throw an exception just by looking at it

# The cost of exceptions

I created a very simple test to measure the difference between returning a boolean and throwing an exception. I'm aware that this test might be very trivial, but I think it gives a good first impression.

This is the code I used for this test. The first one throws an exception, which is caught. The second one returns a boolean indicating whether the operation was successful.

```csharp
class Program
{
    static void Main(string[] args)
    {
        CatchException();
    }

    private static void CatchException()
    {
        try
        {
            ThrowException();
            Console.WriteLine("No exception occurred");
        }
        catch (Exception e)
        {
            Console.WriteLine("An exception occurred");
            Console.ReadKey();
        }
    }

    private static void ThrowException()
    {
        throw new Exception("Exception thrown");
    }
}
```

```csharp
class Program
{
    static void Main(string[] args)
    {
        CatchBool();
    }

    private static void CatchBool()
    {
        var isSuccess = ReturnBool();

        Console.WriteLine(isSuccess ? "No exception occurred" : "An exception occurred");
        Console.ReadKey();
    }

    private static bool ReturnBool()
    {
        return true;
    }
}
```

The measurements were done with the Visual Studio 2017 builtin profiler. When running these tests the results were the same each time. These results are shown in the table below.

| Measurement      | Objects | Objects Diff | Heap size | Heap size diff  | CPU % |
| ---------------- | ------- | ------------ | --------- | --------------- | ----- |
| Start            | 360     | n/a          | 65.44 KB  | n/a             | n/a   |
| Exception thrown | 657     | +297 (45%)   | 90.63 KB  | +25.19 KB (28%) | 50%   |
| Bool returned    | 416     | +56  (13%)   | 72.44 KB  | +7.00 KB  (10%) | 25%   |

As you can see, even for this very simple example, throwing an exception is far more expensive then returning a boolean.

# Code intent

It is very hard to figure out what exceptions are thrown just by looking at a method. This goes against this quote from Grady Booch:

> “Clean code is simple and direct. Clean code reads like well-written prose. Clean code never obscures the designer’s intent but rather is full of crisp abstractions and straightforward lines of control."

# When to use exceptions?

Should we even still use exceptions, since they are so expensive and are very bad in sharing code intent? The answer to this is yes, we should. When should we use exceptions? Whenever something occurs in the normal flow of our program that the system cannot recover from.

Some good examples when to use an exception:

- The database is not available
- Out of memory
- Null pointer

Some examples when you should not thrown an exception:

- User is not logged in. Route the user to a login page
- A page does not exist. Let the user know the page does not exist
- Duplicate key. Let the user know the key is already in use

# Conclusion

As with all things in programming, and in life, it depends on the situation whether you should use an exception or another design pattern. Just don't be a lazy programmer that throws an exception whenever it feels most convenient.
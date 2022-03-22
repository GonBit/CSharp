

# Tuesday

## Serialization

Serialization is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database, or a file. Its main purpose is to save  the state of an object in order to be able to recreate it when needed.  The reverse process is called deserialization.

## SQL in C#

## ![image-20220322142945683](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220322142945683.png)

**Opening connection string**

```csharp
private static readonly string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
```


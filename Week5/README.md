

# Tuesday

## Anonymous type

Use to create objects on the fly to encapsulate

## Serialization

Serialization is the process of converting an object into a stream of bytes to store the object or transmit it to memory, a database, or a file. Its main purpose is to save  the state of an object in order to be able to recreate it when needed.  The reverse process is called deserialization.

## SQL in C#

## ![image-20220322142945683](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220322142945683.png)

**Opening connection string**

```csharp
private static readonly string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
```

## Entity Framework

First released in 2008, EF is an Object Relational Mapper

EF Streamlines the mapping of objects in our to the tables of a relational database

With EF - no need to write SQL Queries!

Query results are mapped to C# objects, and EF tracks the changes to these objects and persists these changes back into the Database for us



EF database first approach(starts with DB ) vs the EF code/model first approach(starts with Code)

In the PMC using EG tools we can use following commands;

Add-Migration

Drop-Database

Scaffold-DbContext

Update-Database



Three packages to install

![image-20220322151528696](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220322151528696.png)

```csharp
Scaffold-DbContext 'Data Source= (localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False' Microsoft.EntityFrameworkCore.SqlServer
```

Use this in the package manager after installing

![image-20220322153912564](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220322153912564.png)

What is the db context the db set

## 

![image-20220323100223501](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323100223501.png)

Deferred execution, query is only executed when it is called when the getenumerator method is called

IQueryable implements IEnumerable 

Query is not executed because it implements IEnumerable but by calling the GetEnumerator method

What is deffered execution, when does a query get executed, and why is this a good thing?

![image-20220323102326611](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323102326611.png)

![image-20220323102825089](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323102825089.png)

![image-20220323103751070](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323103751070.png)

![image-20220323104116311](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323104116311.png)

![image-20220323110430589](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323110430589.png)

![image-20220323111512271](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323111512271.png)

![image-20220323112855703](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323112855703.png)

![image-20220323113620624](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323113620624.png)

![image-20220323145531395](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323145531395.png)

![image-20220323151417187](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323151417187.png)

lambda expressions



![image-20220323151701530](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323151701530.png)

WHERE method syntax

![image-20220323153900770](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323153900770.png)

GROUP BY

![image-20220323155739546](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323155739546.png)

SELECT 

![image-20220323155938299](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323155938299.png)

![image-20220323161359971](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220323161359971.png)

# Thursday 24/3/2022

![image-20220324113917172](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220324113917172.png)

Loading

![image-20220324115442875](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220324115442875.png)



![image-20220324115913503](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220324115913503.png)

OO vs Relational approach

![image-20220324121233419](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220324121233419.png)

![image-20220324121623840](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220324121623840.png)

![image-20220324122249754](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220324122249754.png)



southwind

![image-20220324150007527](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220324150007527.png)

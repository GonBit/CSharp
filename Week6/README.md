# Monday 28/3/2022

## Asynchronous Programming

Rules and conventions for async methods:

- Async methods MUST include they keyword Async in their signature (this is to the method calling them know they will have to wait for a response)
- The body should include at least ONE await statement (otherwise they are not really async)
- By convention the method name should end with Async
- The return type must either be a Task<Type> or Task(if return is solid)
- Every method which calls an async method should await for it to finish and be asyncronous itself, all the up to the main.

## API

![image-20220328144537174](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328144537174.png)

![image-20220328144753013](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328144753013.png)

![image-20220328145026097](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328145026097.png)

![image-20220328145121889](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328145121889.png)

![image-20220328145236873](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328145236873.png)

![image-20220328145456510](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328145456510.png)

![image-20220328145847995](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328145847995.png)

## RESTful Services

![image-20220328150237464](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328150237464.png)

![image-20220328150635551](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328150635551.png)

![image-20220328151200486](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328151200486.png)

![image-20220328151402190](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328151402190.png)

![image-20220328151728108](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328151728108.png)

![image-20220328151747910](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328151747910.png)

![image-20220328151854541](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328151854541.png)

![image-20220328152302533](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328152302533.png)

![image-20220328152713507](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328152713507.png)

![image-20220328152756937](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328152756937.png)

## Statelessness

![image-20220328152958102](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328152958102.png)

## Caching

![image-20220328153147377](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328153147377.png)

![image-20220328153251289](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328153251289.png)

![image-20220328153317447](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328153317447.png)

![image-20220328153506838](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220328153506838.png)

# Tuesday 29/3/2022

Execution pipeline

![image-20220329102532036](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329102532036.png)

We are adding middlewares

## ASP.NET Frameworks

![image-20220329141502239](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329141502239.png)

![image-20220329141923705](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329141923705.png)

![image-20220329142055081](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329142055081.png)

![image-20220329142358221](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329142358221.png)

![image-20220329142404607](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329142404607.png)

![image-20220329142514049](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329142514049.png)

![image-20220329142556438](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329142556438.png)

![image-20220329142720396](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329142720396.png)

![image-20220329142852854](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329142852854.png)

![image-20220329143023252](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329143023252.png)

![image-20220329143053692](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329143053692.png)

![image-20220329143617195](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329143617195.png)

![image-20220329144001819](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329144001819.png)

![image-20220329145728105](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220329145728105.png)
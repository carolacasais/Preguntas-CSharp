# QUESTION 43

You are developing an application by using C#.   

The application includes an object that performs a long running process.   

You need to ensure that the garbage collector does not release the object's resources until the process
completes.

Which garbage collector method should you use?

A. WaitForFullGCComplete()     
B. WaitForFullGCApproach()     
**C. KeepAlive()**     
D. WaitForPendingFinalizers()     

**CORRECT ANSWER: C**    
Hace referencia al objeto especificado, convirtiéndolo en un objeto no válido para la recolección de elementos no utilizados desde el principio de la rutina actual hasta el momento en que se llamó a este método.

Enlaces de referencia:   
https://docs.microsoft.com/es-es/dotnet/api/system.gc.collect?view=net-5.0    
https://docs.microsoft.com/es-es/dotnet/api/system.gc.keepalive?view=net-5.0    
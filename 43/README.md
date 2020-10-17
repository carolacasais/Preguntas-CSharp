# QUESTION 43

You are developing an application by using C#.   

The application includes an object that performs a long running process.   

You need to ensure that the garbage collector does not release the object's resources until the process
completes.

Which garbage collector method should you use?

A. WaitForFullGCComplete()     
B. WaitForFullGCApproach()     
C. KeepAlive()     
D. WaitForPendingFinalizers()     

CORRECT ANSWER: C    
EXPLANATION: The GC.KeepAlive method references the specified object, which makes it ineligible for garbage collection from
the start of the current routine to the point where this method is called.
The purpose of the KeepAlive method is to ensure the existence of a reference to an object that is at risk of
being prematurely reclaimed by the garbage collector.
The KeepAlive method performs no operation and produces no side effects other than extending the lifetime of
the object passed in as a parameter.
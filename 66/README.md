# QUESTION 66

You use the Task.Run() method to launch a long-running data processing operation. The data processing
operation often fails in times of heavy network congestion.   

If the data processing operation fails, a second operation must clean up any results of the first operation.    

You need to ensure that the second operation is invoked only if the data processing operation throws an
unhandled exception.    

What should you do?   

A. Create a task within the operation, and set the Task.StartOnError property to true.   
B. Create a TaskFactory object and call the ContinueWhenAll() method of the object.    
**C. Create a task by calling the Task.ContinueWith() method.**   
D. Use the TaskScheduler class to create a task and call the TryExecuteTask() method on the class.   
E. Create a TaskCompletionSource<T> object and call the TrySetException() method of the object.   
F. Examine the Task.Status property immediately after the call to the Task.Run() method.   
G. Create a task inside the existing Task.Run() method by using the AttachedToParent option.   

**CORRECT ANSWER: C**   

EXPLANATION: Task.ContinueWith - Creates a continuation that executes asynchronously when the target Task completes.
The returned Task will not be scheduled for execution until the current task has completed, whether it
completes due to running to completion successfully, faulting due to an unhandled exception, or exiting out
early due to being canceled.     

ENLACE DE REFERENCIA: http://msdn.microsoft.com/en-us/library/dd270696.aspx




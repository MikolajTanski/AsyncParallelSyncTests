Project Overview
This project showcases the implementation and performance evaluation of synchronous, asynchronous, and parallel computing methods using C#. The primary goal is to compare the efficiency of these different programming approaches under scenarios involving small-scale and large-scale computational tasks.

Methods Included

Synchronous Computation
-SyncSmallCalc: Performs a simple calculation synchronously for a small data set.
-SyncLargeCalc: Performs complex calculations synchronously for a large data set

Asynchronous Computation
-AsyncSmallCalc: Handles the same small-scale task as SyncSmallCalc, but runs asynchronously.
-AsyncLargeCalc: Processes the same large-scale task as SyncLargeCalc, executed asynchronously.

Parallel Computation
-ParallelSmallCalc: Executes the small-scale task using multiple threads to demonstrate the effectiveness of parallel processing.
-ParallelLargeCalc: Uses parallel processing to handle large-scale computations, aiming to enhance performance through concurrent execution.

Benchmark Results
The benchmark results provide insights into the performance characteristics of each method under different computational loads:
-Small Calculations: Showcased minimal computation time differences but highlighted the overhead associated with setting up parallel and asynchronous operations.
-Large Calculations: Demonstrated significant performance improvements in parallel executions, justifying the overhead for large-scale tasks.

![image](https://github.com/MikolajTanski/AsyncParallelSyncTests/assets/103507492/42ac8b3f-1dff-4493-ac43-b04dffa39930)

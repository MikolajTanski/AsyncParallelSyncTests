Project Overview <br />
This project showcases the implementation and performance evaluation of synchronous, asynchronous, and parallel computing methods using C#. The primary goal is to compare the efficiency of these different programming approaches under scenarios involving small-scale and large-scale computational tasks. <br />
<br />
Methods Included <br />
<br />
Synchronous Computation <br />
-SyncSmallCalc: Performs a simple calculation synchronously for a small data set. <br />
-SyncLargeCalc: Performs complex calculations synchronously for a large data set <br />
<br />
Asynchronous Computation <br />
-AsyncSmallCalc: Handles the same small-scale task as SyncSmallCalc, but runs asynchronously. <br />
-AsyncLargeCalc: Processes the same large-scale task as SyncLargeCalc, executed asynchronously. <br />
<br />
Parallel Computation <br />
-ParallelSmallCalc: Executes the small-scale task using multiple threads to demonstrate the effectiveness of parallel processing. <br />
-ParallelLargeCalc: Uses parallel processing to handle large-scale computations, aiming to enhance performance through concurrent execution. <br />
<br />
Benchmark Results<br />
The benchmark results provide insights into the performance characteristics of each method under different computational loads: <br />
-Small Calculations: Showcased minimal computation time differences but highlighted the overhead associated with setting up parallel and asynchronous operations. <br />
-Large Calculations: Demonstrated significant performance improvements in parallel executions, justifying the overhead for large-scale tasks. <br />
<br />
![image](https://github.com/MikolajTanski/AsyncParallelSyncTests/assets/103507492/42ac8b3f-1dff-4493-ac43-b04dffa39930)

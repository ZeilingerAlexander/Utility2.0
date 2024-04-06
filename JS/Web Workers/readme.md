# Web Workers
## Web Workers are not commonly used
## Reasoning for this is explained very nicely by some guy on Stack Overflow
### [link to SO](https://stackoverflow.com/a/56368020)

## If you need to use them read the Mozilla docs
### [link to Mozilla](https://developer.mozilla.org/en-US/docs/Learn/JavaScript/Asynchronous/Introducing_workers)

## When do you need workers?
### Heavy calculations and other stuff that requires lots of computational power
### Workers are generally not seen in most web apps since they are not required and the overhead for creating a new worker outweighs the performance benefit
### However in the Server backend under Node they can prove very useful

# Workers under Node JS
## Why use Workers
### The issue with node that for some clients a calculation will be very fast and for others it may take a long time.
### Workers are used to group those Tasks into Workers that take approximately the same time
### This is done to ensure that an intensive task never blocks a bunch of non-intensive ones
### Example : A Worker with 2 heavy applications (non-blocking) will distribute the computational power equally between those 2, if now a few light clients where to be thrown into this worker they would be slowed down immensly
### Conclusion : Group Tasks into workers with similar time estimates

## The Workings
### Node JS has a Main event loop and a pool of workers with k length
### You should never write code that is blocking for the main event loop or any of the workers, to achieve this validate inputs and limit the time a process can take
### [see code examples](https://medium.com/@Trott/using-worker-threads-in-node-js-80494136dbb6)
### [see explanation](https://nodejs.org/en/learn/asynchronous-work/dont-block-the-event-loop)
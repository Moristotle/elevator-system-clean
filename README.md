# elevator-system-clean-architecture
Implementation of Elevator System using Clean Architecture - WIP 


Missing from (ideal) implementation: 

* Implementation of infrastructure layer (RabbitMQ queue for handling the elevator movement)
* Implementation of API layer (CQRS + Mediator API for exposing methods for manipulating elevator)
* Extracting domain logic from Entities and incorporate into Application Layer


Considerations that needs to be considered carefully when building an elevator system
* Implementation of algorithm for moving elevator - FIFO versus Scan algorithm (ideally) - Choice of algorithm has great impact on performance and speed of overall system
* Number of floors + elevators. - Depending on whether we have a system with a single elevator (as this one) or one with multiple elevators, then that will have a considerable impact on the overall design and architecture of the system.
* 

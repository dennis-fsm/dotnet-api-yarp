# YARP or Yet Another Reverse Proxy
A versatile and open-source middleware designed to address the complex communication needs of systems. Developed with a focus on flexibility and scalability, YARP serves as a crucial component in the development and control of services across various applications.

At its core, YARP provides a communication infrastructure that enables seamless interaction between different modules within a software architecture. 

## Key Features of YARP:
- **Modularity:** YARP promotes a modular approach to development, allowing researchers and developers to design and integrate different modules independently.
- **Inter-Process Communication:** It facilitates efficient communication between processes and modules, both within a single service and across networked services.
- **Platform Independence:** YARP is platform-independent, supporting various operating systems, which enhances its adaptability to different platforms.
- **Extensibility:** Developers can extend the functionality of YARP by adding custom modules and interfaces, providing a customizable framework for diverse applications.
- **Community Support:** Being an open-source project, YARP benefits from a collaborative community of developers and researchers who contribute to its ongoing improvement and evolution.

## Scenarios for usage of YARP
1. **Microservices Architecture:**
YARP supports the microservices paradigm, facilitating efficient communication and interaction between microservices within a distributed system.
1. **Load Balancing:**
Leveraging YARP, organizations can implement robust load balancing strategies to optimize resource utilization and enhance the overall performance of their systems.
1. **API Gateway:**
YARP serves as an effective API gateway, providing a centralized point for managing and routing API requests, thus simplifying the complexities associated with API management.
1. **Request Transformations:**
YARP allows for seamless transformation of requests, enabling organizations to modify and adapt incoming requests to better suit the requirements of their applications or services.
1. **And Many More:**
Beyond the specified scenarios, YARP's adaptability extends to a wide array of use cases, thanks to its modular and extensible architecture.

In summary, YARP stands out as a versatile solution, offering a robust foundation for various architectural patterns and addressing the intricate communication needs of modern systems. Whether applied in a microservices environment, for load balancing, as an API gateway, or for request transformations, YARP's capabilities contribute to the development of scalable and efficient applications within the .NET ecosystem.

## Start-up settings
- Right click on the solution and go to startup
![image](https://github.com/dennis-fsm/dotnet-api-yarp/assets/120356356/b0730056-51eb-4c07-9de0-99eb570594f1)

- Set the startup to run all projects (basically, each micro services)
![image](https://github.com/dennis-fsm/dotnet-api-yarp/assets/120356356/da983d96-a9c1-4935-ad4e-2a693e6b3d47)

- Change the url so that its sensitive to the micro services internal url
![image](https://github.com/dennis-fsm/dotnet-api-yarp/assets/120356356/14ec7378-0f43-4c8e-a5bc-4ac9066b9bcf)

In a future session, i will make it more simpler by running all those services inside a docker container.
Happy programming

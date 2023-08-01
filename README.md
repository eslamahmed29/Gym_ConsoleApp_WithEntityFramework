#Gym Console App using Entity Framework

This is a simple console application for managing gyms, trainers, and trainees using Entity Framework (EF). The application allows users to create, read, update, and delete gyms, trainers, and trainees. It also supports a many-to-many relationship between trainers and gyms through the Trainers_Gym table.

Prerequisites
Before running the application, make sure you have the following installed:

.NET Core SDK (version 3.1 or later)
Entity Framework Core (EF Core)
SQL Server (or SQL Server Express) to host the database
Usage
Upon running the application, you will be presented with a simple console-based menu. Use the number keys to navigate through the options.

Manage Gyms:

Add a new gym.
View a list of all gyms.
Update gym details.
Delete a gym.
Manage Trainers:

Add a new trainer.
View a list of all trainers.
Update trainer details.
Delete a trainer.
Manage Trainees:

Add a new trainee.
View a list of all trainees.
Update trainee details.
Delete a trainee.
Manage Trainers in Gym:

Assign a trainer to a gym.
Remove a trainer from a gym.
Exit:

Exit the application.
Database Structure
The application uses Entity Framework to create the following tables:

Gyms: Stores information about gyms, such as GymId, Name, Location, etc.

Trainers: Stores information about trainers, such as TrainerId, Name, Specialty, etc.

Trainees: Stores information about trainees, such as TraineeId, Name, Age, etc.

Trainers_Gym: Represents the many-to-many relationship between trainers and gyms. It contains foreign keys to the Trainers and Gyms tables along with additional fields as needed.

Contributing
We welcome contributions to this project. If you find any issues or have suggestions for improvements, please feel free to create a pull request or submit an issue.

License
This project is licensed under the MIT License.

Acknowledgments
The application uses Entity Framework Core to interact with the database.
Special thanks to the .NET Core community for their valuable resources and support.
Thank you for using our Gym Console App! If you have any questions or need further assistance, please don't hesitate to contact us. Enjoy managing your gyms, trainers, and trainees efficiently!

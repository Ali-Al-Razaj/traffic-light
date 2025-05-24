# 🚦 Traffic Light Simulation
## Overview
The Traffic Light Simulation is a desktop application developed using C# and Windows Forms. It simulates the behavior of a standard traffic light system, providing a visual representation of traffic light sequences. This project serves as an educational tool to understand the fundamentals of traffic light operations and state management in GUI applications.

## Features
- **Visual Simulation**: Represents traffic lights with red, yellow, and green indicators.

- **State Management**: Implements a finite state machine to control light transitions.

- **Custom User Control**: Encapsulates traffic light behavior within a reusable user control.

- **Configurable Timings**: Allows adjustment of light durations for red, yellow, and green states.

## Architecture
- **The application follows a modular architecture**:

    - **Presentation Layer**: Handles the user interface using Windows Forms.

    - **Business Logic Layer**: Contains the core functionalities and state management.

    - **Custom Controls**: Implements a user control (ctrlTraficLight) to represent the traffic light.

## Technologies Used
- **Programming Language**: C#

- **Framework**: .NET Framework

- **UI Framework**: Windows Forms

## Project Structure
```bash
traffic-light/
├── ctrlTraficLight.cs           # Custom user control logic
├── ctrlTraficLight.Designer.cs  # Designer file for the user control
├── ctrlTraficLight.resx         # Resource file for the user control
├── Form1.cs                     # Main form logic
├── Form1.Designer.cs            # Designer file for the main form
├── Form1.resx                   # Resource file for the main form
├── Program.cs                   # Application entry point
├── App.config                   # Configuration file
├── trafic light Project.csproj  # Project file
├── trafic light Project.sln     # Solution file
└── README.md                    # Project documentation
```
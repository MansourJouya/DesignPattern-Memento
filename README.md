# Design Patterns - Memento

This repository showcases an implementation of the Memento design pattern in C#. The code demonstrates how to capture and restore the state of an object without exposing its internal structure, making the system more flexible and maintainable.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Memento design pattern is a behavioral pattern that allows an object’s state to be captured and restored without exposing its implementation details. It helps create a history of the state changes, making it possible to revert to previous states when needed.

## Implementation Overview
This repository provides a C# implementation of the Memento pattern. Key components of the code include:

- **Memento Class**: Captures and stores the state of the originator.
- **Originator Class**: Maintains the state and can create and restore mementos.
- **Caretaker Class**: Manages the memento history and handles saving and restoring state without exposing the originator’s details.
- **Program Class**: Demonstrates how to use the Memento pattern in a client application.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-Memento.git
```

Navigate into the project directory:

```bash
cd DesignPattern-Memento
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Memento pattern in action.
3. Modify or extend the `Originator`, `Memento`, or `Caretaker` classes to simulate different scenarios.

### Example Output:
```
Current State: State 1
Current State: State 2
Current State: State 3
Restoring to previous states...
Current State: State 2
Current State: State 1
No state to restore.
```

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

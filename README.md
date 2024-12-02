# Linked List Operations with C#

This project demonstrates how to implement a **singly linked list** in C#. It provides functionalities such as adding, deleting, and displaying elements at different positions in the list. The console application includes a user-friendly menu for interacting with the linked list.

## Features

- **Add to Beginning:** Insert a new element at the start of the list.
- **Add to End:** Append a new element at the end of the list.
- **Add at Index:** Insert a new element at a specified index.
- **Delete from Beginning:** Remove the first element of the list.
- **Delete from End:** Remove the last element of the list.
- **Delete at Index:** Remove an element at a specified index.
- **Print List:** Display the current state of the list.

## Project Structure

- **Node Class:** Represents a single node in the linked list. Each node contains:
  - `int _data`: The data stored in the node.
  - `Node next`: A reference to the next node.
- **NodeList Class:** Contains the core linked list functionalities:
  - Methods for adding and deleting elements.
  - A method to print the linked list.
- **Program Class:** Contains the `Main` method and a simple menu for user interaction.

## How It Works

1. Run the application.
2. Choose an option from the menu:
   - Add elements to the beginning or end of the list.
   - Insert or remove elements at specific positions.
   - Print the current list.
3. Follow the prompts to enter data or indices where required.

## Menu Options

| Option | Description                            |
|--------|----------------------------------------|
| 1      | Add a new element to the beginning.   |
| 2      | Add a new element to the end.         |
| 3      | Delete the first element.             |
| 4      | Delete the last element.              |
| 5      | Insert an element at a specific index.|
| 6      | Remove an element at a specific index.|
| 0      | Exit the application.                 |

## Example Usage

### Adding Elements
- Choose `1` to add a number to the beginning.
- Choose `2` to add a number to the end.

### Deleting Elements
- Choose `3` to remove the first element.
- Choose `4` to remove the last element.

### Inserting/Removing at Index
- Choose `5` to insert a number at a specific index.
- Choose `6` to remove a number at a specific index.

### Requirements### 
- Choose .NET Framework or .NET Core
- Choose Visual Studio or a compatible IDE for running C# applications.
  
### How to Run### 
Clone the repository:
git clone https://github.com/MuradAliyevDeveloper/<repository-name>.git
Open the project in Visual Studio.
Build and run the application.

Author
Developed by Murad Aliyev - Software Developer

### Output Example
```plaintext
-----------------------------------------------------------
Start -> 10 -> 20 -> 30 -> Finish
-----------------------------------------------------------




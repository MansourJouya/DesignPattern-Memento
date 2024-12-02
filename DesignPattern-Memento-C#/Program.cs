using System;
using System.Collections.Generic;

/// <summary>
/// Memento class to capture and restore the state of an object.
/// </summary>
public class Memento
{
    public string State { get; private set; }

    public Memento(string state)
    {
        State = state;
    }
}

/// <summary>
/// Originator class that creates and restores the state of a memento.
/// </summary>
public class Originator
{
    private string _state;

    public string State
    {
        get => _state;
        set => _state = value;
    }

    /// <summary>
    /// Creates a memento object that captures the current state.
    /// </summary>
    /// <returns>A Memento object.</returns>
    public Memento SaveState()
    {
        return new Memento(_state);
    }

    /// <summary>
    /// Restores the state from a memento object.
    /// </summary>
    /// <param name="memento">The Memento object.</param>
    public void RestoreState(Memento memento)
    {
        _state = memento.State;
    }

    /// <summary>
    /// Displays the current state.
    /// </summary>
    public void DisplayState()
    {
        Console.WriteLine("Current State: " + _state);
    }
}

/// <summary>
/// Caretaker class that manages the memento without exposing the originator's state.
/// </summary>
public class Caretaker
{
    private Stack<Memento> _mementoHistory = new Stack<Memento>();

    /// <summary>
    /// Saves the current state to the history.
    /// </summary>
    /// <param name="memento">The Memento object to save.</param>
    public void SaveMemento(Memento memento)
    {
        _mementoHistory.Push(memento);
    }

    /// <summary>
    /// Retrieves and restores the last saved state.
    /// </summary>
    /// <param name="originator">The Originator object to restore.</param>
    public void RestoreLastState(Originator originator)
    {
        if (_mementoHistory.Count > 0)
        {
            Memento memento = _mementoHistory.Pop();
            originator.RestoreState(memento);
        }
        else
        {
            Console.WriteLine("No state to restore.");
        }
    }
}

/// <summary>
/// Example demonstrating the Memento design pattern.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Originator originator = new Originator();
        Caretaker caretaker = new Caretaker();

        // Setting initial state and saving it.
        originator.State = "State 1";
        originator.DisplayState();
        caretaker.SaveMemento(originator.SaveState());

        // Changing state and saving it.
        originator.State = "State 2";
        originator.DisplayState();
        caretaker.SaveMemento(originator.SaveState());

        // Changing state and saving it.
        originator.State = "State 3";
        originator.DisplayState();
        caretaker.SaveMemento(originator.SaveState());

        // Restoring to the last saved state.
        Console.WriteLine("\nRestoring to previous states...");
        caretaker.RestoreLastState(originator);
        originator.DisplayState();

        caretaker.RestoreLastState(originator);
        originator.DisplayState();

        caretaker.RestoreLastState(originator);
        originator.DisplayState();
    }
}

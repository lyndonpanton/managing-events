# managing-events
Marked Programming Assignment 3 of the "Intermediate Object-Oriented Programming for Unity Games" course of the "C# Programming for Unity Game Development" Specialization by the University of Colorado via Coursera Description

## Description
For this assignment, you need to implement all the classes as shown in the class diagram below:
![Image Not Found](https://www.google.com)

The Unity materials I provided to you contains stubs for the InvokerInvoker, ListenerListener, and EventManagerEventManager classes, but you still have lots of work to do to finish implementing those classes (scripts). You also need to create and implement the MessageEventMessageEvent and CountMessageEventCountMessageEvent scripts.

In the class diagram above, the arrow (called an association) from the InvokerInvoker class to the MessageEventMessageEvent class indicates that the InvokerInvoker class has a MessageEventMessageEvent field named messageEventmessageEvent.

Create a MessageEventMessageEvent script that inherits from UnityEventUnityEvent and create a CountMessageEventCountMessageEvent script that inherits from UnityEvent<int>UnityEvent<int>. Remember, UnityEventUnityEvent and UnityEvent<>UnityEvent<> are in the UnityEngine.EventsUnityEngine.Events namespace.

In the EventManagerEventManager script I provided, add code to the AddNoArgumentInvokerAddNoArgumentInvoker and AddNoArgumentListenerAddNoArgumentListener methods to make the appropriate modifications to the provided noArgumentInvokernoArgumentInvoker and noArgumentListenernoArgumentListener fields.

In the InvokerInvoker script I provided, declare fields for a TimerTimer object and a MessageEventMessageEvent object. Add code to the AwakeAwake method to create an instance of the MessageEventMessageEvent object in that field. Add code to the AddNoArgumentListenerAddNoArgumentListener method that adds a UnityActionUnityAction delegate as a listener for the MessageEventMessageEvent; remember, UnityActionUnityAction is in the UnityEngine.EventsUnityEngine.Events namespace. Add code to the StartStart method to add the InvokerInvoker as a no argument invoker in theEventManagerEventManager, add a Timer component, set its duration to 1 second, and run the timer. Add code to the UpdateUpdate method to check if the timer has finished; if it has, call the InvokeNoArgumentEventInvokeNoArgumentEvent method and run the timer again. Add code to the InvokeNoArgumentEventInvokeNoArgumentEvent method to invoke the MessageEventMessageEvent.

In the Unity editor, attach the Invoker script to the main camera.

In the ListenerListener script I provided, in the StartStart method, add code to add the HandleMessageEventHandleMessageEvent method as a no argument listener in theEventManagerEventManager.

In the Unity editor, attach the Listener script to the main camera.

Run the game. The message should be printed in the Console window every second.

Follow similar steps to add event handling for the one int argument event. I just had the InvokerInvoker script increment the value it includes each time it invokes the event, but do whatever you want to provide a different integer each time.

## Getting Started

n/a

### Dependencies

* Windows 10
* Microsoft Visual Studio
* .NET
* Unity

### Installing

* Download link: [Github Repository](https://github.com/lyndonpanton/managing-events)

### Executing program

n/a

## Help

n/a

## Authors

Lyndon Mykal Panton
[lyndonpanton](https://github.com/lyndonpanton/)

## Version History

* 0.1
    * Initial Release

## License

n/a

## Acknowledgments

Problem provided by the _University of Colorado_ and _Coursera_

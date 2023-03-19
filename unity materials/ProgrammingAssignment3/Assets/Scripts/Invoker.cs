using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

/// <summary>
/// An event invoker
/// </summary>
public class Invoker : MonoBehaviour
{
    // add your fields for your message event support here
    Timer messageTimer;
    MessageEvent noArgumentMessageEvent;

    // add your fields for your count message event support here
    Timer countMessageTimer;
    CountMessageEvent oneArgumentMessageEvent;
    int count = 0;

    /// <summary>
    /// Awake is called before Start
    /// </summary>
    public void Awake()
    {
        // add your code here
        noArgumentMessageEvent = new MessageEvent();
        oneArgumentMessageEvent = new CountMessageEvent();
    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
    public void Start()
	{
        // add your code here
        EventManager.AddNoArgumentInvoker(this);
        messageTimer = gameObject.AddComponent<Timer>();
        messageTimer.Duration = 1;
        messageTimer.Run();

        EventManager.AddIntArgumentInvoker(this);
        countMessageTimer = gameObject.AddComponent<Timer>();
        countMessageTimer.Duration = 1;
        countMessageTimer.Run();
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // add your code here
        if (messageTimer.Finished)
        {
            InvokeNoArgumentEvent();
            messageTimer.Duration = 1;
            messageTimer.Run();
        }

        if (countMessageTimer.Finished)
        {
            InvokeOneArgumentEvent(count++);
            countMessageTimer.Duration = 1;
            countMessageTimer.Run();
        }
	}

    /// <summary>
    /// Adds the given listener to the no argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddNoArgumentListener(UnityAction listener)
    {
        // add your code here to add the given listener for
        // the message event
        noArgumentMessageEvent.AddListener(listener);
    }

    /// <summary>
    /// Adds the given listener to the one argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void AddOneArgumentListener(UnityAction<int> listener)
    {
        // add your code here to add the given listener for
        // the count message event
        oneArgumentMessageEvent.AddListener(listener);
    }

    /// <summary>
    /// Removes the given listener to the no argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void RemoveNoArgumentListener(UnityAction listener)
    {
        // add your code here to remove the given listener from the
        // message event
        noArgumentMessageEvent.RemoveListener(listener);
    }

    /// <summary>
    /// Removes the given listener to the one argument event
    /// </summary>
    /// <param name="listener">listener</param>
    public void RemoveOneArgumentListener(UnityAction<int> listener)
    {
        // add your code here to remove the given listener from the
        // count message event
        oneArgumentMessageEvent.RemoveListener(listener);
    }

    /// <summary>
    /// Invokes the no argument event
    /// 
    /// NOTE: We need this public method for the autograder to work
    /// </summary>
    public void InvokeNoArgumentEvent()
    {
        // add your code here to invoke the message event
        noArgumentMessageEvent.Invoke();
    }

    /// <summary>
    /// Invokes the one argument event
    /// 
    /// NOTE: We need this public method for the autograder to work
    /// </summary>
    /// <param name="argument">argument to use for the Invoke</param>
    public void InvokeOneArgumentEvent(int argument)
    {
        // add your code here to invoke the count message event
        // with the given argument
        oneArgumentMessageEvent.Invoke(argument);
    }
}

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class BaseEvent : ScriptableObject
{
    protected List<BaseEventListener.Listener> _listeners = new List<BaseEventListener.Listener>();

    public void Invoke()
    {
        foreach (BaseEventListener.Listener listener in _listeners.ToList()) listener.Invoke();
    }

    public void RegisterListener(BaseEventListener.Listener listener)
    {
        _listeners.Add(listener);
    }

    public void UnregisterListener(BaseEventListener.Listener listener)
    {
        _listeners.Remove(listener);
    }
}

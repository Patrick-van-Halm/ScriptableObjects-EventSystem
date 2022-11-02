using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericBaseEvent<T> : ScriptableObject
{
    protected List<GenericBaseEventListener<T>.Listener> _listeners = new List<GenericBaseEventListener<T>.Listener>();

    public virtual void Invoke(T T1)
    {
        foreach (GenericBaseEventListener<T>.Listener listener in _listeners) listener.Invoke(T1);
    }

    public void RegisterListener(GenericBaseEventListener<T>.Listener listener)
    {
        _listeners.Add(listener);
    }

    public void UnregisterListener(GenericBaseEventListener<T>.Listener listener)
    {
        _listeners.Remove(listener);
    }
}
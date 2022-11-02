using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class GenericBaseEventListener<T> : MonoBehaviour
{
    [SerializeField] private List<Listener> listeners = new List<Listener>();

    private void OnEnable()
    {
        foreach (Listener listener in listeners) listener.BaseEvent.RegisterListener(listener);
    }

    private void OnDisable()
    {
        foreach (Listener listener in listeners) listener.BaseEvent.UnregisterListener(listener);
    }

    [Serializable]
    public class Listener
    {
        public GenericBaseEvent<T> BaseEvent;
        public UnityEvent<T> Event;

        public void Invoke(T t)
        {
            Event.Invoke(t);
        }
    }
}



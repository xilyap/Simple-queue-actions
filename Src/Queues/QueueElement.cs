using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QueueElement : AbstractElement
{
    public QueueActions queue;
    [SerializeField]
    public override bool IsActive { 
    get {
            return base.IsActive;
        } set {
            if (value)
                OnActive.Invoke();
            else
                OnInactive.Invoke();
            base.IsActive = value;
            OnChange.Invoke();
        } }
    public UnityEvent OnActive;
    public UnityEvent OnInactive;
    public UnityEvent OnChange;
    public void EnQueue()
    {
        queue.currentQueue.Remove(this);
        queue.currentQueue.Add(this);
        Debug.LogError(queue.currentQueue.Count);
    }
    public void DeQueue()
    {
        queue.currentQueue.Remove(this);
        Debug.LogError(queue.currentQueue.Count);
    }
    public void Switch()
    {
        IsActive = !IsActive;
    }
}

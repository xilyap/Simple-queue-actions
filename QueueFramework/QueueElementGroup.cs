using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueElementGroup : QueueElement
{
    [SerializeField]
    public List<AbstactQueueElement> queueElements;
    public void Check()
    {
        bool state = true;
        foreach (var item in queueElements)
        {
            state = state && item.IsActive;
        }
        IsActive = state;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueActions : MonoBehaviour
{
    public List<AbstactQueueElement> taskQueue;
    public List<AbstactQueueElement> currentQueue;

    void Start()
    {
        currentQueue = new List<AbstactQueueElement>();
    }
    public virtual bool CheckListsEquality()
    {
        if (currentQueue.Count != taskQueue.Count)
            return false;
        for (int i = 0; i< taskQueue.Count;i++)
        {
            if (!CompareElements(taskQueue[i], currentQueue[i]))
                return false;
        }
        return true;
    }

    private bool CompareElements(AbstactQueueElement abstactQueueElement1, AbstactQueueElement abstactQueueElement2)
    {
        return abstactQueueElement1.gameObject.Equals(abstactQueueElement2.gameObject);
    }
}

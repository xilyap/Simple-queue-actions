using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueActions : MonoBehaviour
{
    public List<AbstractElement> taskQueue;
    public List<AbstractElement> currentQueue;

    void Start()
    {
        currentQueue = new List<AbstractElement>();
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

    private bool CompareElements(AbstractElement abstactElement1, AbstractElement abstactElement2)
    {
        return abstactElement1.gameObject.Equals(abstactElement2.gameObject);
    }
}

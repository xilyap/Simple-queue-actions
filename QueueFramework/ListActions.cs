using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListActions : QueueActions
{
    public override bool CheckListsEquality()
    {
        if (currentQueue.Count != taskQueue.Count)
            return false;
        for (int i = 0; i < taskQueue.Count; i++)
        {
            if (!taskQueue.Contains(currentQueue[i]))
                return false;
        }
        return true;
    }
}

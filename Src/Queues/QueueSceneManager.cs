using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QueueSceneManager : MonoBehaviour
{
    public QueueActions sceneQueue;
    public UnityEvent onFailEvent;
    public UnityEvent onSuccessEvent;
    public bool Submit()
    {
        bool result = sceneQueue.CheckListsEquality();
        if (result)
            onSuccessEvent.Invoke();
        else
            onFailEvent.Invoke();

        return result;
    }
    public void SubmitResult()
    {
        bool result = sceneQueue.CheckListsEquality();
        if (result)
            onSuccessEvent.Invoke();
        else
            onFailEvent.Invoke();
    }
}

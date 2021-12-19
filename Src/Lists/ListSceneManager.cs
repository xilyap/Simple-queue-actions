using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ListSceneManager : MonoBehaviour
{
    public ListActions sceneList;
    public UnityEvent onFailEvent;
    public UnityEvent onSuccessEvent;
    public bool Submit()
    {
        bool result = sceneList.CheckListsEquality();
        if (result)
            onSuccessEvent.Invoke();
        else
            onFailEvent.Invoke();

        return result;
    }
    public void SubmitResult()
    {
        bool result = sceneList.CheckListsEquality();
        if (result)
            onSuccessEvent.Invoke();
        else
            onFailEvent.Invoke();
    }
}

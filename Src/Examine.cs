using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Examine : MonoBehaviour
{
    public UnityEvent onExamineAction;
    public void onExamine()
    {
        onExamineAction.Invoke();
    }
}

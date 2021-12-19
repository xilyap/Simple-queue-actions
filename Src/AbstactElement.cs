using UnityEngine;

public abstract class AbstractElement : MonoBehaviour
{
    [SerializeField]
    private bool isActive;

    public virtual bool IsActive { get => isActive; set => isActive = value; }
}
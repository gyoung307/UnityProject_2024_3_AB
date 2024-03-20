using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExParentClass : MonoBehaviour
{
    protected int protectedValueParent;
}
public class ExChildClass : ExParentClass
{
    private void Start()
    {
        Debug.Log(protectedValueParent);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExAccessControl : MonoBehaviour
{
    //public으로 선언된 변수는 다른 스크립트에서 직접 접근 가능
    public int publicVlaue;

    //private으로 선언된 변수는 같은 클래스 내에서만 접근 가능
    private int privateValaue;

    protected int protectedVlaue;

    internal int internalVlaue;
   
}

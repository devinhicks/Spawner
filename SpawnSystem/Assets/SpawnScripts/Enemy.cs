using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, iCopyable
{
    public iCopyable Copy()
    {
        return Instantiate(this);
    }
}

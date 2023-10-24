using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muertes : MonoBehaviour
{
    protected static int muertes = 0;
    public static int pMuertes
    {
        get
        {
            return muertes;
        }
        set
        {
            muertes = value;
        }
    }
}

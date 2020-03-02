using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_target : MonoBehaviour
{
    [SerializeField]
    destination dol;

    private void destr()
    {
        
    }
    public void Get_target1()
    {
        dol.Change_target("Target1");
    }
    public void Get_Target2()
    {
        dol.Change_target("Target2");
    }
}

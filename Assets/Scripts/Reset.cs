using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
   public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }



}

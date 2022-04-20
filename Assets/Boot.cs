using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Boot : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void HideLogoMask();

    void Start() {
      HideLogoMask();
    }
}

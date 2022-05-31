using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Collections.ObjectModel;
using System;

public class GlobalEventManager : MonoBehaviour
{
    public static Action destroy;
    public static Action gud_destroy;
    public static Action soundSwitch;
}

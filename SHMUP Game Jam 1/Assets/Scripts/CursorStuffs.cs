using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class CursorStuffs : MonoBehaviour
{
    public Texture2D cursorAcorn;

    void Start()
    {
       
        Cursor.SetCursor(cursorAcorn, Vector2.zero, CursorMode.ForceSoftware);
    }

}

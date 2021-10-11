using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void openScene(int idx)
    {
        SceneControllerScript.openScene(idx);
    }
}

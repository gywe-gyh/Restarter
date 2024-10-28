using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Respwaner : MonoBehaviour
{
    public string sceneName = "SampleScene";


    private void Update()
    {
        Respawn();
    }
    private void Respawn()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            EditorSceneManager.LoadScene(sceneName);


        }


    }





} 



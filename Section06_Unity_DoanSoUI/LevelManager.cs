using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string name){
        Debug.Log("Level muốn đến là " + name);
        Application.LoadLevel(name);
    }
    
    public void Quit(){
        Debug.Log("Tôi muốn thoát game");
        Application.Quit();
    }
}

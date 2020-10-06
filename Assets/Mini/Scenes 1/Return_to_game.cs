using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return_to_game : MonoBehaviour
{
    // Start is called before the first frame update
    public void callButton1()
    {
        SceneManager.LoadScene(1);
    }
    public void callButton0()
    {
        SceneManager.LoadScene(2);
    }
    public void callButton()
    {
        SceneManager.LoadScene(1);
    }
    public void CallNExtButton()
    {
        SceneManager.LoadScene(2);
    }
    public void callButton2()
    {
        SceneManager.LoadScene(2);
    }
    public void callButton3()
    {
        SceneManager.LoadScene(0);
    }

}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }


    public void click_pindai()
    {
        SceneManager.LoadScene(1);
    }

}

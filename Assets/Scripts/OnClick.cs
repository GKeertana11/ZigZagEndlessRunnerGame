using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    public Button start;
    public Button options;
    
    // Start is called before the first frame update
    void Start()
    {
        start.onClick.AddListener(Starts);
        options.onClick.AddListener(Options);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Starts()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
    public void Options()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}

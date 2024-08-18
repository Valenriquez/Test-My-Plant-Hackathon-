using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LogicButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AfterMenu()
    {
        SceneManager.LoadScene("AfterMenuScene");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void MyPlants()
    {
        SceneManager.LoadScene("MyPlants");
    }
    public void NewScan()
    {
        SceneManager.LoadScene("NewScan");
    }
    public void CommunityTracking()
    {
        SceneManager.LoadScene("CommunityTracking");
    }
    public void ImpactTracking()
    {
        SceneManager.LoadScene("ImpactTracking");
    }
    public void CrapeMyrtle()
    {
        SceneManager.LoadScene("CrapeMyrtle");
    }
    public void SpanishJasmine()
    {
        SceneManager.LoadScene("SpanishJasmine");
    }
}

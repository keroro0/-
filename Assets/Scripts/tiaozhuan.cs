using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tiaozhuan : MonoBehaviour
{
    public void timetable()
    {
        SceneManager.LoadScene("Timetable");
    }
    public void back()
    {
        SceneManager.LoadScene("personalcentre");
    }
    public void personalcentre()
    {
        SceneManager.LoadScene("personalcentre");
    }
    public void route()
    {
        SceneManager.LoadScene("route");
    }
    public void bus()
    {
        SceneManager.LoadScene("bus");
    }
    public void bikes()
    {
        SceneManager.LoadScene("shared bikes");
    }
    public void tree()
    {
        SceneManager.LoadScene("tree");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UI.TableUI;
public class data : MonoBehaviour
{
    public TableUI table;
    // Start is called before the first frame update




    // Update is called once per frame
    void Update()
    {

        table.GetCell(1, 1).text = PlayerPrefs.GetString("Text1_1");
        table.GetCell(1, 2).text = PlayerPrefs.GetString("Text1_2");
        table.GetCell(1, 3).text = PlayerPrefs.GetString("Text1_3");
        table.GetCell(1, 4).text = PlayerPrefs.GetString("Text1_4");
        table.GetCell(1, 5).text = PlayerPrefs.GetString("Text1_5");
        table.GetCell(2, 1).text = PlayerPrefs.GetString("Text2_1");
        table.GetCell(2, 2).text = PlayerPrefs.GetString("Text2_2");
        table.GetCell(2, 3).text = PlayerPrefs.GetString("Text2_3");
        table.GetCell(2, 4).text = PlayerPrefs.GetString("Text2_4");
        table.GetCell(2, 5).text = PlayerPrefs.GetString("Text2_5");



    }
}

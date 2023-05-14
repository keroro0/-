using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class count : MonoBehaviour
{
    private Toggle m_Toggle;
    private Toggle m1_Toggle;//获取到Toggle组件
    private Toggle m2_Toggle;//获取到Toggle组件
    public Text count1;
    public Slider slider;
    public int count2;
    void Start()
    {
        //找到组件
        m_Toggle= GameObject.Find("Toggle").GetComponent<Toggle>();
        //动态添加监听
        m_Toggle.onValueChanged.AddListener(ToggleOnValueChanged1);
        //找到组件
       
        m1_Toggle = GameObject.Find("Toggle(1)").GetComponent<Toggle>();
        //动态添加监听
        m1_Toggle.onValueChanged.AddListener(ToggleOnValueChanged2);
        //找到组件
        m2_Toggle = GameObject.Find("Toggle(2)").GetComponent<Toggle>();
        //动态添加监听
        m2_Toggle.onValueChanged.AddListener(ToggleOnValueChanged3);
        //找到组件
        int count2 = PlayerPrefs.GetInt("Sum");
        count1.text = "当前积分：" + count2;
        slider.value = count2;
    }
    public void ToggleOnValueChanged1(bool isOn)
    {
       
        if (isOn)
        {
            
            int sum = PlayerPrefs.GetInt("Sum");
            sum =sum+1;
            PlayerPrefs.SetInt("Sum", sum);
            int count2 = PlayerPrefs.GetInt("Sum");
            count1.text = "当前积分：" + count2;
            slider.value = count2;
        }
    }
    public void ToggleOnValueChanged2(bool isOn)
    {

        if (isOn)
        {
            int sum = PlayerPrefs.GetInt("Sum");
            sum = sum + 1;
            PlayerPrefs.SetInt("Sum", sum);
            int count2 = PlayerPrefs.GetInt("Sum");
            count1.text = "当前积分：" + count2;
            slider.value = count2;
        }
    }
    public void ToggleOnValueChanged3(bool isOn)
    {

        if (isOn)
        {
            int sum = PlayerPrefs.GetInt("Sum");
            sum = sum + 1;
            PlayerPrefs.SetInt("Sum", sum);
            int count2 = PlayerPrefs.GetInt("Sum");
            count1.text = "当前积分：" + count2;
            slider.value = count2;
        }
    }
    public void clear()
    {
        int zore1 = 0;
        PlayerPrefs.SetInt("Sum", zore1);
        int count2 = PlayerPrefs.GetInt("Sum");
        count1.text = "当前积分：" + count2;
        slider.value = count2;
    }
}



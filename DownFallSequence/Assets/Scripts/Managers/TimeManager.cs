using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text dayText; // 일수
    public Text timeText;
    public Text apText;

    public enum DayTime { Dawn, Moring, Lunch, Evening, Night}; //시간
    private string[] PlaceTime = {"RuinsVillage", "Rito", "Ruin","Endes_Desrt","Setar_Plaza","Setar_Smithy","Setar_Arena", "Ureta_Mountain", "Zailpiton_Forest", "Sol_Plaza", "Setar_Stable", "HomeTown", "HomeTown2","Durkan_Stable","Durkan_port","Durkan_plaza","Durkan_fishing","Sol_Castle","Sol_Castle_Knight" };
    

    private int day=0;
    public int ap=0;
    public DayTime time = DayTime.Evening;

    UIManager uIManager;

    private void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    private void Update()
    {
        dayText.text = day.ToString() + " 일째";
        apText.text = "행동 포인트 : " + (5 - ap).ToString();
        SceneChange();
        OnOff();


    }
    public void APClick() //행동력 사용
    {
        ap = ap + 1;
        
        if (ap==5)
        {
            
            if ((int)time <= 3) // 행동력 모두 사용
            {
                
                time = time + 1;
                ap = 0;
            }
            else if ((int)time >= 4) // 행동력 모두 소모 시 강제 취침
            {
                time = DayTime.Moring;
                ap = 0;
                day += 1;
                GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
                Invoke("PadeOff", 2f);
            }
            
            
        }
        

    }
    public void Sleep()
    {
        if(time == DayTime.Evening)
        {
            time = DayTime.Dawn;
            ap = 0;
            day += 1;
            GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
            Invoke("PadeOff", 2f);
        }
        else if(time == DayTime.Night)
        {
            time = DayTime.Moring;
            ap = 0;
            day += 1;
            GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
            Invoke("PadeOff", 2f);
        }
    }

    public void InnSleep()
    {
        if(uIManager.gold <= 50)
        {
            GameObject.Find("UICanvas").transform.Find("NotMoney").gameObject.SetActive(true);
        }
        else if(time == DayTime.Dawn || time == DayTime.Moring || time == DayTime.Lunch)
        {
            GameObject.Find("UICanvas").transform.Find("NoSleep").gameObject.SetActive(true);
        }
        else
        {
            if (time == DayTime.Evening)
            {
                uIManager.gold -= 50;
                time = DayTime.Dawn;
                ap = 0;
                day += 1;
                GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
                Invoke("PadeOff", 2f);
            }
            else if (time == DayTime.Night)
            {
                uIManager.gold -= 50;
                time = DayTime.Moring;
                ap = 0;
                day += 1;
                GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
                Invoke("PadeOff", 2f);
            }
        }
        
    }

    private void OnOff()
    {
        if (time == DayTime.Dawn || time == DayTime.Moring || time == DayTime.Lunch)
        {
            GameObject.Find("UICanvas").transform.Find("SleepBtn").gameObject.SetActive(false);
            
        }
        else if (time == DayTime.Evening || time == DayTime.Night)
        {
            GameObject.Find("UICanvas").transform.Find("SleepBtn").gameObject.SetActive(true);
            
        }
    }
    public void SceneChange()
    {
        switch (time)
        {
            case DayTime.Dawn:
                timeText.text = "시간 : 새벽";
                for(int i = 0; i < PlaceTime.Length; i++)
                {
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Dawn").gameObject.SetActive(true);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Evening").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Night").gameObject.SetActive(false);
                }
                break;

            case DayTime.Moring:
                timeText.text = "시간 : 아침";
                for (int i = 0; i < PlaceTime.Length; i++)
                {
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Morning").gameObject.SetActive(true);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Dawn").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Night").gameObject.SetActive(false);
                }
                break;

            case DayTime.Lunch:
                timeText.text = "시간 : 점심";
                break;

            case DayTime.Evening:
                timeText.text = "시간 : 저녁";
                for (int i = 0; i < PlaceTime.Length; i++)
                {
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Evening").gameObject.SetActive(true);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Morning").gameObject.SetActive(false);
                }
                break;

            case DayTime.Night:
                timeText.text = "시간 : 심야";
                for (int i = 0; i < PlaceTime.Length; i++)
                {
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Night").gameObject.SetActive(true);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Evening").gameObject.SetActive(false);
                }
                break;
        }
    }
    public void PadeOff()
    {
        GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(false);
    }
}

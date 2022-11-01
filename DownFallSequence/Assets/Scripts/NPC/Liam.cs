using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Liam : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public GameObject SoundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    private int FP = 41; //»£∞®µµ

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem LiamDialog01;
    [SerializeField]
    private CharaterDialogSystem LiamDialog02;
    [SerializeField]
    private CharaterDialogSystem LiamDialog03;
    [SerializeField]
    private CharaterDialogSystem LiamDialog04;
    [SerializeField]
    private CharaterDialogSystem LiamDialog05;
    [SerializeField]
    private CharaterDialogSystem LiamDialog06;
    [SerializeField]
    private CharaterDialogSystem LiamDialog07;
    [SerializeField]
    private CharaterDialogSystem LiamDialog08;
    [SerializeField]
    private CharaterDialogSystem LiamDialog09;
    [SerializeField]
    private CharaterDialogSystem LiamDialog10;
    [SerializeField]
    private CharaterDialogSystem LiamDialog11;
    [SerializeField]
    private CharaterDialogSystem LiamDialog12;
    [SerializeField]
    private CharaterDialogSystem LiamDialog13;
    [SerializeField]
    private CharaterDialogSystem LiamDialog14;
    [SerializeField]
    private CharaterDialogSystem LiamDialog15;
    [SerializeField]
    private CharaterDialogSystem LiamDialog16;
    [SerializeField]
    private CharaterDialogSystem LiamDialog17;
    [SerializeField]
    private CharaterDialogSystem LiamDialog18;
    [SerializeField]
    private CharaterDialogSystem LiamDialog19;
    [SerializeField]
    private CharaterDialogSystem LiamDialog20;
    [SerializeField]
    private CharaterDialogSystem LiamDialog21;
    [SerializeField]
    private CharaterDialogSystem LiamDialog22;
    [SerializeField]
    private CharaterDialogSystem LiamDialog23;
    [SerializeField]
    private CharaterDialogSystem LiamDialog24;
    [SerializeField]
    private CharaterDialogSystem LiamDialog25;
    [SerializeField]
    private CharaterDialogSystem LiamDialog26;
    [SerializeField]
    private CharaterDialogSystem LiamDialog27;
    [SerializeField]
    private CharaterDialogSystem LiamDialog28;
    [SerializeField]
    private CharaterDialogSystem LiamDialog29;
    [SerializeField]
    private CharaterDialogSystem LiamDialog30;
    [SerializeField]
    private CharaterDialogSystem LiamDialog31;
    [SerializeField]
    private CharaterDialogSystem LiamDialog32;
    [SerializeField]
    private CharaterDialogSystem LiamDialog33;
    [SerializeField]
    private CharaterDialogSystem LiamDialog34;
    [SerializeField]
    private CharaterDialogSystem LiamDialog35;
    [SerializeField]
    private CharaterDialogSystem LiamDialog36;
    [SerializeField]
    private CharaterDialogSystem LiamDialog37;
    [SerializeField]
    private CharaterDialogSystem LiamDialog38;
    [SerializeField]
    private CharaterDialogSystem LiamDialog39;
    [SerializeField]
    private CharaterDialogSystem LiamDialog40;
    [SerializeField]
    private CharaterDialogSystem LiamDialog41;
    [SerializeField]
    private CharaterDialogSystem LiamDialog42;
    [SerializeField]
    private CharaterDialogSystem LiamDialog43;
    [SerializeField]
    private CharaterDialogSystem LiamDialog44;
    [SerializeField]
    private CharaterDialogSystem LiamDialog45;
    [SerializeField]
    private CharaterDialogSystem LiamDialog46;
    [SerializeField]
    private CharaterDialogSystem LiamDialog47;
    [SerializeField]
    private CharaterDialogSystem LiamDialog48;
    [SerializeField]
    private CharaterDialogSystem LiamDialog49;
    [SerializeField]
    private CharaterDialogSystem LiamDialog50;
    [SerializeField]
    private CharaterDialogSystem LiamDialog51;
    [SerializeField]
    private CharaterDialogSystem LiamDialog52;
    [SerializeField]
    private CharaterDialogSystem LiamDialog53;
    [SerializeField]
    private CharaterDialogSystem LiamDialog54;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }
    public void StartBuyInfo()
    {
        StartCoroutine(BuyInfo());
    }

    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(FP);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        //timeManager.time
        if (FP <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => LiamDialog01.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog06.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog11.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog16.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog21.UpdateDialog()); //√÷æ«
                    break;
            }
        }
        else if (FP <= 40) //≥™ª›
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => LiamDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog22.UpdateDialog());
                    break;
            }
        }
        else if (FP <= 60)//∫∏≈Î
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => LiamDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog23.UpdateDialog());

                    break;
            }
        }
        else if (FP <= 80) //¡¡¿Ω
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => LiamDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog24.UpdateDialog());
                    break;
            }
        }
        else//Ω≈∑⁄
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => LiamDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamBuyInfoSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumorSB").gameObject.SetActive(true);
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamBuyInfoSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumorSB").gameObject.SetActive(false);
        if (FP <= 20) //√÷æ«
        {
            yield return new WaitUntil(() => LiamDialog26.UpdateDialog());
            FP += 2;
            timeManager.APClick();
        }
        else if (FP <= 40) //≥™ª›
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => LiamDialog27.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LiamDialog28.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LiamDialog29.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
            }
        }
        else if (FP <= 60) //∫∏≈Î
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => LiamDialog30.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LiamDialog31.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LiamDialog32.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LiamDialog33.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
            }
        }
        else if (FP <= 80) //¡¡¿Ω
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => LiamDialog34.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LiamDialog35.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LiamDialog36.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LiamDialog37.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => LiamDialog38.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => LiamDialog39.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => LiamDialog40.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
            }
        }
        else//Ω≈∑⁄
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => LiamDialog41.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LiamDialog42.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LiamDialog43.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LiamDialog44.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => LiamDialog45.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => LiamDialog46.UpdateDialog());
                    FP += 1;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }

    public IEnumerator BuyInfo()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamBuyInfoSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumorSB").gameObject.SetActive(false);
        switch (Random.Range(1, 9))
        {
            case 1:
                yield return new WaitUntil(() => LiamDialog47.UpdateDialog());
                FP += 5;
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => LiamDialog48.UpdateDialog());
                FP += 5;
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => LiamDialog49.UpdateDialog());
                FP += 5;
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => LiamDialog50.UpdateDialog());
                FP += 5;
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => LiamDialog51.UpdateDialog());
                FP += 5;
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => LiamDialog52.UpdateDialog());
                FP += 5;
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => LiamDialog53.UpdateDialog());
                FP += 5;
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => LiamDialog54.UpdateDialog());
                FP += 5;
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
}

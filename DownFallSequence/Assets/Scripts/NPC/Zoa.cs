using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Zoa : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public GameObject SoundManager;
    public GameManager gameManger;

    GameObject clickObject;
    UIManager uIManager;

    private int FP = 50; //»£∞®µµ

    bool Barracks = false;

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem ZoaDialog01;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog02;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog03;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog04;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog05;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog06;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog07;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog08;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog09;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog10;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog11;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog12;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog13;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog14;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog15;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog16;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog17;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog18;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog19;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog20;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog21;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog22;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog23;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog24;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog25;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog26;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog27;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog28;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog29;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog30;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog31;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog32;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog33;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog34;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog35;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog36;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog37;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog38;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog39;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog40;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog41;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog42;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog43;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog44;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog45;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog46;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog47;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog48;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog49;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog50;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog51;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog52;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog53;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog54;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog55;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog56;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog57;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog58;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog59;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog60;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog61;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog62;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog63;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog64;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog65;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog66;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog67;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog68;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog69;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog70;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog71;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog72;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog73;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog74;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    void Update()
    {
    }
    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }

    public void StartChatPersuade()
    {
        StartCoroutine(ChatPersuade());
    }

    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }

    private IEnumerator ChatStart()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        //timeManager.time
        if (FP <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => ZoaDialog01.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog06.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog11.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog16.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog21.UpdateDialog()); //√÷æ«
                    break;
            }
        }
        else if (FP <= 40) //≥™ª›
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => ZoaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (FP <= 60)//∫∏≈Î
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => ZoaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog23.UpdateDialog());

                    break;
            }
        }
        else if (FP <= 80) //¡¡¿Ω
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => ZoaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog24.UpdateDialog());
                    break;
            }
        }
        else//Ω≈∑⁄
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Moring:
                    yield return new WaitUntil(() => ZoaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (FP >= 91 && Barracks == false)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaPersuadeSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        if (FP <= 20) //√÷æ«
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog26.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog27.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (FP <= 40) //≥™ª›
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog29.UpdateDialog());
                            FP += 5;
                            timeManager.APClick();
                            break;
                        case "Zoa_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog30.UpdateDialog());
                            FP += 5;
                            timeManager.APClick();
                            break;
                        case "Zoa_Bad_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog31.UpdateDialog());
                            FP -= 10;
                            timeManager.APClick();
                            break;
                        case "Zoa_Bad_A_d":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog32.UpdateDialog());
                            FP -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog33.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ZoaDialog34.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ZoaDialog35.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => ZoaDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog37.UpdateDialog());
                            FP -= 8;
                            timeManager.APClick();
                            break;
                        case "Zoa_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog38.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (FP <= 60) //∫∏≈Î
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog39.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog41.UpdateDialog());
                            FP -= 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog42.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => ZoaDialog43.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ZoaDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog45.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog46.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => ZoaDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(true);
                    if (gameManger.WorldTrigger[0] == true)
                    { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(true); }
                    if (gameManger.WorldTrigger[1] == true)
                    { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(true); }
                    if (gameManger.WorldTrigger[2] == true)
                    { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(true); }
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Normal_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog48.UpdateDialog());
                            FP += 10;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog49.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_C_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog50.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_C_d":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog51.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_C_e":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog52.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (FP <= 80) //¡¡¿Ω
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog53.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog54.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ZoaDialog55.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ZoaDialog56.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => ZoaDialog57.UpdateDialog());
                    FP += 2;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => ZoaDialog58.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog59.UpdateDialog());
                            FP -= 3;
                            timeManager.APClick();
                            break;
                        case "Zoa_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog60.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//Ω≈∑⁄
        {
            int a = 3;
            if (gameManger.WorldTrigger[3] == false) { a = 4; }
            switch (Random.Range(1, a))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog61.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog62.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog63.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog64.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog65.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog66.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            gameManger.WorldTrigger[2] = true;  //πÏ∆ƒ¿ÃæÓ Ω√¡∂∞° ¡∏¿Á«œ¥¬ ¡ˆ æÀ∞‘ µ 
                            break;
                        case "Zoa_VeryGood_B_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog67.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            gameManger.WorldTrigger[0] = true;  //πŸ¥Ÿ±´π∞¿Ã ¡∏¿Á«œ¥¬ ¡ˆ æÀ∞‘ µ 
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => ZoaDialog68.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_VeryGood_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog69.UpdateDialog());
                            FP += 2;
                            timeManager.APClick();
                            gameManger.WorldTrigger[3] = true;
                            break;
                        case "Zoa_VeryGood_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog70.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaPersuadeSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => ZoaDialog71.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_a").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_b").gameObject.SetActive(true);
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "Zoa_Persuade_A_a":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_a").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_b").gameObject.SetActive(false);
                yield return new WaitUntil(() => ZoaDialog72.UpdateDialog());
                Barracks = true;
                break;
            case "Zoa_Persuade_A_b":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_a").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_b").gameObject.SetActive(false);
                yield return new WaitUntil(() => ZoaDialog73.UpdateDialog());
                break;
        }
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

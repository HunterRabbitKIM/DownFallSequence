using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    public GameObject map;
    public GameObject inventoryMenu;
    public GameObject Bulr;

    public Text GoldText;
    public int gold = 999999999;

    public Tooltips tooltip;

    GameManager gameManager;

    public bool LittleMap;


    private void Start()
    {
        inventoryMenu.gameObject.SetActive(false);
        map.gameObject.SetActive(false);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        LittleMap = false;
    }
    private void Update()
    {
        GoldText.text = "돈 : "+ gold.ToString() + " G";
    }
    public void InventoryControl()
    {
        //if game is paused, press escape, resume the game
        //게임이 일시 중지된 경우 Esc 키를 누르고 게임을 다시 시작합니다.
        if (GameManager.instance.isPaused)
        {
            Resume();
        }
        else
        {
            //if game is reusme, press escape, pasue the game
            //게임이 reusme이면 탈출을 누르고 게임을 일시 중지하십시오.
            Pause();

        }
        tooltip.HideTooltip();
    }
    public void MapContorl()
    {
        
        switch (gameManager.place)
        {
            //미니맵이 있을 경우
            case "HomeTown":
                if(LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(0, -0, -10);
                    LittleMap = false;
                }
                break;

            case "Home1":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(0, -30, -10);
                    LittleMap = false;
                }
                break;

            case "Home2":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(30, -30, -10);
                    LittleMap = false;
                }
                break;

            case "Setar": //세타르는 두개 만들어야함(광장이랑 대장간)
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-50, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(120, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SetarSmithy": //세타르는 두개 만들어야함(광장이랑 대장간)
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-50, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(150, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SetarChurch": 
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-50, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(180, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SetarArena":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-50, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(210, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SetarStable":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-50, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(400, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SetarGuild":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-50, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(420, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SetarInn":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-50, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(60, -30, -10);
                    LittleMap = false;
                }
                break;

            case "Solar":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(300, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SolarSmithy":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(330, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SolarChurch":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(360, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SolarGuild":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(450, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SolarGuildIn":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(180, -30, -10);
                    LittleMap = false;
                }
                break;

            case "SolarChurchIn":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(150, -30, -10);
                    LittleMap = false;
                }
                break;

            case "SolarStable":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(480, -0, -10);
                    LittleMap = false;
                }
                break;

            case "SolarInn":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(90, -30, -10);
                    LittleMap = false;
                }
                break;

            case "SolarLibrary":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(120, -30, -10);
                    LittleMap = false;
                }
                break;

            case "SolarCastle":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(0, -90, -10);
                    LittleMap = false;
                }
                break;

            case "SolarKnight":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-20, 60, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(30, -90, -10);
                    LittleMap = false;
                }
                break;

            case "Durkan":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 30, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(30, -60, -10);
                    LittleMap = false;
                }
                break;

            case "DurkanFish":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 30, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(0, -60, -10);
                    LittleMap = false;
                }
                break;

            case "DurkanPort":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 30, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(60, -60, -10);
                    LittleMap = false;
                }
                break;

            case "DurkanChurch":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 30, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(90, -60, -10);
                    LittleMap = false;
                }
                break;

            case "DurkanStable":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 30, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(120, -60, -10);
                    LittleMap = false;
                }
                break;

            case "DurkanGuild":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 30, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(150, -60, -10);
                    LittleMap = false;
                }
                break;

            case "DurkanInn":
                if (LittleMap == false)
                {
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                    cam.transform.position = new Vector3(-80, 30, -10);
                    LittleMap = true;
                }
                else
                {
                    map.gameObject.SetActive(false);
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    cam.transform.position = new Vector3(180, -60, -10);
                    LittleMap = false;
                }
                break;



            //월드맵만 있을 경우
            default:
                map.gameObject.SetActive(!map.active);
                if (map.active)
                {
                    cam.transform.position = new Vector3(-80, 90, -10);
                }
                else
                {
                    Debug.Log(gameManager.place);
                    switch (gameManager.place)
                    {
                        case "Home":
                            cam.transform.position = new Vector3(0, 0, -10);

                            break;
                        case "Rito_Forest":
                            cam.transform.position = new Vector3(30, 0, -10);
                            break;
                        case "Ruin":
                            cam.transform.position = new Vector3(60, 0, -10);
                            break;
                        case "Endes_Desrt":
                            cam.transform.position = new Vector3(90, 0, -10);
                            break;
                        case "Setar":
                            cam.transform.position = new Vector3(120, 0, -10);
                            break;
                        case "Ureta_Mount":
                            cam.transform.position = new Vector3(240, 0, -10);
                            break;
                        case "Zailpiton_Forest":
                            cam.transform.position = new Vector3(270, 0, -10);
                            break;
                        case "Solar":
                            cam.transform.position = new Vector3(300, 0, -10);
                            break;
                        case "Durkan":
                            cam.transform.position = new Vector3(30, -60, -10);
                            break;
                    }
                }
                break;
        }      
    }
    
    private void Resume()
    {
        inventoryMenu.gameObject.SetActive(false);
        Time.timeScale = 1.0f; //실제 시간이 1.0f
        GameManager.instance.isPaused = false;
    }
    private void Pause()
    {
        inventoryMenu.gameObject.SetActive(true);
        Time.timeScale = 0.0f; //멈춤
        GameManager.instance.isPaused = true;
    }

    public void ESCSB()
    {
        GameObject[] ChatList = GameObject.FindGameObjectsWithTag("Chat");
        foreach (GameObject Chat in ChatList)
        {
            Chat.SetActive(false);
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        Vector3 position = Bulr.transform.localPosition;
        position.x = -20;
        position.y = 0;
        Bulr.transform.localPosition = position;
        GameObject[] CharList = GameObject.FindGameObjectsWithTag("NPC");
        foreach (GameObject Character in CharList)
        {
            Character.GetComponent<BoxCollider2D>().enabled = true;
        }

    }

    public void ESC()
    {
        GameObject.Find("UICanvas").transform.Find("NotMoney").gameObject.SetActive(false);
        GameObject.Find("UICanvas").transform.Find("NoSleep").gameObject.SetActive(false);
    }
}

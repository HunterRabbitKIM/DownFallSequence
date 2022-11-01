using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    #region NPC
    [SerializeField]
    GameObject LeeSidol;
    [SerializeField]
    GameObject Misrica;
    [SerializeField]
    GameObject Nabita;
    [SerializeField]
    GameObject Zoa;
    [SerializeField]
    GameObject Liam_Dawn;
    [SerializeField]
    GameObject Liam_Morning;
    [SerializeField]
    GameObject Liam_Evening;
    [SerializeField]
    GameObject Liam_Night;
    #endregion

    public GameObject map;
    public GameObject Bulr;
    public TimeManager timeManager;
    public Vector3 BlurPosition;


    GameManager gameManager;
    UIManager uIManager;
    

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            if (hit.collider != null)
            {
                GameObject clickObject = hit.transform.gameObject;

                switch (clickObject.name)
                {
                    #region Place
                    case "HomeTownBtn": 
                        if(gameManager.place == "Rito_Forest")
                        {
                            
                            if(timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                timeManager.time += 1;
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(0, 0, -10);
                                gameManager.place = "HomeTown";
                                uIManager.LittleMap = false;
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            }
                        }
                        break;

                    case "RenaHomeBtn":
                        if (gameManager.place == "Home1" || gameManager.place == "Home2")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(0, -0, -10);
                                gameManager.place = "HomeTown";
                                uIManager.LittleMap = false;
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        break;

                    case "HomeBtn":
                        if (gameManager.place == "HomeTown" || gameManager.place == "Home2")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(0, -30, -10);
                                gameManager.place = "Home1";
                                uIManager.LittleMap = false;
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        break;

                    case "Home2Btn":
                        if (gameManager.place == "Home1" || gameManager.place == "HomeTown")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(30, -30, -10);
                                gameManager.place = "Home2";
                                uIManager.LittleMap = false;
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        break;

                    case "Rito_ForestBtn":
                        if(gameManager.place == "HomeTown" || gameManager.place == "Ruin" || gameManager.place == "Home" || gameManager.place == "Home2")
                        {
                            
                            if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                timeManager.time += 1;
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(30, 0, -10);
                                gameManager.place = "Rito_Forest";
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            }
                        }
                        break;

                    case "RuinsBtn":
                        if(gameManager.place == "Rito_Forest"||gameManager.place == "Endes_Derst")
                        {
                            
                            if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                timeManager.time += 1;
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(60, 0, -10);
                                gameManager.place = "Ruin";
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            }

                        }
                        break;

                    case "DesertBtn":
                        if(gameManager.place == "Ruin"|| gameManager.place == "Setar" || gameManager.place == "SetarGuild" || gameManager.place == "SetarSmithy" || gameManager.place == "SetarArena" || gameManager.place == "SetarChurch" || gameManager.place == "SetarStable" ||gameManager.place == "SetarInn"|| gameManager.place == "Ureta_Mount")
                        {
                            
                            if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                timeManager.time += 1;
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(90, 0, -10);
                                gameManager.place = "Endes_Derst";
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            }
                        }
                        
                        break;

                    case "SetarCityBtn":
                        if(gameManager.place == "Endes_Derst"|| gameManager.place == "Ureta_Mount")
                        {
                            
                            if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                timeManager.time += 1;
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(120, 0, -10);
                                gameManager.place = "Setar";
                                uIManager.LittleMap = false;
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            }
                        }
                        
                        break;

                    case "SetarPlazaBtn":
                        if(gameManager.place == "SetarSmithy"|| gameManager.place == "SetarArena"|| gameManager.place == "SetarChurch" || gameManager.place == "SetarInn")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if(timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(120, 0, -10);
                                gameManager.place = "Setar";
                                uIManager.LittleMap = false;
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                            
                        }
                        break;

                    case "SetarInnBtn":
                        if (gameManager.place == "Setar" || gameManager.place == "SetarSmithy" || gameManager.place =="SetarStable")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(60, -30, -10);
                                gameManager.place = "SetarInn";
                                uIManager.LittleMap = false;
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }

                        }
                        break;

                    case "SetarSmithyBtn":
                        if(gameManager.place == "Setar" || gameManager.place == "SetarInn" || gameManager.place == "SetarSmithy")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(150, 0, -10);
                                gameManager.place = "SetarSmithy";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        break;

                    case "SetarChurchBtn":
                        if (gameManager.place == "Setar")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(180, 0, -10);
                                gameManager.place = "SetarChurch";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        
                        break;

                    case "SetarArenaBtn":
                        if (gameManager.place == "Setar")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(210, 0, -10);
                                gameManager.place = "SetarArena";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        break;

                    case "SetarStableBtn":
                        if (gameManager.place == "SetarGuild")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(400, 0, -10);
                                gameManager.place = "SetarStable";
                                uIManager.LittleMap = false;
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }

                        }
                        break;

                    case "SetarGuildBtn":
                        if (gameManager.place == "SetarStable" || gameManager.place == "SetarInn")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(420, 0, -10);
                                gameManager.place = "SetarGuild";
                                uIManager.LittleMap = false;
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }

                        }
                        break;

                    case "UretaMountBtn":
                        if(gameManager.place == "Zailpiton_Forest"|| gameManager.place == "Endes_Derst"|| gameManager.place == "Setar" || gameManager.place == "SetarGuild" || gameManager.place == "SetarSmithy" || gameManager.place == "SetarArena" || gameManager.place == "SetarChurch" || gameManager.place == "SetarStable" || gameManager.place == "SetarInn")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                timeManager.time += 1;
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(240, 0, -10);
                                gameManager.place = "Ureta_Mount";
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            }
                            
                            
                        }
                        break;

                    case "ZailpitonBtn":
                        if(gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarStable" || gameManager.place =="SolarInn" || gameManager.place == "Ureta_Mount" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight" 
                            || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                        {
                            
                            if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                timeManager.time += 1;
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(270, 0, -10);
                                gameManager.place = "Zailpiton_Forest";
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            }
                        }
                        break;

                    case "SolCityBtn":
                        if(gameManager.place == "Zailpiton_Forest" || gameManager.place == "HomeTown")
                        {
                            
                            if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                timeManager.time += 1;
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(300, 0, -10);
                                gameManager.place = "Solar";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            }
                        }
                        break;

                    case "SolorPlazaBtn":
                        if (gameManager.place == "SolarGuild" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarLibrary" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(300, 0, -10);
                                gameManager.place = "Solar";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        break;

                    case "SolorGuildBtn":
                        if (gameManager.place == "Solar" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(450, 0, -10);
                                gameManager.place = "SolarGuild";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        
                        break;

                    case "SolorStableBtn":
                        if (gameManager.place == "Solar" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarInn" || gameManager.place == "SolarGuild" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(480, 0, -10);
                                gameManager.place = "SolarStable";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        
                        break;

                    case "SolorSmithyBtn":
                        if (gameManager.place == "Solar" || gameManager.place == "SolarChurch" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarGuild" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(330, 0, -10);
                                gameManager.place = "SolarSmithy";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        
                        break;

                    case "SolorChurchBtn":
                        if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(360, 0, -10);
                                gameManager.place = "SolarChurch";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }
                        
                        break;

                    case "SolorInnBtn":
                        if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarStable" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight") 
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(90, -30, -10);
                                gameManager.place = "SolarInn";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "SolorLibraryBtn":
                        if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(120, -30, -10);
                                gameManager.place = "SolarLibrary";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "SolGuildInBtn":
                        if (gameManager.place == "SolarGuild")
                        {
                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(180, -30, -10);
                            gameManager.place = "SolarGuildIn";
                            uIManager.LittleMap = false; //리틀맵이 있는 경우만
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        }

                        break;

                    case "SolGuildOutBtn":
                        if (gameManager.place == "SolarGuildIn")
                        {

                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(450, 0, -10);
                            gameManager.place = "SolarGuild";
                            uIManager.LittleMap = false; //리틀맵이 있는 경우만
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        }

                        break;

                    case "SolChurchInBtn":
                        if (gameManager.place == "SolarChurch")
                        {
                            
                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(150, -30, -10);
                            gameManager.place = "SolarChurchIn";
                            uIManager.LittleMap = false; //리틀맵이 있는 경우만
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        }

                        break;

                    case "SolChurchOutBtn":
                        if (gameManager.place == "SolarChurchIn")
                        {
                            
                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(360, 0, -10);
                            gameManager.place = "SolarChurch";
                            uIManager.LittleMap = false; //리틀맵이 있는 경우만
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        }

                        break;

                    case "SolorCastleBtn":
                        if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarLibrary")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(0, -90, -10);
                                gameManager.place = "SolarCastle";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "SolKnightInBtn":
                        if (gameManager.place == "SolarCastle")
                        {

                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(30, -90, -10);
                            gameManager.place = "SolarKnight";
                            uIManager.LittleMap = false; //리틀맵이 있는 경우만
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        }

                        break;

                    case "SolKnightOutBtn":
                        if (gameManager.place == "SolarKnight")
                        {

                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(0, -90, -10);
                            gameManager.place = "SolarCastle";
                            uIManager.LittleMap = false; //리틀맵이 있는 경우만
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        }

                        break;

                    case "DurkanCityBtn":
                        if (gameManager.place == "Zailpiton_Forest")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(30, -60, -10);
                                gameManager.place = "Durkan";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "DurkanPlazaBtn":
                        if (gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(30, -60, -10);
                                gameManager.place = "Durkan";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "DurkanFishBtn":
                        if (gameManager.place == "Durkan" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(0, -60, -10);
                                gameManager.place = "DurkanFish";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "DurkanPortBtn":
                        if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(60, -60, -10);
                                gameManager.place = "DurkanPort";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "DurkanChurchBtn":
                        if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(90, -60, -10);
                                gameManager.place = "DurkanChurch";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "DurkanStableBtn":
                        if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch"  || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(120, -60, -10);
                                gameManager.place = "DurkanStable";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "DurkanGuildBtn":
                        if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanInn")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(150, -60, -10);
                                gameManager.place = "DurkanGuild";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

                    case "DurkanInnBtn":
                        if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(180, -60, -10);
                                gameManager.place = "DurkanInn";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;
                    #endregion
                    case "LeeSidol":
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 90;
                        BlurPosition.y = -30;
                        Bulr.transform.localPosition = BlurPosition;
                        LeeSidol.GetComponent<LeeSidol>().StartChat();
                        break;

                    case "Misrica":
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 150;
                        BlurPosition.y = -30;
                        Bulr.transform.localPosition = BlurPosition;
                        Misrica.GetComponent<Misrica>().StartChat();
                        break;

                    case "Nabita":
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 360;
                        BlurPosition.y = 0;
                        Bulr.transform.localPosition = BlurPosition;
                        Nabita.GetComponent<Nabita>().StartChat();
                        break;

                    case "Zoa":
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 360;
                        BlurPosition.y = 0;
                        Bulr.transform.localPosition = BlurPosition;
                        Zoa.GetComponent<Zoa>().StartChat();
                        break;

                    //리암트훈
                    case "Liam_Dawn":
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 300;
                        BlurPosition.y = 0;
                        Bulr.transform.localPosition = BlurPosition;
                        Liam_Dawn.GetComponent<Liam>().StartChat();
                        break;
                    case "Liam_Morning":
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 300;
                        BlurPosition.y = 0;
                        Bulr.transform.localPosition = BlurPosition;
                        Liam_Morning.GetComponent<Liam>().StartChat();
                        break;
                    case "Liam_Evening":
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 300;
                        BlurPosition.y = 0;
                        Bulr.transform.localPosition = BlurPosition;
                        Liam_Evening.GetComponent<Liam>().StartChat();
                        break;
                    case "Liam_Night":
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 300;
                        BlurPosition.y = 0;
                        Bulr.transform.localPosition = BlurPosition;
                        Liam_Night.GetComponent<Liam>().StartChat();
                        break;
                }

            }

        }
    }
    public void WorldMap()
    {
        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
        map.gameObject.SetActive(true);
        cam.transform.position = new Vector3(-80, 90, -10);
        
        
    }
    
}

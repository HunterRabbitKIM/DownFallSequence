using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharaterDialogSystem : MonoBehaviour
{
    [SerializeField]
    private int charaterbranch;
    [SerializeField]
    private int leesidolbranch;
    [SerializeField]
    private int misricabranch;
    [SerializeField]
    private int nabitabranch;
    [SerializeField]
    private int zoabranch;
    [SerializeField]
    private int liambranch;
    [SerializeField]
    private DB dialogDB;
    [SerializeField]
    private CharaterSpeaker[] charaterspeakers;            //대화에 참여하는 캐릭터 UI 배열
    [SerializeField]
    private CharaterDialogData[] dialogs;         //현재 분기의 대사 목록 배열
    [SerializeField]
    private bool isAutoStart = true;      //자동 시작 여부
    private bool isFirst = true;          //최초 1회만 호출하기 위한 변수
    private int currentDialogIndex = -1;  //현재 대사 순번
    private int currentSpeakerIndex = 0;  //현재 말을 하는 회차의 speakers 배열 순번
    private float typingSpeed = 0.1f;     //텍스트 타이핑 효과의 재생속도
    private bool isTypingEffect = false;  //텍스트 타이핑 효과를 재생중인지

    public string character;

    private void Start()
    {
        
        int index = 0;
        switch (character)
        {
            case "Intro":
                for (int i = 0; i < dialogDB.Entities.Count; ++i)
                {
                    if (dialogDB.Entities[i].charaterbranch == charaterbranch)
                    {
                        dialogs[index].charatername = dialogDB.Entities[i].charatername;
                        dialogs[index].charaterdialog = dialogDB.Entities[i].charaterdialog;
                        index++;
                    }
                }
                break;

            case "LeeSidol":
               
                for (int i = 0; i < dialogDB.LeeSidol.Count; ++i)
                {
                    if (dialogDB.LeeSidol[i].leesidolbranch == leesidolbranch)
                    {
                        
                        dialogs[index].charatername = dialogDB.LeeSidol[i].leesidolname;
                        dialogs[index].charaterdialog = dialogDB.LeeSidol[i].leesidoldialog;
                        index++;
                    }
                }
                break;

            case "Misrica":

                for (int i = 0; i < dialogDB.Misrica.Count; ++i)
                {
                    if (dialogDB.Misrica[i].misricabranch == misricabranch)
                    {

                        dialogs[index].charatername = dialogDB.Misrica[i].misricaname;
                        dialogs[index].charaterdialog = dialogDB.Misrica[i].misricadialog;
                        index++;
                    }
                }
                break;

            case "Nabita":

                for (int i = 0; i < dialogDB.Nabita.Count; ++i)
                {
                    if (dialogDB.Nabita[i].nabitabranch == nabitabranch)
                    {
                        dialogs[index].charatername = dialogDB.Nabita[i].nabitaname;
                        dialogs[index].charaterdialog = dialogDB.Nabita[i].nabitadialog;
                        index++;
                    }
                }
                break;

            case "Zoa":

                for (int i = 0; i < dialogDB.Zoa.Count; ++i)
                {
                    if (dialogDB.Zoa[i].zoabranch == zoabranch)
                    {
                        dialogs[index].charatername = dialogDB.Zoa[i].zoaname;
                        dialogs[index].charaterdialog = dialogDB.Zoa[i].zoadialog;
                        index++;
                    }
                }
                break;

            case "Liam":

                for (int i = 0; i < dialogDB.Liam.Count; ++i)
                {
                    if (dialogDB.Liam[i].liambranch == liambranch)
                    {
                        dialogs[index].charatername = dialogDB.Liam[i].liamname;
                        dialogs[index].charaterdialog = dialogDB.Liam[i].liamdialog;
                        index++;
                    }
                }
                break;
        }
        Setup();
    }

    private void Setup()
    {
        //모든 대화 관련 게임오브젝트 비활성화
        for (int i = 0; i < charaterspeakers.Length; ++i)
        {
            SetActiveObjects(charaterspeakers[i], false);
            //캐릭터 이미지는 보이도록 설정
            charaterspeakers[i].charaterspriteRenderer.gameObject.SetActive(true);
        }
    }

    public bool UpdateDialog()
    {
        //대사 분기가 시작될떄 1회만 호출
        if (isFirst == true)
        {
            //초기화 캐릭터 이미지 활성화, 대사 관련UI는 모두 비활성화
            Setup();
            //자동 재생(inAutoStart=ture)으로 설정되어 있으면 첫번째 대사 재생
            if (isAutoStart) SetNextDialog();

            isFirst = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            //텍스트 타이핑 효과를 제생중일때 마우스 왼쪽 클릭하면 타이핑 효과 종료
            if (isTypingEffect == true)
            {
                isTypingEffect = false;

                //타이핑 효과를 중지하고, 현재 대사 전체를 출력한다
                StopCoroutine("OnTypingText");
                charaterspeakers[currentSpeakerIndex].charatertextDialogue.text = dialogs[currentDialogIndex].charaterdialog;
                //대사가 완료되었을 때 출력되는 커서 활성화
                charaterspeakers[currentSpeakerIndex].objectArrow.SetActive(true);

                return false;
            }
            //대사가 남아있을 경우 다음 대사 진행
            if (dialogs.Length > currentDialogIndex + 1)
            {
                SetNextDialog();
            }
            //대사 더 이상 없을 경우 모든 오브젝트를 비활성화하고 true로 변환
            else
            {
                //현 대화에 참여했던 모든 캐릭터, 대화 관련 UI를 보이지 않게 비활성화
                for (int i = 0; i < charaterspeakers.Length; ++i)
                {
                    SetActiveObjects(charaterspeakers[i], false);
                    //SetActiveObjects()에 캐릭터 이미지를 보이지 않게 하는 부분이 없기 때문에 별도로 호출
                    charaterspeakers[i].charaterspriteRenderer.gameObject.SetActive(false);
                }
                currentDialogIndex = -1;
                currentSpeakerIndex = 0;
                isFirst = true;
                return true;

            }
        }
        return false;
    }

    private void SetNextDialog()
    {
        //이전 회차의 대화 관련 오브젝트 비활성화
        SetActiveObjects(charaterspeakers[currentSpeakerIndex], false);

        //다음 대사를 진행하도록
        currentDialogIndex++;

        //현재 회차 준비 설정
        currentSpeakerIndex = dialogs[currentDialogIndex].speakerIndex;

        //현재 회차의 대화 관련 오브젝트 활성화
        SetActiveObjects(charaterspeakers[currentSpeakerIndex], true);

        //현재 회차 이름 텍스트 설정
        charaterspeakers[currentSpeakerIndex].charatertextName.text = dialogs[currentDialogIndex].charatername;

        //현재 회차의 대사 텍스트 설정
        //speakers[currentSpeakerIndex].textDialogue.text = dialogs[currentDialogIndex].dialogue;
        StartCoroutine("OnTypingText");
    }

    private void SetActiveObjects(CharaterSpeaker speaker, bool visible)
    {
        speaker.charaterimageDialog.gameObject.SetActive(visible);
        speaker.charatertextName.gameObject.SetActive(visible);
        speaker.charatertextDialogue.gameObject.SetActive(visible);
        speaker.charaternameImage.gameObject.SetActive(visible);

        //화살표는 대사가 종료되었을 떄만 활성화하기 때문에 항상 false
        speaker.objectArrow.SetActive(false);

        Color color = speaker.charaterspriteRenderer.color;
        color.a = visible == true ? 1 : 0f;
        speaker.charaterspriteRenderer.color = color;

    }

    private IEnumerator OnTypingText()
    {
        int index = 0;
        isTypingEffect = true;

        //텍스트를 한글자씩 타이핑치듯 재생
        while (index < dialogs[currentDialogIndex].charaterdialog.Length)
        {
            charaterspeakers[currentSpeakerIndex].charatertextDialogue.text = dialogs[currentDialogIndex].charaterdialog.Substring(0, index);

            index++;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTypingEffect = false;

        //대사가 완료되었을 떄 출력되는 커서 활성화
        charaterspeakers[currentSpeakerIndex].objectArrow.SetActive(true);
    }

    

}

[System.Serializable]
public struct CharaterSpeaker
{
    public SpriteRenderer charaterspriteRenderer;   //캐릭터 이미지
    public Image charaterimageDialog;               //대화창 Image UI
    public TextMeshProUGUI charatertextName;        //현재 대사중인 캐릭터 이름 출력 Text UI
    public TextMeshProUGUI charatertextDialogue;    //현재 대사 출력 TextUI
    public GameObject objectArrow;          //대가가 완료되었을 때 출력되는 커서 오브젝트
    public Image charaternameImage;                 //이름 뒷 배경
}

[System.Serializable]
public struct CharaterDialogData
{
    public int speakerIndex;    //이름과 대사를 출력할 현재 DialogSystem의 speakers 배열 순번
    public string charatername;
    [TextArea(3, 5)]
    public string charaterdialog;
}


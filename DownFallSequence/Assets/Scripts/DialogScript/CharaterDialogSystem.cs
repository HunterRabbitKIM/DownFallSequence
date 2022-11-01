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
    private CharaterSpeaker[] charaterspeakers;            //��ȭ�� �����ϴ� ĳ���� UI �迭
    [SerializeField]
    private CharaterDialogData[] dialogs;         //���� �б��� ��� ��� �迭
    [SerializeField]
    private bool isAutoStart = true;      //�ڵ� ���� ����
    private bool isFirst = true;          //���� 1ȸ�� ȣ���ϱ� ���� ����
    private int currentDialogIndex = -1;  //���� ��� ����
    private int currentSpeakerIndex = 0;  //���� ���� �ϴ� ȸ���� speakers �迭 ����
    private float typingSpeed = 0.1f;     //�ؽ�Ʈ Ÿ���� ȿ���� ����ӵ�
    private bool isTypingEffect = false;  //�ؽ�Ʈ Ÿ���� ȿ���� ���������

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
        //��� ��ȭ ���� ���ӿ�����Ʈ ��Ȱ��ȭ
        for (int i = 0; i < charaterspeakers.Length; ++i)
        {
            SetActiveObjects(charaterspeakers[i], false);
            //ĳ���� �̹����� ���̵��� ����
            charaterspeakers[i].charaterspriteRenderer.gameObject.SetActive(true);
        }
    }

    public bool UpdateDialog()
    {
        //��� �бⰡ ���۵ɋ� 1ȸ�� ȣ��
        if (isFirst == true)
        {
            //�ʱ�ȭ ĳ���� �̹��� Ȱ��ȭ, ��� ����UI�� ��� ��Ȱ��ȭ
            Setup();
            //�ڵ� ���(inAutoStart=ture)���� �����Ǿ� ������ ù��° ��� ���
            if (isAutoStart) SetNextDialog();

            isFirst = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            //�ؽ�Ʈ Ÿ���� ȿ���� �������϶� ���콺 ���� Ŭ���ϸ� Ÿ���� ȿ�� ����
            if (isTypingEffect == true)
            {
                isTypingEffect = false;

                //Ÿ���� ȿ���� �����ϰ�, ���� ��� ��ü�� ����Ѵ�
                StopCoroutine("OnTypingText");
                charaterspeakers[currentSpeakerIndex].charatertextDialogue.text = dialogs[currentDialogIndex].charaterdialog;
                //��簡 �Ϸ�Ǿ��� �� ��µǴ� Ŀ�� Ȱ��ȭ
                charaterspeakers[currentSpeakerIndex].objectArrow.SetActive(true);

                return false;
            }
            //��簡 �������� ��� ���� ��� ����
            if (dialogs.Length > currentDialogIndex + 1)
            {
                SetNextDialog();
            }
            //��� �� �̻� ���� ��� ��� ������Ʈ�� ��Ȱ��ȭ�ϰ� true�� ��ȯ
            else
            {
                //�� ��ȭ�� �����ߴ� ��� ĳ����, ��ȭ ���� UI�� ������ �ʰ� ��Ȱ��ȭ
                for (int i = 0; i < charaterspeakers.Length; ++i)
                {
                    SetActiveObjects(charaterspeakers[i], false);
                    //SetActiveObjects()�� ĳ���� �̹����� ������ �ʰ� �ϴ� �κ��� ���� ������ ������ ȣ��
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
        //���� ȸ���� ��ȭ ���� ������Ʈ ��Ȱ��ȭ
        SetActiveObjects(charaterspeakers[currentSpeakerIndex], false);

        //���� ��縦 �����ϵ���
        currentDialogIndex++;

        //���� ȸ�� �غ� ����
        currentSpeakerIndex = dialogs[currentDialogIndex].speakerIndex;

        //���� ȸ���� ��ȭ ���� ������Ʈ Ȱ��ȭ
        SetActiveObjects(charaterspeakers[currentSpeakerIndex], true);

        //���� ȸ�� �̸� �ؽ�Ʈ ����
        charaterspeakers[currentSpeakerIndex].charatertextName.text = dialogs[currentDialogIndex].charatername;

        //���� ȸ���� ��� �ؽ�Ʈ ����
        //speakers[currentSpeakerIndex].textDialogue.text = dialogs[currentDialogIndex].dialogue;
        StartCoroutine("OnTypingText");
    }

    private void SetActiveObjects(CharaterSpeaker speaker, bool visible)
    {
        speaker.charaterimageDialog.gameObject.SetActive(visible);
        speaker.charatertextName.gameObject.SetActive(visible);
        speaker.charatertextDialogue.gameObject.SetActive(visible);
        speaker.charaternameImage.gameObject.SetActive(visible);

        //ȭ��ǥ�� ��簡 ����Ǿ��� ���� Ȱ��ȭ�ϱ� ������ �׻� false
        speaker.objectArrow.SetActive(false);

        Color color = speaker.charaterspriteRenderer.color;
        color.a = visible == true ? 1 : 0f;
        speaker.charaterspriteRenderer.color = color;

    }

    private IEnumerator OnTypingText()
    {
        int index = 0;
        isTypingEffect = true;

        //�ؽ�Ʈ�� �ѱ��ھ� Ÿ����ġ�� ���
        while (index < dialogs[currentDialogIndex].charaterdialog.Length)
        {
            charaterspeakers[currentSpeakerIndex].charatertextDialogue.text = dialogs[currentDialogIndex].charaterdialog.Substring(0, index);

            index++;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTypingEffect = false;

        //��簡 �Ϸ�Ǿ��� �� ��µǴ� Ŀ�� Ȱ��ȭ
        charaterspeakers[currentSpeakerIndex].objectArrow.SetActive(true);
    }

    

}

[System.Serializable]
public struct CharaterSpeaker
{
    public SpriteRenderer charaterspriteRenderer;   //ĳ���� �̹���
    public Image charaterimageDialog;               //��ȭâ Image UI
    public TextMeshProUGUI charatertextName;        //���� ������� ĳ���� �̸� ��� Text UI
    public TextMeshProUGUI charatertextDialogue;    //���� ��� ��� TextUI
    public GameObject objectArrow;          //�밡�� �Ϸ�Ǿ��� �� ��µǴ� Ŀ�� ������Ʈ
    public Image charaternameImage;                 //�̸� �� ���
}

[System.Serializable]
public struct CharaterDialogData
{
    public int speakerIndex;    //�̸��� ��縦 ����� ���� DialogSystem�� speakers �迭 ����
    public string charatername;
    [TextArea(3, 5)]
    public string charaterdialog;
}


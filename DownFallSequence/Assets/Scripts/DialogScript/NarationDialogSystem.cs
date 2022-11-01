using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NarationDialogSystem : MonoBehaviour
{
    [SerializeField]
    private int branch;
    [SerializeField]
    private DB dialogDB;
    [SerializeField]
    private Speaker[] speakers;            //��ȭ�� �����ϴ� ĳ���� UI �迭
    [SerializeField]
    private DialogData[] dialogs;         //���� �б��� ��� ��� �迭
    [SerializeField]
    private bool isAutoStart = true;      //�ڵ� ���� ����
    private bool isFirst = true;          //���� 1ȸ�� ȣ���ϱ� ���� ����
    private int currentDialogIndex = -1;  //���� ��� ����
    private int currentSpeakerIndex = 0;  //���� ���� �ϴ� ȸ���� speakers �迭 ����
    private float typingSpeed = 0.1f;     //�ؽ�Ʈ Ÿ���� ȿ���� ����ӵ�
    private bool isTypingEffect = false;  //�ؽ�Ʈ Ÿ���� ȿ���� ���������

    private void Awake()
    {
        int index = 0;
        for (int i = 0; i < dialogDB.Naration.Count; ++i)
        {
            if (dialogDB.Naration[i].branch == branch)
            {
                dialogs[index].name = dialogDB.Naration[i].name;
                dialogs[index].dialogue = dialogDB.Naration[i].dialog;
                index++;
            }
        }

        Setup();
    }

    private void Setup()
    {
        //��� ��ȭ ���� ���ӿ�����Ʈ ��Ȱ��ȭ
        for (int i = 0; i < speakers.Length; ++i)
        {
            SetActiveObjects(speakers[i], false);
            //ĳ���� �̹����� ���̵��� ����
            speakers[i].spriteRenderer.gameObject.SetActive(true);
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
                speakers[currentSpeakerIndex].textDialogue.text = dialogs[currentDialogIndex].dialogue;
                //��簡 �Ϸ�Ǿ��� �� ��µǴ� Ŀ�� Ȱ��ȭ
                speakers[currentSpeakerIndex].objectArrow.SetActive(true);

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
                for (int i = 0; i < speakers.Length; ++i)
                {
                    SetActiveObjects(speakers[i], false);
                    //SetActiveObjects()�� ĳ���� �̹����� ������ �ʰ� �ϴ� �κ��� ���� ������ ������ ȣ��
                    speakers[i].spriteRenderer.gameObject.SetActive(false);
                }
                return true;
            }
        }
        return false;
    }

    private void SetNextDialog()
    {
        //���� ȸ���� ��ȭ ���� ������Ʈ ��Ȱ��ȭ
        SetActiveObjects(speakers[currentSpeakerIndex], false);

        //���� ��縦 �����ϵ���
        currentDialogIndex++;

        //���� ȸ�� �غ� ����
        currentSpeakerIndex = dialogs[currentDialogIndex].speakerIndex;

        //���� ȸ���� ��ȭ ���� ������Ʈ ��Ȱ��ȭ
        SetActiveObjects(speakers[currentSpeakerIndex], true);

        //���� ȸ�� �̸� �ؽ�Ʈ ����
        speakers[currentSpeakerIndex].textName.text = dialogs[currentDialogIndex].name;

        //���� ȸ���� ��� �ؽ�Ʈ ����
        //speakers[currentSpeakerIndex].textDialogue.text = dialogs[currentDialogIndex].dialogue;
        StartCoroutine("OnTypingText");
    }

    private void SetActiveObjects(Speaker speaker, bool visible)
    {
        speaker.imageDialog.gameObject.SetActive(visible);
        speaker.textName.gameObject.SetActive(visible);
        speaker.textDialogue.gameObject.SetActive(visible);
        speaker.nameImage.gameObject.SetActive(visible);

        //ȭ��ǥ�� ��簡 �����Ǿ��� ���� Ȱ��ȭ�ϱ� ������ �׻� false
        speaker.objectArrow.SetActive(false);

        
    }

    private IEnumerator OnTypingText()
    {
        int index = 0;
        isTypingEffect = true;

        //�ؽ�Ʈ�� �ѱ��ھ� Ÿ����ġ�� ���
        while (index < dialogs[currentDialogIndex].dialogue.Length)
        {
            speakers[currentSpeakerIndex].textDialogue.text = dialogs[currentDialogIndex].dialogue.Substring(0, index);

            index++;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTypingEffect = false;

        //��簡 �Ϸ�Ǿ��� �� ��µǴ� Ŀ�� Ȱ��ȭ
        speakers[currentSpeakerIndex].objectArrow.SetActive(true);
    }

}

[System.Serializable]
public struct Speaker
{
    public SpriteRenderer spriteRenderer;   //ĳ���� �̹���
    public Image imageDialog;               //��ȭâ Image UI
    public TextMeshProUGUI textName;        //���� ������� ĳ���� �̸� ��� Text UI
    public TextMeshProUGUI textDialogue;    //���� ��� ��� TextUI
    public GameObject objectArrow;          //�밡�� �Ϸ�Ǿ��� �� ��µǴ� Ŀ�� ������Ʈ
    public Image nameImage;                 //�̸� �� ���
}

[System.Serializable]
public struct DialogData
{
    public int speakerIndex;    //�̸��� ��縦 ����� ���� DialogSystem�� speakers �迭 ����
    public string name;
    [TextArea(3, 5)]
    public string dialogue;
}

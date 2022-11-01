using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class DB : ScriptableObject
{
	public List<DialogDBEntity> Entities; // Replace 'EntityType' to an actual type that is serializable.
	public List<DialogDBEntity> Naration;
	//==========�ֶ���ν�================================================================================
	public List<DialogDBEntity> LeeSidol; //�ֶ���ν� ���� �̾���
	public List<DialogDBEntity> Misrica; //�ֶ���ν� ���� ��Ȳ
	public List<DialogDBEntity> Zoa; //�ֶ���ν� ���� �Ϲ� ����
	public List<DialogDBEntity> Nabita; //�ֶ���ν� ���� 2�� �����
	public List<DialogDBEntity> Liam;   //�ֶ���ν� ���� ��������
}

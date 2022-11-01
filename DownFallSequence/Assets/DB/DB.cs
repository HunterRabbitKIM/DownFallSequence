using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class DB : ScriptableObject
{
	public List<DialogDBEntity> Entities; // Replace 'EntityType' to an actual type that is serializable.
	public List<DialogDBEntity> Naration;
	//==========솔라오로스================================================================================
	public List<DialogDBEntity> LeeSidol; //솔라오로스 여관 이씨돌
	public List<DialogDBEntity> Misrica; //솔라오로스 성당 교황
	public List<DialogDBEntity> Zoa; //솔라오로스 성당 일반 사제
	public List<DialogDBEntity> Nabita; //솔라오로스 성당 2등 성기사
	public List<DialogDBEntity> Liam;   //솔라오로스 광장 음유시인
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EquipmentSettings")]
public class EquipmentSettings : ScriptableObject
{
	[Header("Name")]
	public string equipmentName;
	public Sprite icon;
	public int value;
	public EquipmentType equipmentType;

	//[Header("Base")]
	//public Color skinColor;
	//public Sprite eyeShape;
	//public Color eyeColor;
	//[Header("Hair")]
	//public Sprite hair;
	//public Sprite facialHair;
	//public Sprite eyebrowShape;
	//public Color hairColor;
	[Header("Headwear")]
	public Sprite headwear;
	public Color headwearColor;
	[Header("Shoulders")]
	public Sprite leftShoulder;
	public Color leftShoulderColor;
	[Space(5)]
	public Sprite rightShoulder;
	public Color rightShoulderColor;
	[Header("Left Arm")]
	public Sprite leftUpperArmEquipment;
	public Color leftUpperArmEquipmentColor;
	[Space(5)]
	public Sprite leftLowerArmEquipment;
	public Color leftLowerArmEquipmentColor;
	[Space(5)]
	public Sprite leftHandEquipment;
	public Color leftHandEquipmentColor;
	[Header("Right Arm")]
	public Sprite rightUpperArmEquipment;
	public Color rightUpperArmEquipmentColor;
	[Space(5)]
	public Sprite rightLowerArmEquipment;
	public Color rightLowerArmEquipmentColor;
	[Space(5)]
	public Sprite rightHandEquipment;
	public Color rightHandEquipmentColor;
	[Header("Upper Body")]
	public Sprite chestEquipment;
	public Color chestEquipmentColor;
	[Space(5)]
	public Sprite bodyEquipment;
	public Color bodyEquipmentColor;
	[Space(5)]
	public Sprite belt;
	public Color beltColor;
	[Space(5)]
	public Sprite hipEquipment;
	public Color hipEquipmentColor;
	[Header("Left Leg")]
	public Sprite leftUpperLegEquipment;
	public Color leftUpperLegEquipmentColor;
	[Space(5)]
	public Sprite leftLowerLegEquipment;
	public Color leftLowerLegEquipmentColor;
	[Space(5)]
	public Sprite leftFootEquipment;
	public Color leftFootEquipmentColor;
	[Header("Right Leg")]
	public Sprite rightUpperLegEquipment;
	public Color rightUpperLegEquipmentColor;
	[Space(5)]
	public Sprite rightLowerLegEquipment;
	public Color rightLowerLegEquipmentColor;
	[Space(5)]
	public Sprite rightFootEquipment;
	public Color rightFootEquipmentColor;
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Object/Character", order = 0)]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public string characterCode;

    public HeadSprites[] headSprites;
    public BodySprites[] bodySprites;
}

[Serializable]
public class HeadSprites
{
    public Sprite idle;
    public Sprite attack;
}

[Serializable]
public class BodySprites
{
    public Sprite idle;
    public List<Sprite> move;
}
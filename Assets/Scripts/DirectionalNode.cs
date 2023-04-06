using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        SwitchSprite();
    }


    void SwitchSprite()
    {
        if(current == "left")
        {
            print("Choosing left sprite!");
            sr.sprite = left;
        }
        else if(current == "right")
        {
            print("Choosing right sprite!");
            sr.sprite = right;
        }
        else
        {
            print("Choosing sprite none!");
            sr.sprite = none;
        }
    }
}

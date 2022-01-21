using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBackground : MonoBehaviour
{
    [SerializeField] public SpaceMove spaceMove;
    private bool moveLeft, moveRight;

    private void Start()
    {
        moveLeft = true;
        moveRight = false;
    }

    private void Update()
    {
        if (moveLeft == true)
        {
            Left();         
        }
        else
        {
            Right();
        }
        
        if (spaceMove.img.uvRect.x > 0.01f)
        {
            moveLeft = false;
            moveRight = true;
        }
        else if (spaceMove.img.uvRect.x < -0.01f)
        {
            moveRight = false;
            moveLeft = true;
        }
       
    }
    
    public void Left()
    {
        spaceMove.img.uvRect = new Rect(spaceMove.img.uvRect.position + new Vector2(spaceMove.x + 0.001f, spaceMove.y) * Time.deltaTime, spaceMove.img.uvRect.size);
    }

    public void Right()
    {
        spaceMove.img.uvRect = new Rect(spaceMove.img.uvRect.position + new Vector2(spaceMove.x - 0.001f, spaceMove.y) * Time.deltaTime, spaceMove.img.uvRect.size);
    }

}

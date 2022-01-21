using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBackground : MonoBehaviour
{
    [SerializeField] public SpaceMove spaceMove;
    private bool moveLeft, moveRight;
    public float moveSpeed;
    public float maxRangeLeft, maxRangeRight;
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
        
        if (spaceMove.img.uvRect.x > maxRangeLeft)
        {
            moveLeft = false;
            moveRight = true;
        }
        else if (spaceMove.img.uvRect.x < maxRangeRight)
        {
            moveRight = false;
            moveLeft = true;
        }
       
    }
    
    public void Left()
    {
        spaceMove.img.uvRect = new Rect(spaceMove.img.uvRect.position + new Vector2(spaceMove.x + moveSpeed, spaceMove.y) * Time.deltaTime, spaceMove.img.uvRect.size);
    }

    public void Right()
    {
        spaceMove.img.uvRect = new Rect(spaceMove.img.uvRect.position + new Vector2(spaceMove.x - moveSpeed, spaceMove.y) * Time.deltaTime, spaceMove.img.uvRect.size);
    }

}

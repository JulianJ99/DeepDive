using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUnit : MonoBehaviour {
    public string UnitName;
    public Tile OccupiedTile;
    public Faction Faction;

    public Transform movePoint;

    public Animator anim; 

    [SerializeField] public int health;

    [SerializeField] public int attack;

    [SerializeField] public int defense;

    [SerializeField] public int movementRange;

    [SerializeField] public float moveSpeed = 5f;

    public LayerMask whatStopsMovement;

    void Start(){
        movePoint.parent = null;
    }

    public void CharacterMovement(){
        
        //Quick and dirty fix for moving outside of the grid
        Vector3 vectorMinimal = new Vector3(-0.1f, -0.1f);
        Vector3 vectorMaximal = new Vector3(15.1f, 8.1f);


            if(movePoint.position.x > vectorMinimal.x && movePoint.position.x < vectorMaximal.x && movePoint.position.y > vectorMinimal.y && movePoint.position.y < vectorMaximal.y){
                transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
            }
            else{
                movePoint.position = transform.position;
            }
       

        if (Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f), .2f, whatStopsMovement))
                {
                        movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f);
                        movementRange =- 1;
                }
            } 
            
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical")), .2f, whatStopsMovement))
                {
                        movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"));
                        movementRange =- 1;
                }
            }
            
        } 
    }
}

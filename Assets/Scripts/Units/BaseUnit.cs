using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUnit : MonoBehaviour {
    public string UnitName;
    public Tile OccupiedTile;
    public Faction Faction;

    [SerializeField] private int health;

    [SerializeField] private int attack;

    [SerializeField] private int defense;

    [SerializeField] private int movementRange;

    [SerializeField] private int speed;

    public void CharacterMovement(){
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (UnitManager.Instance.SelectedHero != null) {
            Debug.Log("Selected");
            UnitManager.Instance.SelectedHero.transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (UnitManager.Instance.SelectedHero != null) {
            Debug.Log("Selected");
            UnitManager.Instance.SelectedHero.transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (UnitManager.Instance.SelectedHero != null) {
            Debug.Log("Selected");
            UnitManager.Instance.SelectedHero.transform.position += Vector3.up * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (UnitManager.Instance.SelectedHero != null) {
            Debug.Log("Selected");
            UnitManager.Instance.SelectedHero.transform.position += Vector3.down * speed * Time.deltaTime;
            }
        }

    }
}

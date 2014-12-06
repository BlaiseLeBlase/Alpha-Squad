using UnityEngine;
using System.Collections;

public  class Unit : MonoBehaviour {
	public Vector2 Coord;		//Координаты юнита
	public int Armor;		//Количество Брони
	public int Health;		//Максимальное количество жизней
	public int CurrentHealth;		//Текущее количество жизней
	public bool IsSelected;		//Выделение юнита для действий
	public float Speed; //Скорость передвижения
	public float Turnate; //Скорость поворота

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		}
}

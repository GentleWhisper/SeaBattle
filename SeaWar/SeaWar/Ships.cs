﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ship : MonoBehaviour {

    // возможные типы кораблей
    public enum Type
    {
        Destroyer = 0,
        Cruiser = 1,
        Battleship = 2,
        AircraftCarrier = 3,
    }

    // количество клеток каждого типа корабля
    static int[] ShipLengths = new int[] { 1, 2, 3, 4 };
    // максимальное количество кораблей каждого типа
    static int[] ShipMaxCounts = new int[] { 4, 3, 2, 1 };
    // повороты каждого типа корабля, чтоб он правильно распологался на поле
    static Vector3[] ShipRotation = new Vector3[] { 
		new Vector3(270, 180, 0),
		new Vector3(0, 180, 0),
		new Vector3(180, 0, 0),
		new Vector3(270, 0, 0)
	};
    // смещение каждого типа корабля в горизонтальном положении
    static Vector3[] ShipPositionHor = new Vector3[] { 
		new Vector3(0.5f, 0, 0),
		new Vector3(0, 0, 0),
		new Vector3(-0.3f, 0, 0),
		new Vector3(0, 0, -0.2f)
	};
    // смещение каждого типа корабля в вертикальном положении
    static Vector3[] ShipPositionVer = new Vector3[] { 
		new Vector3(0, 0, -0.5f),
		new Vector3(0, 0, 0),
		new Vector3(0, 0, 0.3f),
		new Vector3(-0.3f, 0, 0)
	};
    // масштаб каждого корабля
    static Vector3[] ShipScale = new Vector3[] { 
		new Vector3(1, 1, 1),
		new Vector3(1, 1, 1),
		new Vector3(1, 1, 1),
		new Vector3(1, 1, 1)
	};

    // вектор для изменения положения корабля из горизонтального в вертикальное
    Vector3 VerticalRotations = new Vector3(0, 90, 0);

}

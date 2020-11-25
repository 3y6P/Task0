using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class go_Arr : MonoBehaviour
{
    public GameObject[] NewGameObjects = new GameObject[10];
    public GameObject[] OldGameObjects = new GameObject[10];
    
    /// <summary>
    /// Замена случайного элемента массива на случайный элемент другого массива
    /// </summary>
    /// <param name="_newGameObjects">Новый массив</param>
    /// <param name="_oldGameObjects">Старый массив</param>
    /// <returns></returns>
    public GameObject[] CheckArray(GameObject[] _newGameObjects, GameObject[] _oldGameObjects)
    {
        Debug.Log("CheckArray was started!");
            for (int i = 0; i < _oldGameObjects.Length; i++)
            {
                 Random _rnd0 = new Random();
                    int x0 = _rnd0.Next(0, _oldGameObjects.Length - 1);
                    int x1 = _rnd0.Next(0, _newGameObjects.Length - 1);
                        //Замена элементов массива
                        if (_oldGameObjects[x0] != null)
                        {
                            _newGameObjects[x1] = _oldGameObjects[x0];
                            Debug.Log("Заменен эелмент");
                        }
                        else
                        {
                            Debug.Log(x0 + " -> NULL");
                        }

            }

        return _newGameObjects;
    }

    public void _ButtonClick()
    {
        NewGameObjects = CheckArray(NewGameObjects,OldGameObjects);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

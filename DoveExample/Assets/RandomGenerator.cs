using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomGenerator : MonoBehaviour
{

    public InputField HawkInput;
	public InputField DoveInput;
	public InputField FoodInput;
	public InputField EnergyValue;
	public InputField EnergyLoss;
	public InputField DeathThreshold;
	public InputField Reproduction;
	public InputField FoodExpiration;


    //public Vector3 center;
    public GameObject dove;
    public GameObject hawk;
    public GameObject food;

    private Vector3 Min;
    private Vector3 Max;
    private int multiplecreation = 0;

    private float _xAxis;
    private float _yAxis;
    private float _zAxis;
    private Vector3 _randomPosition;
    public bool _canInstantiate;

    public void Start()
    {

        SetRanges();

    }
    public void Update()
    {
        if (multiplecreation.Equals(1))
        {
            InstantiateRandomObjects(dove);
            InstantiateRandomObjects(hawk);
            InstantiateRandomObjects(food);
        }

    }



    public void onStart()
    {

        int dovevalue = int.Parse(DoveInput.text);
        int hawkvalue = int.Parse(HawkInput.text);
        int foodvalue = int.Parse(FoodInput.text);

        for (int i = 0; i < dovevalue; i++)
        {
            InstantiateRandomObjects(dove);
        }

        for (int i = 0; i < hawkvalue; i++)
        {
            InstantiateRandomObjects(hawk);

        }
        for (int i = 0; i < foodvalue; i++)
        {
            InstantiateRandomObjects(food);

        }
        multiplecreation = 1;
    }

    public void onStop()
    {
        Destroy(this.gameObject);
    }
    public void SetRanges()
    {
        Min = new Vector3(0, 0, 0);
        Max = new Vector3(5, 5, 0); 
    }
    public void InstantiateRandomObjects(GameObject gameObject)
    {
        _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
        _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
        _zAxis = 0;
        _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);
        if (_canInstantiate)
        {
            Instantiate(gameObject, _randomPosition, Quaternion.identity);
        }

    }
}
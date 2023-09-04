using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton setup
    public static GameManager Instance {get; private set;}

    [Header("Parameters")]
    [SerializeField] private int startingPopulation = 100;
    [SerializeField] private int startingMoney = 100;
    [SerializeField] private int startingHappiness = 100;
    [SerializeField] private int startingFood = 100;
    
    private int population, money, happiness, food;

    private void Awake() {
        Instance = this;
    }
    private void Start() {
        // Start variables
        population = startingPopulation;
        money = startingMoney;
        happiness = startingHappiness;
        food = startingFood;
    }

    public void AddToFood(int foodDelta) => food += foodDelta;
    public void AddToHappiness(int happinessDelta) => happiness += happinessDelta;
    public void AddToMoney(int moneyDelta) => money += moneyDelta;
    public void AddToPopulation(int populationDelta) => population += populationDelta;
}

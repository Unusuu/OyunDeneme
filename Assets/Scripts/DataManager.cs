using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;


public class DataManager : MonoBehaviour
{
    EasyFileSave myFile;
    private int shotBullet;
    public int totalShotBullet;
    private int enemyKilled;
    public int totalEnemyKilled;
    public static DataManager Instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            StartProcess();
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int EnemyKilled
    {
        get
        {
            return enemyKilled;
        }
        set
        {
            enemyKilled = value;
            GameObject.Find("EnemyKilledText").GetComponent<Text>().text = "ENEMY KILLED : " + enemyKilled.ToString();
            WinProcess();
        }
    }
    public int ShotBullet 
    {
        get
        {
            return shotBullet;
        }
        set
        {
            shotBullet = value;
            GameObject.Find("ShotBulletText").GetComponent<Text>().text = "SHOT BULLET : " + shotBullet.ToString();
        }
    }
    void StartProcess()
    {
        myFile = new EasyFileSave();
        LoadData();
    }
    public void SaveData()
    {
        totalEnemyKilled += EnemyKilled;
        totalShotBullet += shotBullet;
        myFile.Add("totalEnemyKilled", totalEnemyKilled);
        myFile.Add("totalShotBullet", totalShotBullet);
        myFile.Save();
    }
    public void LoadData()
    {
        if(myFile.Load())
        {
            totalShotBullet = myFile.GetInt("totalShotBullet");
            totalEnemyKilled = myFile.GetInt("totalEnemyKilled");
        }
    }
    public void WinProcess()
    {
        if (enemyKilled>=5)
        {
            print("KAZANDINIZ!");
        }
    }
    public void LoseProcess()
    {
        print("KAYBETTİNİZ!");
    }
}

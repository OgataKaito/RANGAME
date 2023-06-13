using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public GameObject _ground;
    public GameObject _player;

    [Tooltip("ステージのリスト")]
    List<GameObject> _stageList = new List<GameObject>();
    private float _spawn = 0;
    [SerializeField] int _startstage = 3;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_ground, new Vector3(0, 0, 10), Quaternion.identity);
        for (int i = 0; i < _startstage; i++)
        {
            CreateStage();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (_player.transform.position.z > _spawn -10 * _startstage)
        {
            CreateStage();
        }
    }
    private void CreateStage()
    {
        GameObject createStage = Instantiate(_ground, new Vector3(0, 0, _spawn), Quaternion.identity);
        _spawn += 10;
        _stageList.Add(createStage);
        if (_stageList.Count > _startstage + 1) 
        {
            GameObject oldStage = _stageList[0];
            _stageList.RemoveAt(0);
            Destroy(oldStage);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance = null;
    public Transform BladeTransform, PlayAgainButtonTransform;
    public GameObject FishObj;
    public bool Flipped;

    private FishController _fishController;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        Flipped = false;
        //BladeTransform.localPosition = Vector3.right * 5;
        InitializeFish();
    }

    public void InitializeFish()
    {
        _fishController = FishObj.GetComponent<FishController>();
        if (_fishController == null)
        {
            print("_fishController is not set");
            return;
        }
    }

    public void WonGame()
    {
        RotateFishUnlimited();
        PlayAgainButtonTransform.DOLocalMoveY(-200, 0.5f);
    }

    private void RotateFishUnlimited(int cnt = 0)
    {
        Vector3 initialRotation = new Vector3(-90, cnt * 180, 0);
        FishObj.transform.localRotation = Quaternion.Euler(initialRotation);
        FishObj.transform.DOLocalRotate(initialRotation + Vector3.up * 180, 01.4f).OnComplete(() => RotateFishUnlimited((cnt + 1) % 2)).SetEase(Ease.Linear);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

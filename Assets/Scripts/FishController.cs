using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FishController : MonoBehaviour
{
    private bool cleaningSide1;

    private void Start()
    {
        cleaningSide1 = true;
    }

    public void GenerateScales()
    {
        float x1, x2, y1, y2;
        float initialScale = 1, initialDistance = 0.8f;
        float finalScaleRatio = 0.8f;
    }

    /*public void RemoveScale(float duration)
    {
        sliderImageArr[sliderCount].DOFillAmount(0, duration);
        sliderCount++;
        if (sliderCount >= sliderImageArr.Length)
        {
            if (cleaningSide1)
            {
                DOTween.Sequence().AppendInterval(1).AppendCallback(FlipFish);
            }
            else
            {
                GameController.Instance.WonGame();
            }
        }
    }

    private void FlipFish()
    {
        GameController.Instance.Flipped = true;
        GameController.Instance.BladeTransform.localScale = new Vector3(-1, 1, 1);
        sliderCount = 0;
        cleaningSide1 = false;
        transform.DOLocalRotate(new Vector3(-90, 180, 0), 0.3f).OnComplete(() =>
        {
            SliderHolderTransform.localScale = new Vector3(-1, 1, 1);
            transform.localRotation = Quaternion.Euler(new Vector3(-90, 0, 0));
            transform.localScale = new Vector3(-1, 1, 1);
            foreach (Image s in sliderImageArr)
            {
                s.fillAmount = 1;
            }
            print("imagearr len is " + sliderImageArr.Length);
        });
    }*/
}

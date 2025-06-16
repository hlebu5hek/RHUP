using TMPro;
using UnityEngine;

public class LevelSign : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_text;
    [SerializeField] int ind;

    public void SetInd()
    {
        m_text.text += " " + ind;
    }

    public void SetOff()
    {
        gameObject.SetActive(false);
    }
}

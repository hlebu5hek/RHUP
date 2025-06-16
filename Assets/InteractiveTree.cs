using UnityEngine;

public class InteractiveTree : MonoBehaviour
{
    [SerializeField] private GameObject hint;

    private void Start()
    {
        Hide();
    }

    public void Show()
    {
        hint.SetActive(true);
    }

    public void Hide() 
    { 
        hint.SetActive(false); 
    }
}

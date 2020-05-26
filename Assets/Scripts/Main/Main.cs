using Game;
using UnityEngine;

namespace Main
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("Hello World");
            Master.Instance.Create();
        }

        private void Update()
        {
            Master.Instance.Update();
        }
    }
}
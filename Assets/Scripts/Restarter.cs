using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
		public Transform spawn;
        private void OnTriggerEnter2D(Collider2D other)
        {
            GameObject.FindObjectOfType<GlobalScript>().currentWorldState = 0;
			other.transform.position = spawn.position;
        }
    }
}

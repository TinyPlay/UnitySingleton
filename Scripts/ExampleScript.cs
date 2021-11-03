/*
 * Advanced Singleton Pattern
 * This is an advanced singleton pattern realization for Unity.
 * Here you can find interface-based singleton without Mono Classes
 *
 * @developer       TinyPlay
 * @url             https://github.com/TinyPlay/UnitySingleton
 * @autor           Ilya Rastorguev
 */
namespace Singleton
{
    using UnityEngine;
    
    /// <summary>
    /// Just an Example Usage Class
    /// </summary>
    public class ExampleScript : MonoBehaviour
    {
        /// <summary>
        /// On Scene Started
        /// </summary>
        private void Start()
        {
            BaseSingleton.Instance(new BaseConfig()
            {
                debugMode = true
            }).Test();
        }
    }
}
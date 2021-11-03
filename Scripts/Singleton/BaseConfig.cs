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
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    
    /// <summary>
    /// Base Configuration Class
    /// Can be serialized for future state load / save
    /// </summary>
    [System.Serializable]
    public class BaseConfig : ISingletonConfig
    {
        public bool debugMode = true;
    }
}
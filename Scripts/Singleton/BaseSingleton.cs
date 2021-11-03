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
    using UnityEngine.Events;
    
    /// <summary>
    /// Base Singleton Class
    /// </summary>
    public class BaseSingleton : ISingleton
    {
        // Singleton Events
        private UnityEvent OnSingletonInitialized = new UnityEvent();
        
        // Singleton Params
        private static BaseSingleton _instance;
        private ISingletonConfig _config;
        
        /// <summary>
        /// Base Singleton Constructor
        /// </summary>
        /// <param name="config"></param>
        private BaseSingleton(ISingletonConfig config = null)
        {
            if (config != null) _config = config;
            OnSingletonInitialized?.Invoke();
        }
        
        /// <summary>
        /// Get Instance of Class
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static BaseSingleton Instance(ISingletonConfig config = null)
        {
            if (_instance == null)
                _instance = new BaseSingleton(config);
            return _instance;
        }

        /// <summary>
        /// Get Config
        /// </summary>
        /// <returns></returns>
        public virtual ISingletonConfig GetConfig()
        {
            return _config;
        }

        /// <summary>
        /// Set Config
        /// </summary>
        /// <param name="config"></param>
        public virtual ISingleton SetConfig(ISingletonConfig config)
        {
            _config = config;
            return _instance;
        }

        /// <summary>
        /// Just a test Method
        /// </summary>
        public ISingleton Test()
        {
            BaseConfig testConfig = (BaseConfig) _config;
            Debug.Log($"Debug Mode: {testConfig.debugMode}");
            return _instance;
        }
    }
}
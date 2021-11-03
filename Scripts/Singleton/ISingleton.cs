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
    public interface ISingleton
    {
        /// <summary>
        /// Get Config
        /// </summary>
        /// <returns></returns>
        public ISingletonConfig GetConfig();

        /// <summary>
        /// Set Config
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public ISingleton SetConfig(ISingletonConfig config);
    }
}
# Unity Singleton
This package demonstrates how singleton works in Unity without Mono. To use coroutine - you can use the Coroutine Provider from the Utils folder.

## What is it for?
A singleton is a pattern that guarantees that a single instance of some class will exist in a single-threaded application, and provides a global access point to that instance.
For example you can use it for game manager and get acess to this manager from every scene (like a super-global object).

## Initialization
You can initialize your class at the beginning of your first scene in the game and it will be available anywhere else in your game, even after switching to another scene.

**For Example:**

```csharp
using UnityEngine;
    
public class ExampleScript : MonoBehaviour{
    private void Start(){
        // Initialize Singleton
        BaseSingleton.Instance(new BaseConfig(){
          debugMode = true
        }).Test();
    }
}
```

## About Your Singleton
To create your class, you can use an example of what's in the project, or inherit from it for your needs.

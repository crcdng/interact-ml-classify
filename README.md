### Cubing Fast and Slow: Classification Example for InteractML in Unity

[InteractML](http://interactml.com/) is the latest addition to the family of interactive machine learning toolkits originated by Dr. Rebecca Fiebrink. Tools like [Wekinator](http://www.wekinator.org/), [Sound Control](http://soundcontrolsoftware.com/) and [mimic](https://mimicproject.com) are used by artists, educators and researchers alike to record and process various kinds of realtime data in order to generate sounds, visuals and other stuff. 

To learn more about this approach to machine learning you can visit two online courses, [Machine Learning for Musicians and Artists](https://www.kadenze.com/courses/machine-learning-for-musicians-and-artists/info) and [Apply Creative Machine Learning](https://www.futurelearn.com/courses/apply-creative-machine-learning). Highly recommended.

One of the strengths of Wekinator is that it can be connected to almost everything through [OSC](https://en.wikipedia.org/wiki/Open_Sound_Control) the Swiss Army knife of protocols. Two years ago I wrote a small helper app for the [Bitalino revolution Biodata sensor](https://bitalino.com/en/) that connects Bitalino to Wekinator [via a Processing sketch](https://github.com/i3games/p5_bitalino_helper). The system can be used to learn patterns from heart rate or skin conductance measures or send data to interactive applications such as Pure Data, Max or TouchDesigner. 

Now what about indie game developer favourite [Unity3D](https://unity.com/)? Enter [InteractML](https://github.com/Interactml/iml-unity) which is built on a C++ machine learning library called [RapidLib](https://github.com/mzed/ofxRapidLib). InteractML uses the same approach as Wekinator and it works with Unity game objects. 

### Classification  

In this repo I share an example that measures the velocity of a game object and gives an alert if the object is too fast (aren't we are all scared of fast moving cubes), based on previous training. This is an example for classification.

![Classification Graph](/Assets/Docs/InteractMLGraph.png)

InteractML comes with a [Wiki](https://github.com/Interactml/iml-unity/wiki) that explains the individual steps to get the system up and running and how to use it in detail. I am referencing it below. 

#### To set up the system (InteractML Wiki Step 1-5)

1. Install dependencies 
2. Build the classification pipeline. 
3. Check if the data flows into the `Teach the Machine Node` as expected.

#### To connect the system with Game Objects (InteractML Wiki Step 7, optional: 8)

1. Add Game Objects with Scripts to get the result of the classification.
2. Optional: Add Scripts to pipe data into the pipeline.

#### To record training examples (InteractML Wiki Step 5)

Uncheck `Run Model on Play` in the `Machine Learning System` node if it is checked.

<pre>
For each class to be detected:     
    Set the class label (a number) in the `Live Int Data` node     
    Start the game in Unity    
    For each example recoding:   
        Begin the movement     
        Press SPACE to start recording    
        Press SPACE to stop recording     
    Stop the game in Unity    
</pre>

The reason that you want to begin the movement before starting the recording is to avoid the model to pick up common features like an idle object at the beginning.

#### To train the model (InteractML Wiki Step 6)

1. Make sure the game is not running.
2. Klick on `Training`.
3. Wait a bit until it comes back and indicates that the model has been trained.

#### To run the model (InteractML Wiki Step 6)

1. Start the game in Unity.    
2. Press "P" to run the model. You can skip this step if you check `Run Model on Play` in the `Machine Learning System` node. 

### Compatibility

InteractML is still under construction. It is for the curious who want to try out and experiment with interactive machine learning. This repository is based on [InteractML_Core_v0.20.5](https://github.com/Interactml/iml-unity/releases/tag/0.20.5) with **Unity 2020.2** for Mac.

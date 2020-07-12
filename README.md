### Cubing Fast and Slow: Classification Example for InteractML in Unity

[InteractML](http://interactml.com/) ist the spiritual successor of [Wekinator](http://www.wekinator.org/), Rebecca Fiebrink's toolkit for interactive Machine Learning. Wekinator is based on the [WEKA toolkit](https://www.cs.waikato.ac.nz/ml/weka/) and it has been used by artists and researchers to record and process various kinds of realtime data in order to generate sounds, visuals and other stuff. 

There is even an online course "Machine Learning for Musicians and Artists" by the creator of Wekinator herself: https://www.kadenze.com/courses/machine-learning-for-musicians-and-artists/info. Highly recommended.

One of the strengths of Wekinator is that it can be connected to almost everything through OSC. For example, 2 years ago I wrote a helper for the [Bitalino revolution Biodata sensor](https://bitalino.com/en/) that connects [Bitalino to Wekinator via a Processing sketch](https://github.com/i3games/p5_bitalino_helper), among others. The system could learn patterns from heart rate or skin conductance measures and send it to, say, pure data or Max MSP. 

Now surely some people would like to make interesting stuff like that, but in [Unity](https://unity.com/). Enter [InteractML](https://github.com/Interactml/iml-unity). InteractML is built on a C++ library called [RapidLib](https://github.com/mzed/ofxRapidLib).

### Classification  

In this repo I share an example that measures the velocity of a game object and gives an alert if the object is too fast (aren't we are all scared of fast moving cubes), based on previous training. This is an example for classification.

![Classification Graph](/Assets/Docs/InteractMLGraph.png)

InteractML comes with a [wiki](https://github.com/Interactml/iml-unity/wiki) that explains in detail the individual steps to get the system up and running and 

#### To set up the system (InteractML Wiki Step 1-5)
1. Install dependencies 
2. Build the classification pipeline 
3. Check if the data flows into the `Teach the Machine Node` as expected

#### To connect the system with Game Objects (InteractML Wiki Step 7, optional: 8)
1. Add Game Objects with Scripts to get the result of the classification
2. Optional: Add Scripts to pipe data into the pipeline

#### To record training examples (InteractML Wiki Step 5):
<pre>
For each class to be detected:     
    Set the label class (number) in the `Live Int Data` node     
    Start the game in Unity    
    For each example recoding:     
        Press SPACE to record    
        Move around      
        Press SPACE to stop recording     
    Stop the game in Unity    
</pre>

#### To train the model (InteractML Wiki Step 6):
1. If it is running, stop the game in Unity 
2. Klick on `Training`
3. Wait a bit until it comes back and indicates the model has been trained.

#### To run the model (InteractML Wiki Step 6):
1. Start the game in Unity    
2. Press "P" to run the model. You can skip that step if you check `Run Model on Play` in the `Machine Learning System` node. 

### Compatibility
InteractML is in pre-release alpha, under heavy construction and not ready for production at the moment. It is for the curious who want to try out and experiment with interactive machine learning. The developers strongly recommend to use [release 0.20.4](https://github.com/Interactml/iml-unity/releases/tag/0.20.4) with **Unity 2019.2**. For this repo, I have used this setup on a Mac.

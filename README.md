## Introduction ##

My first project in learning Unity development is the creation of a Plants vs. Zombies clone. I’ll be the first to admit this isn’t the most polished game, but everyone starts somewhere. For each of my projects I’m going to try to describe what I was aiming to accomplish out of the project, what I learned from the project, and share as much of the project as I can. I’ve included the entire project for this game on GitHub. If you’re interested, scroll to the last section on final thoughts for the link to GitHub.

## Game Mechanics  ##

The idea is enemies generate on the right side of the screen and travel to the left side of the screen. The objective is to defend them from reaching the other side. You win the level when the timed slider at the top completes. There are three separate levels with varying difficulties that introduce new enemy and defender characters.

#### Defenders ####

Defenders are characters you choose to defend your garden from being invaded by attackers. Each defender has special characteristics to help fend off oncoming attackers and are available at different levels.

_Star Trophy – HP 100 / AP 0 / Star Cost 40_

The star trophy is the economic engine of the game. It generate stars that allow you to purchase other defenders. Each star takes 10 seconds to generate and provides 10 star points. By default you start with 100 stars to spend. It has 100 health to withstand early attacks, and is available in all levels.

_Cactus – HP 100 / AP 10 / Star Cost 10_

The Cactus is the first defender that can attack enemies as they spawn. It fires a zucchini towards oncoming attackers and deals 10 damage. The cactus also has 100 health to withstand early attacks, and is available in all levels.

_Gravestone – HP 200 / AP 0 / Star Cost 30_

The Gravestone is the tank defender. It does not directly deal any damage, but has high health to protect the defenders behind it from lizards. The one weakness it has is that the fox is able to jump over the Gravestone and continue to attack the defenders behind it. The Gravestone becomes available starting in level 2.

_Gnome – HP 100 / AP 25 / Star Cost 20_

The Gnome is the elite attack defender. It throws a powerful axe at oncoming attackers, dealing 25 damage. While a little slower traveling than the zucchini the Cactus throws, it still provides ROI on DPS for its cost compared to the Cactus. The gnome has the same health as a Cactus at 100 and costs twice as much for his increased damage, but is not available until the final level.

#### Attackers ####
Attackers spawn on the screen and try to invade the garden to the left of the screen. The walk towards the garden at different speeds and have their own special characteristics explained below.

_Lizard – HP 50 / AP 20_

The Lizard is the default attacker trying to invade the garden. It moves quickly, and does high damage. However, its attack speed is slow and a Cactus can kill a single Lizard. Lizards can spawn randomly about every five seconds, making them the most common enemy you face as well.

_Fox – HP 50 / AP 5_

The Fox is a sly attacker, which you will face beginning in level 2. It moves slow towards the garden, but has the additional ability to be able to jump over protective Gravestones and attack what is behind them. While its low damage makes it more manageable to deal with, don’t lose sight of these attackers because they can become difficult to handle.

## Game Critique ##

I hope you got a chance to play the game and understand the mechanics. Overall, I would love to hear your feedback. Feel free to reach out to me on Twitter @mjgillis and let me know what you think. Ultimately, I’m here to learn and improve. I think having your work reviewed and receiving feedback is paramount to growth. So now that I have that out of the way let me walk through the areas I think can be improved: explaining game mechanics in-game, animations, overall game polish.

Since, I’m in the early days of my game development journey, I’m going to leave these opportunities on the table and move on to learning the next game and picking up new mechanics. However, I think pointing out the areas of opportunity will help shape my thinking and work to not make them again in future games.

#### Explaining Game Mechanics ####

I think the biggest usability issue with the game is how poorly the in-game mechanics are explained to the user. Once you hit play you are thrown into a scene where Lizards spawn and you are not given any instruction. Therefore, the only way to learn is by losing and slowing understanding how not to lose. Which, doesn’t generally bring about the most satisfying gameplay.

In terms of specific opportunities to improve, I think having some notifier or intro animation that explains that the objective of the game is to stop the spawning attackers from reaching the garden on the left side of the screen. Maybe a short video of in-game action showing people trying to stop attackers would suffice. I think there are a lot of possibilities for how that could work, which would be interesting to hear from others what they would do. However, I think we would all agree that there is a missing component of explaining even this relatively simple game.

Additionally, there are missing elements of the game that show current state of the attackers and defenders, making it difficult to make decisions and understand elements of the game. For instance, you cannot tell the amount of health each defender has throughout the game. It would be super helpful making decisions where to place defenders if you knew how much health each had left actively during the game, either through a slider or a numeric value displayed on screen. This is similar for attackers and damage being done between attackers and defenders. It would be very helpful to more visually see these components of the game.

I’m sure there are other in-game mechanic improvements that can be made, but those are the ones that immediately came to mind.

#### Animations #### 

This is my first experience using animations in Unity, so my expectations were fairly low on my skillset. I think I delivered on those low expectations, and will talk more about what I was able to accomplish in the lessons learned. However, there are areas that can be improved to make the gameplay more smooth. Most obvious is the Cactus animation has a weird flash that I wasn’t able to debug. I also think my animation transitions are overly rough. I’m not sure how to improve the timing of those, but am hoping to learn more in future games to make it look more realistic and not so obvious.

#### Game Polish ####
The final area I think could be improved is overall game polish. I was very lucky to have great art and music from the folks over at Glitch, but I don’t think I was able to use it with the polish quality I hope to have in the future. I think my priority as I start learning is to understand core mechanics like I’ll discuss in the Lessons Learned section, and as I’m able to add more skills I’ll focus on the polish and user experience within the game.

## Lessons Learned ##

Here is where I reflect back and think about the key learnings I had when building this game and the things I’ll be able to take with me in building my next game. The key things I learned while building this game were: world units and aspect ratios, playerprefs, animation, and scripting.

#### World Units ####

One of the initial things I learned when building this game was creating a scene that related to world units and was designed for a specific aspect ratio. While having similar experience in web design, it was helpful to learn how this works when designing a game in Unity. I think this is a simple concept, but one that is easy to forget and can cause a real headache if not done properly. Setting the attacker lanes and spawning attackers all became much easier with a set world unit that fit within a specific aspect ratio.

#### PlayerPrefs ####

Using PlayerPrefs to set global, persistent variables was very valuable to learn. However, the true lesson was the creation of a PlayerPrefs manager that handled reading and writing to the PlayerPrefs. This ensured that I was handling all changes with one scripting object and not doing those read/writes from gameplay scripts. This seems like another small and probably obvious lesson for the more experienced, but it this scalability thinking that will continue to help me as I design games in the future.

#### Animation ####

This was a critical lesson for me in this game. Having no experience in Unity animation I was able to pick up the basics on how to do sprite animation as well as skeletal animation. Included in this was being able to create scriptable transitions, scriptable event markers, and different animation states. The Unity UI was a bit confusing at first, and I still am not a huge fan that I cannot work on animation using a prefab, but require the object to be within the scene. However, starting from a blank slate, I feel like I took a lot away from this project in the area of animation and am excited about building upon this foundation.

#### Scripting ####

This is a generic bucket of scripting lessons. Here I was able to learn a lot of syntax and concepts for achieving results using scripts on objects. However, I think the biggest takeaway was around scripting design as it related to gameplay interaction. Doing things like creating defender and attacker classes that managed the majority of the scripting behaviors for defenders and attackers.

While the solution seems obvious when it was presented, looking back on how I would have designed the game would have been way less efficient. I would have created scripts that managed behavior for each of the characters, instead of factoring all the common behaviors together and only using character level scripts when absolutely necessary. I’m now trying to think about factoring in game behavior in the simplest way possible when thinking about scripting game design. I think I’m going to be far from perfect here and I look forward to learning more and experiencing more as I build more games.

## Final Thoughts ##

For those of you who are wondering, the training class I’m using is the Unity GameDev.tv class on Udemy. You can find the specific class here, but also worth checking out GameDev.tv. I’m a huge fan of the course because it moves at just the right pace for me and I love the challenge structure to teach you enough to try and figure something out on your own, then if you get stuck you can watch them show you how they would do it.

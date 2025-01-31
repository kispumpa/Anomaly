# Anomaly
This is a Unity based game, when you have to find differences between rooms. <br/>
**status**: *under development* <br/>

## Background story
In university, i applied for a course called: The basics of 3D game development in Unity. By this course, i had to make a game in Unity based on what I learned in lessons.
The idea comes from a popular game from the end of 2023: The Exit 8. I made this game under 3 month, and succeeded this course. 
My teacher said that there's a game development competition in my uni, so I submitted this game. 
Because I won first place, I decided to further develop it to make it more unique and maybe release it later.

## Gameplay
### What is the goal?
It can be a difference between the first and the current room. If you guess it right 6 times, whether it's correct or there's an anomaly, you win the game. 
If you guess it wrong more than 3 times, you failed.

### Handle
At first, you have to memorize all the little things you can see in the main room. At the beginning of the corridor, there's a handle with a colored panel
- at first see, just leave it untouched
- from the second time
  - if you **found** any differences between the **first and the current room**, pull the handle to make the **panel red**
  - if you **didn't find** any differences between the **first and the current room**, pull the handle to make the **panel green**

### Differences
It can be little, it can be huge... One thing is for sure, if something is not like it was in the first room, you found a dif. 
After you used the handle in the perfect way, go through the corridor and start over. <br/>

### Status panel
Above the computer desk, there is a panel, that shows your points. The white panel shows how many rooms you guessed right with the handle. 
At the red one, you can see your mistakes. If you guess wrong, the white panel restarts from 0, so I recommend you to switch the handle perfectly.
As i mentioned in [What is the goal](#what-is-the-goal), you win, if the white table shows 6/6 or you lose, if the red panel shows 3/3.




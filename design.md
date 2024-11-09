### Overview: Snoulder Rush

## Basic (Alpha) Gameplay
Snowlder Rush is a top-down shooter video game. The basic gameplay consists of the player attempting to prevent balls from rolling down a ramp by shooting their own balls up the ramp, which on collision with another ball, will destroy both balls. However, balls which miss will instead start rolling back down the ramp, and must themselves be destroyed. The player is situated at the bottom of the ramp, and can move left or right in order to position their shots correctly, but cannot rotate.

## Theming (Visuals and Story)
The game's basic premise is that the player is a cannon operator, tasked with defending a village from a Yeti/Yetis who are attempting to destroy it by rolling snowballs down the side of a mountain towards the village.

## Checklist items
- Player Movement: Player should be situated at the bottom of the screen, should be able to move left or right to either edge of the screen. There shoud be noticable acceleration/decceleration to the player's movement, to make it more difficult to precisely place shots.

- Snowballs: Snowballs should be either spawned at the top of the screen by a animation of a Yeti pushing a snowball over the edge of a cliff, or a player shooting a snowball. Snowballs should act as physics objects, and the level should be arranged such that the snowballs the player shoots will roll back down the cliff towards them.

- Player Shooting: Players should be able to shoot a snowballs at a fairly quick pace, as the mechanic of snowballs rolling back should hopefully deter spam. Snowballs should be fired in a straight line, unaffected by the movement of the player as they shoot them.

- Failure State: The player should have a limited number of lives. Whenever a snowball rolls past the player, they should lose a life, and they fail upon loss of all lives.

- Success State: Unsure of exactly what'd be the best sucess state, considering either surviving for a sufficient period of time, or hitting a yeti directly with a snowball.

## Visual Mock-Up:
!()[https://github.com/lukaro707/IntMultProject/blob/main/mockup.png?raw=true]

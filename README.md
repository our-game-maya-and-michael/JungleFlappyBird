# Jungle Flappy Bird
In this repository I remade the game of FlappyBird with my little spin to it:
Try to navegate in the jungle by being a big boy of a bird and see the dangers of flaying to close to tree from first hand experiance and try to escape the endless jungle ! [Try the game on itch.io](https://mayamichael.itch.io/jungleflappybird)

## How does it work ?
* For the [background](https://github.com/our-game-maya-and-michael/JungleFlappyBird/tree/main/Assets/Background) I used the asset store of unity and downloaded a running background that someone made and posted it (Link to it in the Credits).
* For the [bird](https://github.com/our-game-maya-and-michael/JungleFlappyBird/tree/main/Assets/Grey%20Bird) I also took an asset from the unity store and implemented it in the game by using the prefab.
* To that prefab I added a [script](https://github.com/our-game-maya-and-michael/JungleFlappyBird/blob/main/Assets/Scripts/FlappLikeABird.cs) that makes it flapp up and down, while [checking](https://github.com/our-game-maya-and-michael/JungleFlappyBird/blob/main/Assets/Scripts/BirdCollision.cs) if the bird hit any tree, it will destory the bird object.
* Trees [check](https://github.com/our-game-maya-and-michael/JungleFlappyBird/blob/main/Assets/Scripts/TreeScore.cs) if the bird came a cross an edge collider to see if the player needs to get points for crossing the trees.
* Update the [score manager](https://github.com/our-game-maya-and-michael/JungleFlappyBird/blob/main/Assets/Scripts/ScoreManager.cs) that the score on the game map needs to be updated because the bird flew past the trees.
* Trees [spawner](https://github.com/our-game-maya-and-michael/JungleFlappyBird/blob/main/Assets/Scripts/TreeSpawner.cs) sits on the Main Camera and sets them 20f after the camera (its out of sight so that the player doesnt see the trees just spawn so he could have the feeling of walking in a path)
## Credits
Graphics:
* [Bird character](https://assetstore.unity.com/packages/2d/characters/2d-cartoon-birds-pack-149167)
* [Background](https://assetstore.unity.com/packages/2d/environments/free-2d-cartoon-parallax-background-205812)
* [Trees](https://assetstore.unity.com/packages/2d/textures-materials/nature/sunnyland-expansion-pack-trees-237697)

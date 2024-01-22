# Jungle Flappy Bird
In this repository I remade the game of FlappyBird with my little spin to it:
Try to navegate in the jungle by being a big boy of a bird and see the dangers of flaying to close to tree from first hand experiance and try to escape the endless jungle ! [Try the game on itch.io](https://mayamichael.itch.io/jungleflappybird)

## How does it work ?
* For the background I used the asset store of unity and downloaded a running background that someone made and posted it(Link to it in the Credits). [The folder itself](https://github.com/our-game-maya-and-michael/JungleFlappyBird/tree/main/Assets/Background)
* For the bird I also took an asset from the unity store and implemented it in the game by using the prefab [The bird folder](https://github.com/our-game-maya-and-michael/JungleFlappyBird/tree/main/Assets/Grey%20Bird) and added a script to it that makes it flapp up and down [The script](https://github.com/our-game-maya-and-michael/JungleFlappyBird/blob/main/Assets/Scripts/FlappLikeABird.cs) while checking that if the bird hit any of the trees it will destory the bird object, also the trees check if the bird came a cross an edge collider to see if the player needs to get points for it and update the score manager that the score on the game map needs to be updated, the trees are spawned using a tree spawner that sits on the Main Camera and sets them 20f after the camera (its out of sight so that the player doesnt see the trees just spawn so he could have the feeling of walking in a path) [Scripts](https://github.com/our-game-maya-and-michael/JungleFlappyBird/tree/main/Assets/Scripts)
## Credits
Graphics:
* [Bird character](https://assetstore.unity.com/packages/2d/characters/2d-cartoon-birds-pack-149167)
* [Background](https://assetstore.unity.com/packages/2d/environments/free-2d-cartoon-parallax-background-205812)
* [Trees](https://assetstore.unity.com/packages/2d/textures-materials/nature/sunnyland-expansion-pack-trees-237697)

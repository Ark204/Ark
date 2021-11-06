# Unity Essay

## TileMap
一种2D网格地图（gameobject） 
使用步骤：
1. 在**Windows菜单->2D->Tile Palette**打开TileMap的编辑器，将素材导入，并进行切割
2. 将切割后的素材“刷”如游戏场景对应网格中
**注意：TileMap对象实例为所有”刷“入素材网格的总体**
刚体添加：
不同于其他gameobject，TileMap需要添加的对应刚体为TileMap Collider 2D
添加后刚体附加到所有“刷”入素材的网格上
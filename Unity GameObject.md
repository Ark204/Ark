# Unity GameObject

## GameObject
文件目录查找游戏场景中的GameObject：
`GameObject.Find("grandparent/parent/child");`
获取到child对象

## TileMap
2D网格地图
使用步骤：
1. 在**Windows菜单->2D->Tile Palette**打开TileMap的编辑器，将素材导入，并进行切割
2. 将切割后的素材“刷”如游戏场景对应网格中
**注意：TileMap对象实例为所有”刷“入素材网格的总体**
刚体添加：
不同于其他gameobject，TileMap需要添加的对应刚体为TileMap Collider 2D
添加后刚体附加到所有“刷”入素材的网格上

## Animation
动画
使用步骤：
1. windows->Animation->Animation
2. 新建动画，并将动画素材导入
3. 调整动画播放速度
Animation Event
动画事件，当动画播放到**某一帧**或**播放结束**或**即将播放**的时候触发该事件，并可以调用事件回调函数，可以更好地平衡动画播放与函数调用
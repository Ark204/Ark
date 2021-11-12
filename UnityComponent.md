# Unity Component

## 0.Component通用
| 常用成员 | 作用 |
| :--: | :--: |
| enable | 设置组件是否使用 |

| 常用成员方法 | 作用 |
| :--: | :--: |
| Invoke | 调用某个函数，可设置延迟时间 |
## 1. Transform
变换组件，用来描述物体在游戏世界中的位置（location）、旋转（rotation）、缩放（scale）
每种变换对应一个三维向量Vector

缩放的数值表示缩放的大小，缩放的正负表示朝向

## 2. Camera
摄像机组件，用来将视锥中的游戏物体显示到屏幕上
Cinemachine中的Camera2D
**注意：添加进场景后将替换原有的摄像机**
可以更加方便地使用摄像机，控制镜头的跟踪、移动区域、最大移动范围、设置跟踪点
Cinemachine Confiner
控制镜头最大移动范围
需要添加一个Polygon Collider2D组件确定范围，一旦与Polygon Collider2D发生碰撞，镜头就会停止碰撞方向的运动

## 3. Collider
碰撞体组件，用于收集发送碰撞消息、模拟物理效果
| 常用成员 | 作用 |
| :--: | :--: |
| Material | 物理材质，设置碰撞器的摩擦系数等 |
| is Trigger | 勾选时作为触发器，即收集发送碰撞消息，但不模拟物理碰撞效果 |
常用碰撞
1. 与LayerMask（游戏图层）的碰撞
2. 与Tag（标记）的碰撞
3. 与Physics2D.OverlapCircle(point)的碰撞
[注]: Physics2D.OverlapCircle(point)是一个物理系统函数，返回值是bool，用来判断给定point上方一个圆形区域是否存在碰撞器

Polygon Collider2D多边形2D碰撞器，可与Cinemachine Confiner配合控制镜头最大移动范围

## 4. Renderer
渲染组件，用于控制物体的颜色、材质，以及渲染图层等

## 5. Animator
动画控制组件，用于控制游戏动画的播放、切换等
Animator Controller：动画控制器，创建添加至Animator组件上，即可实现动画控制
Animation：各种录制好的动画
Animator Parameter：动画切换参数，根据参数控制动画的切换
编辑界面：windows->Animation->Animator
可以编辑多个动画的切换，并且可以观察到当前播放的帧

## 6.Rigidbody2D
刚体组件，用于赋予gameobject虚拟物理属性，如：重力，速度，摩擦力等
**注意：由于模拟效果逼真，在2D游戏开发中会出现当两个碰撞体贴着发生相对运动时，会产生的摩擦力并使其中添加了Rigidbody2D的gameobject绕Z轴发生旋转，若需要消除这种影响，可在Rigidbody2D组件的Constraints成员处锁定Z轴，就可有效避免发生旋转**
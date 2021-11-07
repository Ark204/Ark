# Unity Component

## 1. Transform
变换组件，用来描述物体在游戏世界中的位置（location）、旋转（rotation）、缩放（scale）
每种变换对应一个三维向量Vector

缩放的数值表示缩放的大小，缩放的正负表示朝向

## 2. Camera
摄像机组件，用来将视锥中的游戏物体显示到屏幕上

## 3. Collider
碰撞体组件，用于收集发送碰撞消息、模拟物理效果

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
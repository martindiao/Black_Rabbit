# Black_Rabbit  Manual

本文档是Black_Rabbit 框架的说明书

**项目仍然在开发中，本文档随时会变化**

如果有好的建议或者bug，请在issues反映

```
//creat in 2019.7.12
//last modified 2019.7.12
```

- **设计思路**

本框架思路是，先使用现成的免费插件，最快速实现需要的功能，然后再逐步将插件替换或修改，逐渐转换为自主的代码。

- **开发版本：  2019.1.3f1  请使用这个或更新的版本**

- **使用的插件**

对话插件：fungus   [链接](http://fungusgames.com/)  （**已经包含在项目中**）

摄像机插件：cinemachine  （**unity 官方插件，已经在package配置文件中标明，若unity未自动添加，请手动使用包管理器添加**）

其他素材：	 EverydayMotionPackFree    动作/模型

​						Skybox Cubemap Extended	天空盒



- **使用方法**

**由于目前还未正式release，目前只能以文件夹方式打开**

将项目clone ，使用unity打开，在此基础上建立新的项目



### 模块说明

---

- **namespace**

本项目全部代码均在

```c#
namespace Black_Rabbit{}
```

如果在外部调用类，请包含这个命名空间

```c#
using Black_Rabbit;
```



- **Trigger**

触发器是最基本的组件之一。一方面，触发器可以显示可以互动的物体，显示提示信息，不同触发器有不同功能

**1、trigger**

或者使用制作好的prefab

可以在**add component**处添加，路径为   **Black-Rabit/Trigger/BasicTrigger**

```c#
[AddComponentMenu("Black-Rabit/Trigger/BasicTrigger")]
```

**prefabs样式**

![](/pic/trigger.PNG)

蓝色部分是触发器范围，紫色标注的是提示显示的相对位置

基础触发器不会相应任何事件



**2、trigger_fungus**

添加路径	**Black-Rabit/Trigger/Trigger_Fungus**

```c#
 [AddComponentMenu("Black-Rabit/Trigger/Trigger_Fungus")]
```

结构和基础触发器一致

可以响应按键**E**，触发一段对话

对话内容可以在fungus窗口中修改（具体使用请参阅fungus）

（待修改）
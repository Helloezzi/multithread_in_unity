
### How to use Multi Threading in Unity.

#### Requirements
- install git
- install Unity 2019.2.0f1
- install VisualStudio 2017 community

##### Solution
  
1. Object Pool 에 1~100 까지의 숫자를 Push 함  

2. Main Code 에서 Work class의 instance를 만들어서 Task로 2개의 Thread를 생성하여 Object Pool 에서 하나씩 Pop 하여 콘솔에 Print 함  

##### Question
  
- 항상 첫 번째 Tick 에서 Number 1 이 아닌 2 부터 Console에 찍히는 점.  

- Object Pool 을 generic 하게 만드려고 할 때 Dispose 의 구현 여부  


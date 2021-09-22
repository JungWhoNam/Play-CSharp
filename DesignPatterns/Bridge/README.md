# 이유
기능과 구현을 분리해서 독립적으로 변형 및 확장이 가능하도록 만듬

## 1. 기능 관련 클래스 및 인터페이스

### Abstraction: 기능 계층의 최상위 클래스 (추상 인터페이스)
IImplementation을 component으로 가져서 bridge으로 사용

### ExtendedAbstraction: 기능 계층에서 새로운 부분을 확장한 클래스 
예) 알파벳에 따른 모스 부호 함수 호출 - G() => Dash(); Dash(); Dot(); Space();


## 2. 구현 관련 클래스 및 인터페이스

### IImplementation: Abstraction의 기능을 구현하기 위한 인터페이스 정의
예) 모스 부호를 표현하기 위한 기본 함수 정의 - dash, dot, space

### 실제 기능을 구현하는 클래스 
예) ConcreteImplementationDefault: *, -, " " 사용해서 모스 부호를 표현
예) ConcreteImplementationSound: Bip, Bbi~, " " 사용해서 모스 부호를 표현
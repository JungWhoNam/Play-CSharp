# 주어진 상황
SearchStartegy.cs 현 회사에서 사용되고 있는 서치 기능
FindAlgorithm.cs B사에서 사용되고 있는 서치 기능
목적: 현 회사에서 B사의 서치 기능도 추가로 서포트
문제점: 두 회사의 코드 구성이 다르기에 B사의 기능을 쓰기 위해서는 현재 코드를 고쳐야함.

# 디자인 패턴 존재의 이유
adapter 패턴을 통해 기존 방식을 바꾸지 않고 B사의 서치 기능 서포트
볼티지가 다른 전원 프러그를 변환해주는 어답터

# 리소스
https://www.youtube.com/watch?v=lJES5TQTTWE&ab_channel=%EC%96%84%ED%8C%8D%ED%95%9C%EC%BD%94%EB%94%A9%EC%82%AC%EC%A0%84
https://nowonbun.tistory.com/436
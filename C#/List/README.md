List

선형리스트 
- 데이터를 순서대로 나열한 자료구조이다.
- 만드는 방법은 배열로 만드는 방법과 포인터를 이용해 만드는 방법이있다.

배열로 선형리스트 만들때 단점
단점
- 배열의 크기를 미리 알아야함
- 데이터를 중간에 삽입, 삭제 시 이후 요소들을 옮겨야하는 문제로인해 효율성 감소.

포인터로 연결리스트 만들기 장단점
장점
- 배열의 단점인 크기를 미리 알필요 없음
- 노드의 삽입, 삭제 시 요소들의 이동이 없다.

단점
- 삽입, 삭제 시 노드용 객체를 위한 메모리 영역을 만들고 해제하는데 들어가는 비용이 크다.

해서 다시 배열로 돌아와서 데이터의 개수를 미리 알수 있다면 커서로 연결리스트를 만드는 방법이 있다.


커서로 연결 리스트

커서 : 다음 노드가 들어있는 인덱스 요소

일반 커서 연결 리스트를 사용하면 삭제된 RemoveFront, RemoveRear등을 통해서 배열의 빈 요소들이 생긴다. 
그래서 프리리스트를 사용하여 배열의 빈 요소들을 효율적으로 사용할 수 있도록 한다.

프리리스트는 삭제된 배열의 요소인 인덱스들을 가지고 있어서 리스트에 추가시 프리리스트의 요소들로 추가할 수 있도록 해줌으로써
배열의 빈 공간을 효율적으로 사용할 수 있도록 한다.


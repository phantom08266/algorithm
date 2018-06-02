# **First Week**
---
### - 기본 알고리즘

- 선택적/순서적 구조</br>
```python
max = 0
if b > max:
  max = b
if c > max:
  max= = c
```
> 다음과 같이 순차적으로 실행되는 구조를 `순차적(concatenation)`구조 라고한다.</br>
> 또한 `IF문`을 `선택(selection)` 구조라고 한다.</br>

#### - 식과 식의 평가</br>
엄밀한 정의는 아니지만 식(expression)은 다음의 요소를 통틀어 말한다.

```
변수
상수
변수나 상수를 연산자로 결합한 것
```
> 식의 평가
> 원칙적으로 모든 수식에는 값이 있다(void형을 제외한). 그 값은 프로그램을 싫행할 때
> 확인할 수 있으며 식의 값을 알아내는 것을 `평가(evaluation)`라고 한다.

#### - 조건 판단과 분기</br>
```python
# Ex)
n = int(input("정수를 입력하세요 :"))
if n > 0: print("이 수는 양수입니다,")
elif n < 0: print("이 수는 음수 입니다.")
else: print("이 수는 0 입니다")
```

**삼항 연산자**
```python
# a < b 값이 참(True)일 경우 a, 거짓(False)일경우 b
min = a < b ? a:b
```

**순서도**</br>

![flow_chart](https://user-images.githubusercontent.com/25660275/40874871-65892680-66b0-11e8-80c8-5040e61ad320.png)

#### - 반복</br>
```python
# Ex)
sum = 0
print("1부터 n까지의 합")

n = int(input("n의 값 :"))
i = 1
while i<= n:
  sum += i
  i++
"""
for문을 사용하게 될 경우
for i in range(n):
  sum += i
"""
print("1부터 %d까지의 합은 %d입니다" % n, sum)
```

> 어떤 조건이 성립하는 동안 처리를 반복하여 실행하는 것을 `반복(repetition)`구조라 하며 일반적으로 `루프(loop)`라고 부릅니다.</br>

> while/for문은 모두 `사전 판단 반복 구조`이며. 하나의 변수를 사용하는 경우에는
> while문보다 for문을 사용하는 것이 좋다. </br>

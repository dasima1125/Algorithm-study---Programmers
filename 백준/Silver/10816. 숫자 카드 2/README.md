# [Silver IV] 숫자 카드 2 - 10816 

[문제 링크](https://www.acmicpc.net/problem/10816) 

### 성능 요약

메모리: 101004 KB, 시간: 768 ms

### 분류

이분 탐색, 자료 구조, 해시를 사용한 집합과 맵, 정렬

### 제출 일자

2024년 11월 11일 22:25:03

### 문제 설명

<p>숫자 카드는 정수 하나가 적혀져 있는 카드이다. 상근이는 숫자 카드 N개를 가지고 있다. 정수 M개가 주어졌을 때, 이 수가 적혀있는 숫자 카드를 상근이가 몇 개 가지고 있는지 구하는 프로그램을 작성하시오.</p>

### 입력 

 <p>첫째 줄에 상근이가 가지고 있는 숫자 카드의 개수 N(1 ≤ N ≤ 500,000)이 주어진다. 둘째 줄에는 숫자 카드에 적혀있는 정수가 주어진다. 숫자 카드에 적혀있는 수는 -10,000,000보다 크거나 같고, 10,000,000보다 작거나 같다.</p>

<p>셋째 줄에는 M(1 ≤ M ≤ 500,000)이 주어진다. 넷째 줄에는 상근이가 몇 개 가지고 있는 숫자 카드인지 구해야 할 M개의 정수가 주어지며, 이 수는 공백으로 구분되어져 있다. 이 수도 -10,000,000보다 크거나 같고, 10,000,000보다 작거나 같다.</p>

### 출력 

 <p>첫째 줄에 입력으로 주어진 M개의 수에 대해서, 각 수가 적힌 숫자 카드를 상근이가 몇 개 가지고 있는지를 공백으로 구분해 출력한다.</p>
 
 ### 문제점
   - 이해가 안간다 분명 m값을 일종의 맵구조로 만들어서 횟수를 0으로 만들고 n배열을 돌려서 딕셔너리에 있을시 그 해당되는 키값을 가진 딕셔너리 값을 1 추가해줬다
      - 근데 .. 틀렸다 왠진모르겠다 테스트케이스는 분명맞고 원인을 모르겠네 ... 연구좀 해봐야지 


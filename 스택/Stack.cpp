/*스택은 쉽게 말해서 '쌓아 올려진 상자더미' 나 '쟁반 위에 쌍힝 접시' 가 아닐까 생각합니다.
즉, 스택은 한쪽은 막히고 한쪽은 뚫려있는 초코볼 통에 비유할 수 있습니다. 그리고 이렇듯 한쪽만
뚫리다 보니 다음과 같은 특성을 지니게 된다.
"먼저 들어간 것이 나중에 나온다!"
즉, 스택은 나중에 들어간 것이 먼저 나오는 구조이다 보니 '후입선출 방식의 자료구조' 라고 불리고
영어로 LIFO(Last-In, First-Out)구조의 자료구조 라고도 불린다.
*/

#include <stdio.h>
#include <stdlib.h>
#include "ArrayBaseStack.h"

void StackInit(Stack *pstack) //스택의 초기화
{
	pstack->topIndex = -1; // topIndex 의 -1 은 스택이 빈 상태를 의미한다.
}
int SIsEmpty(Stack *pstack) //스택이 비었는지 확인
{
	if (pstack->topIndex == -1) //스택이 비어있다면
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

void SPush(Stack *pstack, Data data) //스택의 push 연산
{
	pstack->topIndex += 1; //데이터 추가를 위한 인덱스 추가
	pstack->stackArr[pstack->topIndex] = data; //추가 전 인덱스의 데이터를 저장
}
Data SPop(Stack *pstack) //스택의 pop 연산
{
	int index = 0;
	if (SIsEmpty(pstack)) //스택이 비었다면 더이상 삭제할 데이터가 없다.
	{
		printf("Stack Memory Error!"); // 메모리 Error 표현
		exit(-1);
	}

	index = pstack->topIndex; //삭제할 데이터가 저장된 인덱스 값 저장
	pstack->topIndex -= 1; //pop 연산의 결과로 topIndex값 1 감소
	return pstack->stackArr[index]; //삭제되는 데이터값 반환
}
Data SPeek(Stack *pstack) //스택의 peek 연산
{
	if (SIsEmpty(pstack))
	{
		printf("Stack Memory Error!");
		exit(-1);
	}
	return pstack->stackArr[pstack->topIndex]; //맨 위에 저장된 현재의 데이터를 반환
}
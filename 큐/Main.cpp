#include "Queue.h"
#include <stdio.h>

int main(void)
{
	int i;
	Queue queue;

	InitQueue(&queue, 10);//큐 초기화
	for (i = 1; i <= 5; i++)//1~5까지 큐에 보관
	{
		Enqueue(&queue, i);
	}
	while (!IsEmpty(&queue))//큐가 비어있지 않다면 반복
	{
		printf("%d ", Dequeue(&queue));//큐에서 꺼내온 값 출력
	}
	printf("\n");
	return 0;
}
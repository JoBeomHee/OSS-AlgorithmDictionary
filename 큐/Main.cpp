#include "Queue.h"
#include <stdio.h>

int main(void)
{
	int i;
	Queue queue;

	InitQueue(&queue, 10);//ť �ʱ�ȭ
	for (i = 1; i <= 5; i++)//1~5���� ť�� ����
	{
		Enqueue(&queue, i);
	}
	while (!IsEmpty(&queue))//ť�� ������� �ʴٸ� �ݺ�
	{
		printf("%d ", Dequeue(&queue));//ť���� ������ �� ���
	}
	printf("\n");
	return 0;
}
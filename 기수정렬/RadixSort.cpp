#include <stdio.h> 
#include <stdlib.h>
#define RADIX 10    // ������ �ڷ���� Ű���� 10�����̹Ƿ� RADIX�� 10���� ����.
#define DIGIT 2     // ������ �ڷ���� Ű���� �� �ڸ��̹Ƿ� DIGIT�� 2�� ����.


//////ť ����/////  // ��Ŷ�� ť�� �����Ͽ� ����ϹǷ� ť�� ���� ������ ����.

typedef int element;

typedef struct QNode
{
	element data;
	struct QNode *link;
}QNode;

typedef struct
{
	QNode *front, *rear;
}LQueueType;

LQueueType *createLinkedQueue()     // ����ť�� �����ϴ� ����
{
	LQueueType *LQ;
	LQ = (LQueueType *)malloc(sizeof(LQueueType));
	LQ->front = NULL;
	LQ->rear = NULL;
	return LQ;
}

int isEmpty(LQueueType *LQ)         // ť�� �������� Ȯ���ϴ� ����
{ 
	if (LQ->front == NULL)return 1;
	else return 0;
}

void enQueue(LQueueType *LQ, element item)   // ť�� rear�� ���Ҹ� �����ϴ� ����
{
	QNode *newNode = (QNode *)malloc(sizeof(QNode));
	newNode->data = item;
	newNode->link = NULL;
	if (LQ->front == NULL) {
		LQ->front = newNode;
		LQ->rear = newNode;
	}
	else {
		LQ->rear->link = newNode;
		LQ->rear = newNode;
	}
}

element deQueue(LQueueType *LQ) {            // ť�� front���� ���Ҹ� �����ϰ� ��ȯ�ϴ� ����

	QNode *old = LQ->front;
	element item;
	if (isEmpty(LQ)) return 0;

	else {
		item = old->data;
		LQ->front = LQ->front->link;
		if (LQ->front == NULL)
			LQ->rear = NULL;
		free(old);
		return item;
	}
}

void radixSort(int list[], int n)   // �迭 list�� �ִ� n�� ���ҿ� ���ؼ� ��� ������ �����ϴ� ������ ����.
{
	int i, bucket, d, factor = 1;
	LQueueType *Q[RADIX];           // ������ �ڷ��� ���, �� RADIX�� ���� 10���� ��Ŷ�� ť�� ����.
	for (bucket = 0; bucket < RADIX; bucket++)
		Q[bucket] = createLinkedQueue();

	for (d = 0; d < DIGIT; d++) {   // Ű���� �ڸ�����ŭ, �� �� �� ��� ������ �ݺ� ����.
		for (i = 0; i < n; i++)     // Ű���� 1�� �ڸ��� ���� ��Ŷ�� ã�� ���Ҹ� ����. (enQueue)
									// Ű���� 10�� �ڸ��� ���� ��Ŷ�� ã�� ���Ҹ� ����. (enQueue)
			enQueue(Q[(list[i] / factor) % 10], list[i]);
		for (bucket = 0, i = 0; bucket < RADIX; bucket++)  // ��Ŷ 0 ���� Ŀ�� 9 ���� ����� ���Ҹ� ������� ������ (deQueue) �迭 list�� ����.
			while (!isEmpty(Q[bucket])) list[i++] = deQueue(Q[bucket]);
		printf("\n\n%d �ܰ�: \n\t", d + 1);                // 1�� �ڸ��� ���Ͽ� ��� ������ ���� ���� ���¸� ���.
														   // 10�� �ڸ��� ���Ͽ� ��� ������ ���� ���� ���¸� ���.
		for (i = 0; i < n; i++) printf("%d  ", list[i]);   

		factor = factor * 10;                              // 10�� �ڸ��� ���� ��� ������ �ݺ��ϱ� ���ؼ� factor�� 10���� �����ϰ� 74 ~83 �� �ݺ�
		}
}

void main() {

	int list[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };
	int size = 8;

	printf("**������� (Radix Sort)\n");                // ������Ŀ� ���Ͽ�
	printf("�й����� ���Ĺ������ ������ ������ Ű���� �ش��ϴ� ��Ŷ(Buket)�� ���Ҹ�\n�й��Ͽ��ٰ� ��Ŷ�� ������� ���Ҹ� ������ ����� �ݺ� \n\n");
	printf("- ������ Ű�� ǥ���ϴ� ���� ��� (Radix) ��ŭ�� ��Ŷ�� �ʿ� \n\n");
	printf("- Ű���� �ڸ�����ŭ ��� ������ �ݺ� \n\n");
	printf("- ���� �ڸ�, �����ڸ�, ���� �ڸ��� ���� ������ ������� ���� \n\n\n");
	printf("<<<<<<<������� ����>>>>>>>");
	radixSort(list, size);                               // ������� �Լ�ȣ��

	getchar();

}
#include <stdio.h> 
#include <stdlib.h>
#define RADIX 10    // 정렬할 자료들의 키값이 10진수이므로 RADIX를 10으로 정의.
#define DIGIT 2     // 정렬할 자료들의 키값이 두 자리이므로 DIGIT를 2로 정의.


//////큐 연산/////  // 버킷을 큐로 구성하여 사용하므로 큐에 대한 연산을 정의.

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

LQueueType *createLinkedQueue()     // 공백큐를 생성하는 연산
{
	LQueueType *LQ;
	LQ = (LQueueType *)malloc(sizeof(LQueueType));
	LQ->front = NULL;
	LQ->rear = NULL;
	return LQ;
}

int isEmpty(LQueueType *LQ)         // 큐가 공백인지 확인하는 연산
{ 
	if (LQ->front == NULL)return 1;
	else return 0;
}

void enQueue(LQueueType *LQ, element item)   // 큐의 rear에 원소를 삽입하는 연산
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

element deQueue(LQueueType *LQ) {            // 큐의 front에서 원소를 삭제하고 반환하는 연산

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

void radixSort(int list[], int n)   // 배열 list에 있는 n개 원소에 대해서 기수 정렬을 수행하는 연산을 수행.
{
	int i, bucket, d, factor = 1;
	LQueueType *Q[RADIX];           // 정렬할 자료의 기수, 즉 RADIX에 따라 10개의 버킷을 큐로 생성.
	for (bucket = 0; bucket < RADIX; bucket++)
		Q[bucket] = createLinkedQueue();

	for (d = 0; d < DIGIT; d++) {   // 키값의 자릿수만큼, 즉 두 번 기수 정렬을 반복 수행.
		for (i = 0; i < n; i++)     // 키값의 1의 자리에 대한 버킷을 찾아 원소를 저장. (enQueue)
									// 키값의 10의 자리에 대한 버킷을 찾아 원소를 저장. (enQueue)
			enQueue(Q[(list[i] / factor) % 10], list[i]);
		for (bucket = 0, i = 0; bucket < RADIX; bucket++)  // 버킷 0 부터 커빗 9 까지 저장된 원소를 순서대로 꺼내어 (deQueue) 배열 list에 저장.
			while (!isEmpty(Q[bucket])) list[i++] = deQueue(Q[bucket]);
		printf("\n\n%d 단계: \n\t", d + 1);                // 1의 자리에 대하여 기수 정렬이 끝난 현재 상태를 출력.
														   // 10의 자리에 대하여 기수 정렬이 끝난 현재 상태를 출력.
		for (i = 0; i < n; i++) printf("%d  ", list[i]);   

		factor = factor * 10;                              // 10의 자리에 대해 기수 정렬을 반복하기 위해서 factor를 10으로 수정하고 74 ~83 열 반복
		}
}

void main() {

	int list[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };
	int size = 8;

	printf("**기수정렬 (Radix Sort)\n");                // 기수정렬에 대하여
	printf("분배방식의 정렬방법으로 정렬할 원소의 키값에 해당하는 버킷(Buket)에 원소를\n분배하였다가 버킷의 순서대로 원소를 꺼내는 방법을 반복 \n\n");
	printf("- 원소의 키를 표현하는 값의 기수 (Radix) 만큼의 버킷이 필요 \n\n");
	printf("- 키값의 자릿수만큼 기수 정렬을 반복 \n\n");
	printf("- 일의 자리, 십의자리, 백의 자리에 대한 순서로 기수정렬 수행 \n\n\n");
	printf("<<<<<<<기수정렬 수행>>>>>>>");
	radixSort(list, size);                               // 기수정렬 함수호출

	getchar();

}
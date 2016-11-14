#include "Queue.h"

void InitQueue(Queue *queue, int qsize) //큐 초기화
{
	queue->buf = (int *)malloc(sizeof(int)*qsize); //큐를 동적으로 저장소 생성
	queue->qsize = qsize;
	queue->front = queue->rear = 0; //front와 rear를 0으로 설정
	queue->count = 0;//보관 개수를 0으로 설정
}
int IsFull(Queue *queue) //큐가 꽉 찼는지 확인하는 함수
{
	return queue->count == queue->qsize;//보관 개수가 qsize와 같으면 꽉 찬 상태
}
int IsEmpty(Queue *queue) //큐가 비었는지 확인하는 함수
{
	return queue->count == 0;    //보관 개수가 0이면 빈 상태
}
void Enqueue(Queue *queue, int data) //큐에 데이터 삽입 함수
{
	if (IsFull(queue))//큐가 꽉 찼을 때
	{
		printf("큐가 꽉 찼음\n");
		return;
	}
	queue->buf[queue->rear] = data;//rear 인덱스에 데이터 보관
	queue->rear = NEXT(queue->rear, queue->qsize); //rear를 다음 위치로 설정
	queue->count++;//보관 개수를 1 증가
}
int Dequeue(Queue *queue) //큐에 데이터 삭제함수
{
	int re = 0;
	if (IsEmpty(queue))//큐가 비었을 때
	{
		printf("큐가 비었음\n");
		return re;
	}
	re = queue->buf[queue->front];//front 인덱스에 보관한 값을 re에 설정
	queue->front = NEXT(queue->front, queue->qsize);//front를 다음 위치로 설정
	queue->count--;//보관 개수를 1 감소
	return re;
}
void DisposeQueue(Queue *queue) //큐 해제화 함수
{
	free(queue->buf);
}
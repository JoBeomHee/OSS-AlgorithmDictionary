#include "Queue.h"

void InitQueue(Queue *queue, int qsize) //ť �ʱ�ȭ
{
	queue->buf = (int *)malloc(sizeof(int)*qsize); //ť�� �������� ����� ����
	queue->qsize = qsize;
	queue->front = queue->rear = 0; //front�� rear�� 0���� ����
	queue->count = 0;//���� ������ 0���� ����
}
int IsFull(Queue *queue) //ť�� �� á���� Ȯ���ϴ� �Լ�
{
	return queue->count == queue->qsize;//���� ������ qsize�� ������ �� �� ����
}
int IsEmpty(Queue *queue) //ť�� ������� Ȯ���ϴ� �Լ�
{
	return queue->count == 0;    //���� ������ 0�̸� �� ����
}
void Enqueue(Queue *queue, int data) //ť�� ������ ���� �Լ�
{
	if (IsFull(queue))//ť�� �� á�� ��
	{
		printf("ť�� �� á��\n");
		return;
	}
	queue->buf[queue->rear] = data;//rear �ε����� ������ ����
	queue->rear = NEXT(queue->rear, queue->qsize); //rear�� ���� ��ġ�� ����
	queue->count++;//���� ������ 1 ����
}
int Dequeue(Queue *queue) //ť�� ������ �����Լ�
{
	int re = 0;
	if (IsEmpty(queue))//ť�� ����� ��
	{
		printf("ť�� �����\n");
		return re;
	}
	re = queue->buf[queue->front];//front �ε����� ������ ���� re�� ����
	queue->front = NEXT(queue->front, queue->qsize);//front�� ���� ��ġ�� ����
	queue->count--;//���� ������ 1 ����
	return re;
}
void DisposeQueue(Queue *queue) //ť ����ȭ �Լ�
{
	free(queue->buf);
}
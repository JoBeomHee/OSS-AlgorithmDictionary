/*
큐는 순차적으로 자료를 보관하고 가장 최근에 보관한 자료를 꺼내는(FIFO, First In First Out) 버퍼입니다.

여기에서는 버퍼의 크기가 정적인 배열로 정의하는 것을 먼저 구현할 겁니다.

배열로 큐를 정의할 때 자료를 보관하는 버퍼 외에 자료를 보관할 위치와 꺼낼 인덱스를 기억하고 있습니다.
보관할 위치는 맨 뒤에 보관해서 rear라고 부르고 꺼낼 위치는 맨 앞이어서 front라 부릅니다.
그리고 큐에 자료를 보관하는 행위를 EnQueue 혹은 Put이라 부릅니다.
큐에서 자료를 꺼내는 행위는 DeDueue 혹은 Get이라 부릅니다.
그리고 배열로 큐를 구현할 때는 큐가 비었는지 혹은 꽉 찼는지 확인할 수 있는 기능을 제공합니다.

다음은 배열로 구현한 원형 큐입니다.
원형 큐는 맨 뒤에 보관한 다음 다시 앞에 보관하는 큐를 말합니다.
이와 같이 보관하면 큐가 꽉 찼을 때와 비었을 때 구분하지 못하는 문제가 있습니다.
이를 해결하는 방법 중에 rear 다음이 front일 때 꽉 찬 것으로 취급하는 방법이 있습니다.
여기에서는 이 방법을 사용하여 구현했습니다.
우리는 원형큐를 가지고 큐를 구현하겠습니다.
*/
#pragma once

//원형 큐 - 버퍼 공간을 동적으로 생성, 정수 보관

#include <stdio.h>
#include <stdlib.h>

#define NEXT(index,QSIZE)   ((index+1)%QSIZE)  //원형 큐에서 인덱스를 변경하는 매크로 함수

typedef struct Queue //Queue 구조체 정의
{
	int *buf;//저장소
	int qsize;
	int front; //꺼낼 인덱스(가장 오래전에 보관한 데이터가 있는 인덱스)
	int rear;//보관할 인덱스
	int count;//보관 개수

}Queue;

void InitQueue(Queue *queue, int qsize);//큐 초기화
int IsFull(Queue *queue); //큐가 꽉 찼는지 확인
int IsEmpty(Queue *queue); //큐가 비었는지 확인
void Enqueue(Queue *queue, int data); //큐에 보관
int Dequeue(Queue *queue); //큐에서 꺼냄
void DisposeQueue(Queue *queue);//큐 해제화

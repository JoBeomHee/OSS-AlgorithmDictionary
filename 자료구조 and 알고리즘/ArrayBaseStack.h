#pragma once
#ifndef __AB_STACK_H__
#define __AB_STACK_H__

#define TRUE 1
#define FALSE 0
#define STACK_LEN 100 //���� ���� �迭����뷮

typedef int Data;

typedef struct _arrayStack
{
	Data stackArr[STACK_LEN];
	int topIndex; //topIndex = -1 �� �ʱ�ȭ�Ѵ�.
}ArrayStack;

typedef ArrayStack Stack;

void StackInit(Stack *pstack); //������ �ʱ�ȭ
int SIsEmpty(Stack *pstack); //������ ������� Ȯ��

void SPush(Stack *pstack, Data data); //������ push ����
Data SPop(Stack *pstack); //������ pop ����
Data SPeek(Stack *pstack); //������ peek ����

#endif


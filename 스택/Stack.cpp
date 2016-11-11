/*������ ���� ���ؼ� '�׾� �÷��� ���ڴ���' �� '��� ���� ���� ����' �� �ƴұ� �����մϴ�.
��, ������ ������ ������ ������ �շ��ִ� ���ں� �뿡 ������ �� �ֽ��ϴ�. �׸��� �̷��� ���ʸ�
�ո��� ���� ������ ���� Ư���� ���ϰ� �ȴ�.
"���� �� ���� ���߿� ���´�!"
��, ������ ���߿� �� ���� ���� ������ �����̴� ���� '���Լ��� ����� �ڷᱸ��' ��� �Ҹ���
����� LIFO(Last-In, First-Out)������ �ڷᱸ�� ��� �Ҹ���.
*/

#include <stdio.h>
#include <stdlib.h>
#include "ArrayBaseStack.h"

void StackInit(Stack *pstack) //������ �ʱ�ȭ
{
	pstack->topIndex = -1; // topIndex �� -1 �� ������ �� ���¸� �ǹ��Ѵ�.
}
int SIsEmpty(Stack *pstack) //������ ������� Ȯ��
{
	if (pstack->topIndex == -1) //������ ����ִٸ�
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

void SPush(Stack *pstack, Data data) //������ push ����
{
	pstack->topIndex += 1; //������ �߰��� ���� �ε��� �߰�
	pstack->stackArr[pstack->topIndex] = data; //�߰� �� �ε����� �����͸� ����
}
Data SPop(Stack *pstack) //������ pop ����
{
	int index = 0;
	if (SIsEmpty(pstack)) //������ ����ٸ� ���̻� ������ �����Ͱ� ����.
	{
		printf("Stack Memory Error!"); // �޸� Error ǥ��
		exit(-1);
	}

	index = pstack->topIndex; //������ �����Ͱ� ����� �ε��� �� ����
	pstack->topIndex -= 1; //pop ������ ����� topIndex�� 1 ����
	return pstack->stackArr[index]; //�����Ǵ� �����Ͱ� ��ȯ
}
Data SPeek(Stack *pstack) //������ peek ����
{
	if (SIsEmpty(pstack))
	{
		printf("Stack Memory Error!");
		exit(-1);
	}
	return pstack->stackArr[pstack->topIndex]; //�� ���� ����� ������ �����͸� ��ȯ
}
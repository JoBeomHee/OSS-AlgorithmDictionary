#pragma once
#include <stdio.h>
#include <stdlib.h>

typedef struct Node//��� ����
{
	int data;
	struct Node *lchild;
	struct Node *rchild;
}Node;

typedef Node *Tree;//Ʈ�� ���ĸ� ����

Node *NewNode(int data);//��� ����
void InitTree(Tree *bst);//Ʈ�� �ʱ�ȭ
int AddData(Tree *bst, int data); //������ ����
void Preorder(Node *sr);//���� ���� ����
void Inorder(Node *sr);//���� ���� ����
void Postorder(Node *sr);//���� ���� ����
void ClearTree(Tree *bst);//Ʈ�� ����

Node *NewNode(int data)
{
	Node *now = (Node *)malloc(sizeof(Node));
	now->data = data;
	now->lchild = now->rchild = NULL;
	return now;
}

void InitTree(Tree *bst)
{
	*bst = NULL;
}

int AddData(Tree *bst, int data)
{
	Node *seek = *bst;
	int gap = 0;
	if (seek == NULL)
	{
		(*bst) = NewNode(data);
		return 1;//���� ���� ��ȯ
	}
	while (1)
	{
		gap = seek->data - data;
		if (gap == 0)//�̹� ���� ���� �����͸� ��������
		{
			return 0;//���� ���� ��ȯ
		}
		if (gap>0)//���� �����Ͱ� Ŭ ��(�� �����Ͱ� ���� ��)
		{
			if (seek->lchild)//���ʿ� �ڽ��� �̹� ������
			{
				seek = seek->lchild;//seek�� ���� �ڽ����� ����
			}
			else
			{
				seek->lchild = NewNode(data);//���� �ڽ����� ���ο� ��带 ����
				return 1;//���� ���� ��ȯ
			}
		}
		else//���� �����Ͱ� ���� ��(�� �����Ͱ� Ŭ ��)
		{
			if (seek->rchild)//�����ʿ� �ڽ��� �̹� ������
			{
				seek = seek->rchild;//seek�� ������ �ڽ����� ����
			}
			else
			{
				seek->rchild = NewNode(data);//������ �ڽ����� ���ο� ��带 ����
				return 1;//���� ���� ��ȯ
			}
		}

	}
	return 1;
}
void Preorder(Node *sr)//���� ���� ����
{
	if (sr)
	{
		printf("%d ", sr->data);
		Preorder(sr->lchild);
		Preorder(sr->rchild);
	}
}
void Inorder(Node *sr)//���� ���� ����
{
	if (sr)
	{
		Inorder(sr->lchild);
		printf("%d ", sr->data);
		Inorder(sr->rchild);
	}
}
void Postorder(Node *sr)//���� ���� ����
{
	if (sr)
	{
		Postorder(sr->lchild);
		Postorder(sr->rchild);
		printf("%d ", sr->data);
	}
}
void Dispose(Node *sr);
void ClearTree(Tree *bst)
{
	Dispose(*bst);
	*bst = 0;
}
void Dispose(Node *sr)//���� ������ ����
{
	if (sr)
	{
		Dispose(sr->lchild);
		Dispose(sr->rchild);
		free(sr);
	}
}
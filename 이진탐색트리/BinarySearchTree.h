#include <stdio.h>
#include <stdlib.h>

typedef struct Node//��� ����
{
	int data;
	struct Node *left;
	struct Node *right;
} Node;

typedef Node *Tree;//Ʈ�� ���ĸ� ����

Node *NewNode(int data);//��� ����
void InitTree(Tree *tree);//Ʈ�� �ʱ�ȭ
int InsertNode(Tree *tree, int data); //��� ����
void Preorder(Node *node);//���� ��ȸ ����
void Inorder(Node *node);//���� ��ȸ ����
void Postorder(Node *node);//���� ��ȸ ����
void Dispose(Node *node);//����ȭ
void ClearTree(Tree *tree);//Ʈ�� ����

void InitTree(Tree *tree)//Ʈ�� �ʱ�ȭ
{
	*tree = NULL;
}

Node *NewNode(int data)//��� ����
{
	Node *now = (Node *)malloc(sizeof(Node));
	now->data = data;
	now->left = now->right = NULL;
	return now;
}

int InsertNode(Tree *tree, int data) //��� ����
{
	Node *seek = *tree;
	if (seek == NULL) // �ʱ��� ����
	{
		(*tree) = NewNode(data);
		return 1;
	}
	while (1)
	{
		if (seek->data == data) // ������ ����
		{
			return 0; //���� ����
		}
		if (seek->data > data) // �������� �� Ŭ��
		{
			if (seek->left) //���ʿ� �ڽ��� �̹� ������
			{
				seek = seek->left; //seek�� ���� �ڽ����� ����
			}
			else
			{
				seek->left = NewNode(data); //���� �ڽ����� ���ο� ��带 ����
				return 1; //���� ����
			}
		}
		else //���� �����Ͱ� ���� ��
		{
			if (seek->right) //�����ʿ� �ڽ��� �̹� ������
			{
				seek = seek->right; //seek�� ������ �ڽ����� ����
			}
			else
			{
				seek->right = NewNode(data); //������ �ڽ����� ���ο� ��带 ����
				return 1; //���� ����
			}
		}

	}
	return 1;
}
void Preorder(Node *node)//���� ��ȸ ����
{
	if (node)
	{
		printf("%d ", node->data);
		Preorder(node->left);
		Preorder(node->right);
	}
}
void Inorder(Node *node)//���� ��ȸ ����
{
	if (node)
	{
		Inorder(node->left);
		printf("%d ", node->data);
		Inorder(node->right);
	}
}
void Postorder(Node *node)//���� ��ȸ ����
{
	if (node)
	{
		Postorder(node->left);
		Postorder(node->right);
		printf("%d ", node->data);
	}
}

void Dispose(Node *node)//����ȭ
{
	if (node)
	{
		Dispose(node->left);
		Dispose(node->right);
		free(node);
	}
}

void ClearTree(Tree *tree) //Ʈ�� ����
{
	Dispose(*tree);
	*tree = 0;
}
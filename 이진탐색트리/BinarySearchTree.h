#include <stdio.h>
#include <stdlib.h>

typedef struct Node//노드 정의
{
	int data;
	struct Node *left;
	struct Node *right;
} Node;

typedef Node *Tree;//트리 형식명 정의

Node *NewNode(int data);//노드 생성
void InitTree(Tree *tree);//트리 초기화
int InsertNode(Tree *tree, int data); //노드 삽입
void Preorder(Node *node);//전위 순회 운행
void Inorder(Node *node);//중위 순회 운행
void Postorder(Node *node);//후위 순회 운행
void Dispose(Node *node);//해제화
void ClearTree(Tree *tree);//트리 해제

void InitTree(Tree *tree)//트리 초기화
{
	*tree = NULL;
}

Node *NewNode(int data)//노드 생성
{
	Node *now = (Node *)malloc(sizeof(Node));
	now->data = data;
	now->left = now->right = NULL;
	return now;
}

int InsertNode(Tree *tree, int data) //노드 삽입
{
	Node *seek = *tree;
	if (seek == NULL) // 초기노드 삽입
	{
		(*tree) = NewNode(data);
		return 1;
	}
	while (1)
	{
		if (seek->data == data) // 같은값 존재
		{
			return 0; //삽입 실패
		}
		if (seek->data > data) // 기존값이 더 클때
		{
			if (seek->left) //왼쪽에 자식이 이미 있으면
			{
				seek = seek->left; //seek를 왼쪽 자식으로 설정
			}
			else
			{
				seek->left = NewNode(data); //왼쪽 자식으로 새로운 노드를 설정
				return 1; //삽입 성공
			}
		}
		else //기존 데이터가 작을 때
		{
			if (seek->right) //오른쪽에 자식이 이미 있으면
			{
				seek = seek->right; //seek를 오른쪽 자식으로 설정
			}
			else
			{
				seek->right = NewNode(data); //오른쪽 자식으로 새로운 노드를 설정
				return 1; //삽입 성공
			}
		}

	}
	return 1;
}
void Preorder(Node *node)//전위 순회 운행
{
	if (node)
	{
		printf("%d ", node->data);
		Preorder(node->left);
		Preorder(node->right);
	}
}
void Inorder(Node *node)//중위 순회 운행
{
	if (node)
	{
		Inorder(node->left);
		printf("%d ", node->data);
		Inorder(node->right);
	}
}
void Postorder(Node *node)//후위 순회 운행
{
	if (node)
	{
		Postorder(node->left);
		Postorder(node->right);
		printf("%d ", node->data);
	}
}

void Dispose(Node *node)//해제화
{
	if (node)
	{
		Dispose(node->left);
		Dispose(node->right);
		free(node);
	}
}

void ClearTree(Tree *tree) //트리 해제
{
	Dispose(*tree);
	*tree = 0;
}
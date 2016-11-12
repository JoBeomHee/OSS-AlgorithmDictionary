#include <stdio.h>
#include <stdlib.h>

// ����Ž��Ʈ��
typedef struct Node
{
	int Data;
	struct Node* Left;
	struct Node* Right;
} Node;

Node* createNode(int data)  // ������
{
	Node* newNode = (Node*)malloc(sizeof(Node));
	newNode->Left = NULL;
	newNode->Right = NULL;
	newNode->Data = data;

	return newNode;
}

Node* searchNode(Node* Tree, int findData)   //���Ž��
{
	if (Tree == NULL) return NULL;
	if (Tree->Data == findData)
		return Tree;
	else if (Tree->Data > findData)
		searchNode(Tree->Left, findData);
	else
		searchNode(Tree->Right, findData);
}

void insertNode(Node* Tree, Node* newNode)  //������
{
	if (newNode->Data > Tree->Data)
	{
		if (Tree->Right != NULL) insertNode(Tree->Right, newNode);
		else Tree->Right = newNode;
	}
	else if (newNode->Data < Tree->Data)
	{
		if (Tree->Left != NULL) insertNode(Tree->Left, newNode);
		else Tree->Left = newNode;
	}
}

Node* findMinNode(Node* Tree)
{
	if (Tree == NULL) return NULL;
	if (Tree->Left != NULL) return findMinNode(Tree->Left);
	else return Tree;
}

Node* removeNode(Node* Tree, int data)  // ������
{
	Node* tempNode;

	if (Tree == NULL) printf("�ش��ϴ� ��带 ã�� �� �����ϴ�.\n");
	else if (Tree->Data > data) Tree->Left = removeNode(Tree->Left, data);
	else if (Tree->Data < data) Tree->Right = removeNode(Tree->Right, data);
	else
	{
		if (Tree->Left != NULL && Tree->Right != NULL)
		{
			tempNode = findMinNode(Tree->Right);
			Tree->Data = tempNode->Data;

			Tree->Right = removeNode(Tree->Right, tempNode->Data);
		}
		else
		{
			tempNode = Tree;
			if (Tree->Left == NULL) Tree = Tree->Right;
			else if (Tree->Right == NULL) Tree = Tree->Left;
			free(tempNode);
		}
	}

	return Tree;
}

void printTree(Node* Tree)
{
	if (Tree == NULL) return;
	printTree(Tree->Left);
	printf("%d ", Tree->Data);
	printTree(Tree->Right);
}

int main()
{
	Node* Tree = createNode(10);
	Node* findNode;
	int input;

	insertNode(Tree, createNode(5));
	insertNode(Tree, createNode(1));
	insertNode(Tree, createNode(6));
	insertNode(Tree, createNode(17));
	insertNode(Tree, createNode(14));
	insertNode(Tree, createNode(21));

	while (1)
	{
		scanf("%d", &input);
		findNode = searchNode(Tree, input);

		if (findNode != NULL)
		{
			printf("�ش� ��带 ã�ҽ��ϴ�! ��带 �����մϴ�. ����� ��ġ�� %x �Դϴ�.\n", findNode);
			removeNode(Tree, input);
			printf("���� Ʈ�� ���: ");
			printTree(Tree); printf("\n");
		}
		else printf("��带 ã�� �� �������ϴ�.\n");

	}
	return 0;
}
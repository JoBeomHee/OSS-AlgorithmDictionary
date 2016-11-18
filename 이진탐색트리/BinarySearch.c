#define _CRT_SECURE_NO_WARNINGS
#include"BinarySearchTree.h"
//이진탐색트리

int main(void)
{
	Tree tree;
	int menu;
	int data;
	InitTree(&tree);//트리 초기화

	printf("이진트리 예제\n\n");
	printf("전위 순회는 뿌리->왼쪽 자식->오른쪽 자식 순\n");
	printf("중위 순회는 왼쪽자식-> 뿌리-> 오른쪽 자식 순\n");
	printf("후위 순회는 왼쪽자식->오른쪽 자식-> 뿌리 순\n\n");

	printf("삽입순서: 10 6 9 5 15 25 3 19 14\n");
	InsertNode(&tree, 10);
	InsertNode(&tree, 6);
	InsertNode(&tree, 9);
	InsertNode(&tree, 5);
	InsertNode(&tree, 15);
	InsertNode(&tree, 25);
	InsertNode(&tree, 3);
	InsertNode(&tree, 19);
	InsertNode(&tree, 14);

	//트리에 보관한 자료 확인
	printf("========================================\n");
	printf("전위 순회 운행:");
	Preorder(tree);
	printf("\n중위 순회 운행:");
	Inorder(tree);
	printf("\n후위 순회 운행:");
	Postorder(tree);
	printf("\n========================================\n");

	//트리 해제
	ClearTree(&tree);
	printf("\n\n");

	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	InitTree(&tree);//트리 초기화
	while (1)
	{
		printf("1. 노드삽입  2. 전위순회  3. 중위순회  4. 후위순회  5. 종료\n");
		printf("메뉴선택: ");
		scanf("%d", &menu);
		switch (menu)
		{
		case 1 :
			printf("삽입하고자 하는 수: ");
			scanf("%d", &data);
			InsertNode(&tree, data);
			system("pause");
			system("cls");
			break;
		case 2:
			printf("전위 순회 운행:");
			Preorder(tree);
			system("pause");
			system("cls");
			break;
		case 3:
			printf("\n중위 순회 운행:");
			Inorder(tree);
			system("pause");
			system("cls");
			break;
		case 4:
			printf("\n후위 순회 운행:");
			Postorder(tree);
			system("pause");
			system("cls");
			break;
		case 5:
			printf("종료합니다.\n");
			return 0;
		}
	}
	//트리 해제
	ClearTree(&tree);
	printf("\n");
}
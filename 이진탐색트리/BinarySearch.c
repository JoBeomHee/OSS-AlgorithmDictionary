#define _CRT_SECURE_NO_WARNINGS
#include"BinarySearchTree.h"
//����Ž��Ʈ��

int main(void)
{
	Tree tree;
	int menu;
	int data;
	InitTree(&tree);//Ʈ�� �ʱ�ȭ

	printf("����Ʈ�� ����\n\n");
	printf("���� ��ȸ�� �Ѹ�->���� �ڽ�->������ �ڽ� ��\n");
	printf("���� ��ȸ�� �����ڽ�-> �Ѹ�-> ������ �ڽ� ��\n");
	printf("���� ��ȸ�� �����ڽ�->������ �ڽ�-> �Ѹ� ��\n\n");

	printf("���Լ���: 10 6 9 5 15 25 3 19 14\n");
	InsertNode(&tree, 10);
	InsertNode(&tree, 6);
	InsertNode(&tree, 9);
	InsertNode(&tree, 5);
	InsertNode(&tree, 15);
	InsertNode(&tree, 25);
	InsertNode(&tree, 3);
	InsertNode(&tree, 19);
	InsertNode(&tree, 14);

	//Ʈ���� ������ �ڷ� Ȯ��
	printf("========================================\n");
	printf("���� ��ȸ ����:");
	Preorder(tree);
	printf("\n���� ��ȸ ����:");
	Inorder(tree);
	printf("\n���� ��ȸ ����:");
	Postorder(tree);
	printf("\n========================================\n");

	//Ʈ�� ����
	ClearTree(&tree);
	printf("\n\n");

	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	InitTree(&tree);//Ʈ�� �ʱ�ȭ
	while (1)
	{
		printf("1. ������  2. ������ȸ  3. ������ȸ  4. ������ȸ  5. ����\n");
		printf("�޴�����: ");
		scanf("%d", &menu);
		switch (menu)
		{
		case 1 :
			printf("�����ϰ��� �ϴ� ��: ");
			scanf("%d", &data);
			InsertNode(&tree, data);
			system("pause");
			system("cls");
			break;
		case 2:
			printf("���� ��ȸ ����:");
			Preorder(tree);
			system("pause");
			system("cls");
			break;
		case 3:
			printf("\n���� ��ȸ ����:");
			Inorder(tree);
			system("pause");
			system("cls");
			break;
		case 4:
			printf("\n���� ��ȸ ����:");
			Postorder(tree);
			system("pause");
			system("cls");
			break;
		case 5:
			printf("�����մϴ�.\n");
			return 0;
		}
	}
	//Ʈ�� ����
	ClearTree(&tree);
	printf("\n");
}
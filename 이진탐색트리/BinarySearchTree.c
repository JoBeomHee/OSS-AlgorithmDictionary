//���� Ž�� Ʈ��
#include"BinarySearch.h"

int main()
{
	Tree tree;

	InitTree(&tree);//Ʈ�� �ʱ�ȭ

					//Ʈ���� �ڷ� ����
	AddData(&tree, 10);
	AddData(&tree, 6);
	AddData(&tree, 9);
	AddData(&tree, 5);
	AddData(&tree, 15);
	AddData(&tree, 25);
	AddData(&tree, 3);
	AddData(&tree, 19);
	AddData(&tree, 14);

	//Ʈ���� ������ �ڷ� Ȯ��
	printf("���� ���� ����:");
	Preorder(tree);
	printf("\n���� ���� ����:");
	Inorder(tree);
	printf("\n���� ���� ����:");
	Postorder(tree);

	//Ʈ�� ����
	ClearTree(&tree);
	printf("\n");

	return 0;
}

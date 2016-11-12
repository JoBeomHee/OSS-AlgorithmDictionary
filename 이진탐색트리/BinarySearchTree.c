//이진 탐색 트리
#include"BinarySearch.h"

int main()
{
	Tree tree;

	InitTree(&tree);//트리 초기화

					//트리에 자료 보관
	AddData(&tree, 10);
	AddData(&tree, 6);
	AddData(&tree, 9);
	AddData(&tree, 5);
	AddData(&tree, 15);
	AddData(&tree, 25);
	AddData(&tree, 3);
	AddData(&tree, 19);
	AddData(&tree, 14);

	//트리에 보관한 자료 확인
	printf("전위 순위 운행:");
	Preorder(tree);
	printf("\n중위 순위 운행:");
	Inorder(tree);
	printf("\n후위 순위 운행:");
	Postorder(tree);

	//트리 해제
	ClearTree(&tree);
	printf("\n");

	return 0;
}

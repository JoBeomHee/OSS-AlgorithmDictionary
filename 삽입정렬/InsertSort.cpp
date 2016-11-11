#include <stdio.h>
#include <stdlib.h>


void insertionSort(int list[], int Size);   // �������� �Լ� ����

void insertionSort(int list[], int Size) {  // �������� �Լ�

	int i, j, sort, temp;

	printf("\n������ ���� : ");

	for (sort = 0; sort < Size; sort++) {   //list�迭 ���� �����ϰ��� �ϴ� ���ҵ� ���
		printf("%3d", list[sort]);
	}

	printf("\n\n<<<<<<<<<<<<< �������� ���� >>>>>>>>>>>>>>>\n");

	for (i = 1; i < Size; i++) {

		temp = list[i];
		j = i;
		while ((j > 0) && (list[j - 1] > temp)) {
			list[j] = list[j - 1];
			j = j - 1;
		}

		list[j] = temp;
		printf("\n%d �ܰ� : ", i);
		for (sort = 0; sort <Size; sort++) printf("%3d", list[sort]);

	}

}

void main() {

	int List[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };
	int Size = sizeof(List) / sizeof(List[0]);



	printf("**�������� (Insert Sort)\n");
	printf("���ĵǾ��ִ� �κ����տ� ������ ���ο� ������ ��ġ�� ã�� �����ϴ� ��� \n\n");

	insertionSort(List, Size);
	getchar();

	system("pause");

}

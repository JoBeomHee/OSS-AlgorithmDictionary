#include <stdio.h>
#include <stdlib.h>

int size;

void insertionSort(int list[], int size);   // �������� �Լ� ����

void insertionSort(int list[], int size) {

	int i, j, sort, temp;
	printf("\n������ ���� : ");
	for (sort = 0; sort < size; sort++) printf("%3d", list[sort]);
	printf("\n\n<<<<<<<<<<<<< �������� ���� >>>>>>>>>>>>>>>\n");

	for (i = 1; i < size; i++) {

		temp = list[i];
		j = i;
		while ((j > 0) && (list[j - 1] > temp)) {
			list[j] = list[j - 1];
			j = j - 1;
		}

		list[j] = temp;
		printf("\n%d �ܰ� : ", i);
		for (sort = 0; sort <size; sort++) printf("%3d", list[sort]);

	}

}

void main() {

	int List[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };
	size = 8;


	printf("**�������� (Insert Sort)\n");
	printf("���ĵǾ��ִ� �κ����տ� ������ ���ο� ������ ��ġ�� ã�� �����ϴ� ��� \n\n");

	insertionSort(List, size);
	getchar();

	system("pause");

}

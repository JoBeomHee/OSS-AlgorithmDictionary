#include <stdio.h>
#include <stdlib.h>

int size;

void insertionSort(int list[], int size);   // 삽입정렬 함수 선언

void insertionSort(int list[], int size) {

	int i, j, sort, temp;
	printf("\n정렬할 원소 : ");
	for (sort = 0; sort < size; sort++) printf("%3d", list[sort]);
	printf("\n\n<<<<<<<<<<<<< 삽입정렬 수행 >>>>>>>>>>>>>>>\n");

	for (i = 1; i < size; i++) {

		temp = list[i];
		j = i;
		while ((j > 0) && (list[j - 1] > temp)) {
			list[j] = list[j - 1];
			j = j - 1;
		}

		list[j] = temp;
		printf("\n%d 단계 : ", i);
		for (sort = 0; sort <size; sort++) printf("%3d", list[sort]);

	}

}

void main() {

	int List[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };
	size = 8;


	printf("**삽입정렬 (Insert Sort)\n");
	printf("정렬되어있는 부분집합에 정렬할 새로운 원소의 위치를 찾아 삽입하는 방법 \n\n");

	insertionSort(List, size);
	getchar();

	system("pause");

}

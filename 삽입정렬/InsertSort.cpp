#include <stdio.h>
#include <stdlib.h>


void insertionSort(int list[], int Size);   // 삽입정렬 함수 선언

void insertionSort(int list[], int Size) {  // 삽입정렬 함수

	int i, j, sort, temp;

	printf("\n정렬할 원소 : ");

	for (sort = 0; sort < Size; sort++) {   //list배열 안의 정렬하고자 하는 원소들 출력
		printf("%3d", list[sort]);
	}

	printf("\n\n<<<<<<<<<<<<< 삽입정렬 수행 >>>>>>>>>>>>>>>\n");

	for (i = 1; i < Size; i++) {

		temp = list[i];
		j = i;
		while ((j > 0) && (list[j - 1] > temp)) {
			list[j] = list[j - 1];
			j = j - 1;
		}

		list[j] = temp;
		printf("\n%d 단계 : ", i);
		for (sort = 0; sort <Size; sort++) printf("%3d", list[sort]);

	}

}

void main() {

	int List[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };
	int Size = sizeof(List) / sizeof(List[0]);



	printf("**삽입정렬 (Insert Sort)\n");
	printf("정렬되어있는 부분집합에 정렬할 새로운 원소의 위치를 찾아 삽입하는 방법 \n\n");

	insertionSort(List, Size);
	getchar();

	system("pause");

}

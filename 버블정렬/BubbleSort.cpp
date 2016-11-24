/*
*버블정렬(Bubble Sort) : 인접한 두 개의 원소를 비교하여 자리를 교환하는 방식

첫 번째 원소부터 마지막 원소까지 반복하면 가장 큰 원소가 마지막 자리에 온다.
첫 번째 원소부터 인접한 원소끼리 계속 자리를 교환하면서 맨 마지막 자리로 이동하는 모습이
물 속에서 물 위로 올라오는 물방울 모양과 같다고 해서 버블정렬이라고 칭함
*/

#include <stdio.h>
#include <stdlib.h>

void bubbleSort(int list[], int Size); // 버블정렬 함수 선언

void bubbleSort(int list[], int Size)  // 버블정렬 함수
{
	int i, j, sort, temp;

	for (sort = 0; sort < Size; sort++) {   // list배열 안의 정렬하고자 하는 원소들 출력
		printf("%3d", list[sort]);
	}
	printf("\n\n<<<<<<<<<<<<< 버블정렬 수행 >>>>>>>>>>>>>>>\n");

	for (i = Size - 1; i >0; i--) {
		printf("\n%d 단계 : ",Size-i);
		for (j = -1; j<i; j++) {            //  첫번째 원소부터 i번 원소까지 반복수행                   for (j = 0; j<=i; j++) 로 나타낼 수 있다 

			if (list[j] > list[j+1]) {      // 인접한 두 개의 원소를 비교하여 자리를 교환                  if (list[j-1] > list[j]) {
				  
				temp = list[j];             //                                                              temp = list[j-1];
				list[j] = list[j+1];        //                                                              list[j-1] = list[j]; 
				list[j+1] = temp;           //                                                              list[j] = temp;
				 
			}                               //                                                               }
			printf("\n\t");
			for (sort = 0; sort <Size; sort++) printf("%3d ", list[sort]); // 정렬의 한 단계별로 결과 출력
		}

	}
}

void main() {


	int List[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };  // 정렬하고자 하는 원소리스트 List
	int Size = sizeof(List) / sizeof(List[0]);        // 전체 배열의 크기를 원소의 크기로 나누면 배열의 크기를 알 수 있다.

	printf("**버블정렬 (Bubble Sort)\n");           // 버블정렬에 대하여
	printf("인접한 두 개의 원소를 비교하여 자리를 교환하는 방식으로 정렬하는 방법 \n\n");

	bubbleSort(List, Size);                      //버블정렬 함수 호출
	getchar();

	system("pause");

}
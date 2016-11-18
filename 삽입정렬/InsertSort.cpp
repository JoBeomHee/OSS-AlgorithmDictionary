#include <stdio.h>
#include <stdlib.h>

void insertionSort(int list[], int Size);   // 삽입정렬 함수 선언

void insertionSort(int list[], int Size) {  // 삽입정렬 함수

	int i, j, sort, temp;          // 변수선언

	printf("\n정렬할 원소 : ");

	for (sort = 0; sort < Size; sort++) {   // list배열 안의 정렬하고자 하는 원소들 출력
		printf("%3d", list[sort]);
	}
	printf("\n\n<<<<<<<<<<<<< 삽입정렬 수행 >>>>>>>>>>>>>>>\n");

	for (i = 1; i < Size; i++) {

		temp = list[i];              // 아직 정렬되지 않은 집합U의 첫 번째 원소 list[i] 즉, 정렬대상 원소를 temp에 저장
		j = i;                       // 정렬 대상 원소의 인덱스 i를 j에 저장
		while ((j > 0) && (list[j - 1] > temp)) {   //정렬된 집합 s의 마지막원소 list[j-1]부터 정렬대상원소 temp와 비교하여
			list[j] = list[j - 1];             // list[j-1] < temp < list[j]인 j를 찾을 때 까지 반복
			j = j - 1;
		}

		list[j] = temp;                           // list[i] 위치에 정렬대상 원소 temp를 저장
		printf("\n%d 단계 : ", i);
		for (sort = 0; sort <Size; sort++) printf("%3d", list[sort]); // 단계별로 결과 출력
	}
}
void main() {

	int List[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };  // 정렬하고자 하는 원소리스트 List
	int Size = sizeof(List) / sizeof(List[0]);        // 전체 배열의 크기를 원소의 크기로 나누면 배열의 크기를 알 수 있다.



	printf("**삽입정렬 (Insert Sort)\n");           // 삽입정렬에 대하여
	printf("정렬되어있는 부분집합에 정렬할 새로운 원소의 위치를 찾아 삽입하는 방법 \n\n");

	insertionSort(List, Size);                      //삽입정렬 함수 호출
	getchar();

	system("pause");

}



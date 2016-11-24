
/*
*퀵정렬(Quick Sort) : 정렬할 전체 원소에 대해서 정렬을 수행하지 않고 기준값을 중심으로 왼쪽 부분집합과 오른쪽 부분집합으로 분할.
왼쪽 부분집합에는 기준값보다 작은 원소들을 이동시키고, 오른쪽 부분집합에는 기준값보다 큰 원소들을 이동시킨다.
이때 사용하는 기준값을 피봇(Pivot)이라고 하는데, 일반적으로 전체 원소 중에서 가운데에 위치한 원소를 피봇으로 선택.

퀵 정렬은 다음의 2가지 기본 작업을 반복 수행하여 완성한다.

(1) 분할(Divide) : 정렬할 자료들을 기준값을 중심으로 2개의 부분집합으로 분할.
(2) 정복(Conquer) : 부분집합의 원소들 중에서 기준값보다 작은 원소들은 왼쪽 부분집합으로, 기준값보다 큰 원소들은 오른쪽 부분집합으로 정렬한다.
부분집합의 크기가 1이하로 충분히 작지 않으면 순환 호출을 이용하여 다시 분할
*/

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int size, i = 0;

int partition(int List[], int begin, int end);
void quickSort(int List[], int begin, int end);



void main() {


	int list[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };   // 정렬하고자 하는 원소리스트 List
	int size = sizeof(list) / sizeof(list[0]);        // 전체 배열의 크기를 원소의 크기로 나누면 배열의 크기를 알 수 있다.

	printf("**퀵정렬 (Quick Sort)\n");                // 퀵정렬에 대하여
	printf("정렬할 전체 원소에 대해서 정렬을 수행하지 않고 기준값을 중심으로 왼쪽 부분집합과 오른쪽 부분집합으로 분할하는 방법 \n\n");

	quickSort(list, 0, size - 1);                      //퀵정렬 함수 호출
	getchar();

	system("pause");

}

int partition(int List[], int begin, int end)     // 부분집합 안에서 피봇의 위치를 찾아 확정하는 연산
{
	int pivot, temp, L, R, sort;                  // 분할 작업을 순환적으로 반복하면서 피봇의 왼쪽 부분집합과 오른쪽 부분집합을 정렬하는 방법으로 전체 원소들을 정렬.
												  // 부분집합으로 분할하기 위해서 L과 R을 사용.

	L = begin;
	R = end;

	pivot = (int)floor((begin + end ) / 2);        // 중간에 위치한 자료를 피봇 원소로 선택
	printf("\n [%d단계 : pivot =%d]\n", ++i, List[pivot]);

	while (L < R) {
		while ((List[L] <= List[pivot]) && (L <= R)) L++;
		while ((List[R] > List[pivot]) && (L <= R)) R--;

		if (L <= R) {
			temp = List[L];
			List[L] = List[R];
			List[R] = temp;
			if (R == pivot) {                            // L과 R원소를 교환하여, 결과적으로 피봇 원소의 위치가 변경된 경우
				for (sort = 0; sort < size; sort++)
				{
					printf(" %d", List[sort]); // 현재의 정렬 상태 출력
				}
				printf("\n");
				return L;
			}
		}

	}
	//  while (L < R)
	//		(L > R)이 된 경우

		temp = List[pivot];
		List[pivot] = List[R];
		List[R] = temp;
		for (sort = 0; sort < size; sort++) printf(" %d", List[sort]); // 현재의 정렬 상태 출력
		printf("\n");
		return R;
}

void quickSort(int List[], int begin, int end) {

	if (begin < end) {
		int p_operation;
		p_operation = partition(List, begin, end);
		quickSort(List, begin, p_operation-1);                     // 피봇의 왼쪽 부분집합에 대해 퀵 정렬 재귀호출
		quickSort(List, p_operation+1, end);                     // 피봇의 오른쪽 부분집합에 대해 퀵 정렬 재귀호출
	} 
}

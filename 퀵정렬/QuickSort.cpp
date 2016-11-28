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
#include <stdlib.h>먼
#include <math.h>

int size, i = 0;

int partition(int List[], int begin, int end);
void quickSort(int List[], int begin, int end);


void main() {


	int list[8] = { 69, 10, 30, 2, 16, 8, 31, 22 };   // 정렬하고자 하는 원소리스트 List
	int size = sizeof(list) / sizeof(list[0]);        // 전체 배열의 크기를 원소의 크기로 나누면 배열의 크기를 알 수 있다.

	printf("**퀵정렬 (Quick Sort)\n");                // 퀵정렬에 대하여
	printf("정렬할 전체 원소에 대해서 정렬을 수행하지 않고 기준값을 중심으로 왼쪽 부분집합과오른쪽 부분집합으로 분할하는 방법 \n\n");

	printf("\n정렬할 원소\n");
	for (i = 0; i < size; i++) {   // list배열 안의 정렬하고자 하는 원소들 출력
		printf("%3d", list[i]);
	}
	printf("\n");

	quickSort(list, 0, size - 1);                      //퀵정렬 함수 호출

	printf("\n => 정렬 후 \n");                       //정렬한 후 상태 출력.
	for (int i = 0; i < size; i++) {
		printf("%d ", list[i]);
	}
	printf("\n");
	getchar();

}

int partition(int List[], int begin, int end)     // 부분집합 안에서 피봇의 위치를 찾아 확정하는 연산
{
	int pivot, temp, L, R, sort;                  // 분할 작업을 순환적으로 반복하면서 피봇의 왼쪽 부분집합과 오른쪽 부분집합을 정렬하는 방법으로 전체 원소들을 정렬.
												  // 부분집합으로 분할하기 위해서 L과 R을 사용.

	L = begin;
	R = end;

	pivot = (int)floor((begin + end) / 2);        // 중간에 위치한 자료를 피봇 원소로 선택
	
	printf("\n [ pivot =%d]\n", List[pivot]);
	
	while (L < R) {
		while ((List[L] <= List[pivot]) && (L <= R)) L++; // List[L]이 List[pivot]보다 작거나 같고 L이 R보다 작거나 같을동안 L을 증가.
		                                                  // 즉, pivot원소보다 같거나 큰 원소를 찾을 때 까지 또는 L과 R이 만날 때 까지 L을
		                                                  // 왼쪽에서 오른쪽 으로 이동.

		while ((List[R] > List[pivot]) && (L <= R)) R--;  // List[R]이 List[pivot]보다 크고 L이 R보다 작거나 같을동안 L을 감소.
														  // 즉, pivot원소보다 작은 원소를 찾을 때 까지 또는 L과 R이 만날 때 까지 R을
														  // 오른쪽에서 왼쪽 으로 이동.

		if (L <= R) {
			temp = List[L];                               // List[L]과 List[R]을 서로 교환
			List[L] = List[R];
			List[R] = temp;

			if (R == pivot) {                           // R과 pivot이 같은 경우 Pivot 원소에 대한 자리교환이 발생하였으므로 pivot의 위치를 확정하고
				for (sort = 0; sort < size; sort++)     
				{
					printf(" %d", List[sort]);          // 현재의 정렬 상태 출력
				}
				printf("\n");
				return L;                               // pivot의 확정된 위치 L을 반환
			}
		}

	}
	//  while (L < R)
	//		(L > R)이 된 경우

	temp = List[pivot];           // List[pivot]과 List[R]을 서로교환
	List[pivot] = List[R];        // Pivot 원소에 대한 자리교환이 발생하였으므로 pivot의 위치를 확정
	List[R] = temp;
	printf("\n");
	return R;                     // pivot의 확정된 위치 R을 반환
}

void quickSort(int List[], int begin, int end) {

	if (begin < end) {            // 배열 List에 대해서 begin부터 end까지를 범위로 하는 부분집합에 대해 
		int p_operation;         
								                    // 퀵 정렬을 수행하기위해 함수호출
		p_operation = partition(List, begin, end);  // 함수수행 후 반환된 R, 즉 새로 확정된 피봇의 자리를 변수 p_operation에 설정

		for (int i = 0; i < 8; i++) {
			printf("%d ", List[i]);
		}
		printf("\n");

		                                                             // 새로 확정된 피봇위치  p_operation 중심으로 새로 생성된 부분집합에 대해 수행
		quickSort(List, begin, p_operation - 1);                     // 피봇의 왼쪽 부분집합에 대해 퀵 정렬 재귀호출
		quickSort(List, p_operation + 1, end);                       // 피봇의 오른쪽 부분집합에 대해 퀵 정렬 재귀호출
	}
}

/*
합병정렬 mergesort

해당 정렬원소가 많을수록 비교 및 삽입연산이 많이 발생.
따라서 그 연산을 최소화하기 위하여 정렬하고자 하는 해당 배열을
하나의 단위로 분할한 후 거꾸로 합병하면서 정렬을 하여
최종적으로 전체 배열의 정렬을 하는 방식

1.분할 : 배열 집합을 하나의 원소 단위로 각각 분할.
2.병합 : 분할된 각각의 원소에 대해 서로의 쌍을 비교하여 sorting후 병합.
3.sorting 과정 :
-> 병합시의 sorting과정 => 우선 병합하려고 하는 크기의 메모리를 할당
-> 두 개의 원소에 대해 각각을 비교하여 할당된 메모리에 집어넣는다.
*/
#include <stdio.h> 
#include <stdlib.h>
#define LEN 9 

void merge_sort(int num[], int start, int end);
void merge(int num[], int start, int mid, int end);
void tracer(int num[], int len);

int main(void) {

	int i = 0;
	int testArr[LEN] = { 69, 10, 30, 2, 16, 8, 31, 22, 10 };
	int size = sizeof(testArr) / sizeof(testArr[0]);        // 전체 배열의 크기를 원소의 크기로 나누면 배열의 크기를 알 수 있다.
	
	printf("**합병정렬 (mergesort)\n");  
		printf("해당 정렬원소가 많을수록 비교 및 삽입연산이 많이 발생. 따라서 그 연산을 최소화\n하기 위하여 정렬하고자 하는 해당 배열을 하나의 단위로 분할한 후 거꾸로 합병하면서 정렬을 하여 최종적으로 전체 배열의 정렬을 하는 방식 \n\n");


	
	printf("\n 입력원소 >>");
	for (i = 0; i < size; i++)printf("%4d", testArr[i]);


	printf("\n\n<<<<<<<<<<<<< 삽입정렬 수행 >>>>>>>>>>>>>>>\n\n");
	merge_sort(testArr, 0, LEN - 1);
	system("pause");
}

void merge_sort(int num[], int start, int end) {  // Array를 두개의 덩어리로 분할
	int median = (start + end) / 2;               // 중간값 설정
	if (start < end) {                            // 덩어리의 원소가 하나일 때까지
		merge_sort(num, start, median);
		merge_sort(num, median + 1, end);         // 각각의 덩어리로 재귀함수 호출 
		merge(num, start, median, end);           // 각각의 덩어리를 묶으면서 정렬
	}
}

void merge(int num[], int start, int median, int end) {
	int i, j, k, m, n;
	int tempArr[LEN]; // 임시로 데이터를 저장할 배열
	i = start;        // 앞의 덩어리의 시작 Index
	j = median + 1;   // 뒤의 덩어리의 시작 Index
	k = start;        // 임시 배열의 시작 Index

	while (i <= median && j <= end) {
		tempArr[k++] = (num[i] > num[j]) ? num[j++] : num[i++];
		             //작은 숫자를 찾아 임시 배열에 넣는다. 어느쪽 덩어리든 Index의 끝에 닿으면 빠져나온다.
	}

	                 // 아직 배열에 속하지 못한 부분들을 넣기 위한 부분
	m = (i > median) ? j : i; // 아직 원소가 남아있는 덩어리가 어디인지 파악
	n = (i > median) ? end : median; // 마찬가지로, for문의 끝 Index를 정하기 위함

	for (; m <= n; m++) {            // 앞에서 구한 m, n으로 배열에 속하지 못한 원소들을 채움
		tempArr[k++] = num[m];
	}

	for (m = start; m <= end; m++) {
		num[m] = tempArr[m];         // 임시 배열에서 원래 배열로 데이터 옮기기
	}
	printf("Merging: %d ~ %d & %d ~ %d\n", start, median, median + 1, end);
	tracer(num, LEN);
}

void tracer(int num[], int len) {
	int i;
	for (i = 0; i<len; i++) {
		printf("%d\t", num[i]);
	}
	printf("\n\n");
}
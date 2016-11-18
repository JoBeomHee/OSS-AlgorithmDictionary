/*
쉘 정렬 (Shell Sort) - Donald L. Shell 이라는 사람이 제안한 방법으로삽입 정렬이 어느 정도 정렬된 배열에 대해서는 
					   빠르다는것에 착안한 방법. 삽입 정렬과는 다르게 전체의 리스트를 한번에 정렬하지 않고
					   먼저 정렬해야할 리스트를 일정한 기준에 따라 분류하여 연속적이지 않은 여러개의 부분 리스트를 만들고,
					   각 부분 리스트를 삽입 정렬을 이용하여 정렬.
					   모든 리스트가 정렬되면 쉘 정렬은 다시 전체 리스트를 더 작은 부분 리스트로 만든 후 알고리즘을 반복. 
					   (리스트의 개수가 1이 될때 까지.)

					   삽입정렬에 비해 좋은점
						1. 교환되는 요소들이 삽입정렬보다 마지막위치에 있을 가능성이 높음.
						2.기본적으로 삽입 정렬을 수행하는 것이지만 빠르게 수행.

*/
#include <stdio.h>

int size;                                 //배열의 크기
int count = 0;                            //비교 횟수를 위한 변수

void intervalSort(int a[], int begin, int end, int interval); //비교 및 정렬함수
void ShellSort(int a[], int size);                            //간격을 나누는 함수

void main()
{
	int list[10] = { 35,67,40,8,2,17,0,10,42,69 };    //배열의 초기
	size = 10;                                       //배열의 크기
	ShellSort(list, size);                          //셀정렬 함수 호출
}

void intervalSort(int a[], int begin, int end, int interval)
{
	int i, j, num;
	for (i = begin + interval; i <= end; i = i + interval) 
	{
		num = a[i];
		for (j = i - interval; j >= begin && num<a[j]; j = j - interval)
		{
			a[j + interval] = a[j];                //앞에 것이 클때
			count++;
		}
		a[j + interval] = num;                   //앞에 것이 작을때
	}
	count++;
}

void ShellSort(int a[], int size)
{
	int i, t, interval;
	for (t = 0; t < size; t++)
		printf("%d \n", a[t]);
	interval = size / 2;                            //간격을 나눔

	while (interval >= 1)
	{
		for (i = 0; i < interval; i++)
			intervalSort(a, i, size - 1, interval); //간격을 나누는 함수 호출
		printf("interval = %d  >> ", interval);

		for (t = 0; t < size; t++)
			printf("%d \n", a[t]);
		interval = interval / 2;
	}
	printf("\n [총 데이터 비교 횟수: %d번 ]\n", count);   //비교횟수 출력
}
/*
버킷정렬 : 키 값의 범위뿐만이 아니라 그 범위 내에서 키 값이 확률적으로
균등하게 분포된다고 가정할 수 있을 때 적용할 수 있는 방법.

키 값이 0과 1 사이라고 가정할때, n개의 키가 구간[0,1]을 n등분하고 각각 하나의 버킷으로함.
각 키를 크기에 따라 각 버킷에 분배한다면, 키가 구간 내에서 균등하게 분포한다 가정했으므로
하나의 버킷에는 하나의 키만 있을 확률이 높음.
만약 한 버킷에 여러 키가 들어가게 된다면 같은 버킷에 속하는 키끼리는 간단한 정렬 알고리즘으로 정렬함.
*/

#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

void BucketSort(int* arr, int n)
{
	int i, j = 0;
	int* count = (int*)malloc(sizeof(int)*n);

	for (i = 0; i < n; i++)	//초기 카운터 설정
		count[i] = 0;

	for (i = 0; i < n; i++)	// 배열 넘버 카운트
		count[arr[i]]++;


	for (i = 0; i < n; i++)	// 배열순서 변경
	{
		for (; count[i] > 0; count[i]--)
		{
			arr[j++] = i;
		}
	}
}
void output(int *arr, int n)
{
	int i;

	for (i = 0; i < n; i++)
	{
		printf("%d\n", arr[i]);
	}
}
int main()
{
	int arr[] = { 54,42,68,56,97,32,43,98,3,11 };
	int n = 10;
	int i;

	output(arr, n);
	BucketSort(arr, n);
	output(arr, n);
	_getch();

	return 0;
}
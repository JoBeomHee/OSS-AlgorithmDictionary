/*
계수정렬 : 항목들의 순서를 결정하기 위해 집합에 각 항목이 몆 개씩 있는지 작업을
		   하면서 선형 시간에 정렬하는 효율적인 알고리즘. 속도가 빠르면서 안정적.
		   시간복잡도 O(n)을 가지는 알고리즘.

제한사항 : 정수나 정수료 표현할 수 있는 자료에 대해서만 동작.
		   카운트들을 위한 충분한 공간을 할당하려면 집합내의 큰 정수를 알아야함.

수행과정 : 1.최대값만큼 배열을 만듬.
		   2.입력받은 값을 세서 만든 배열에 넣고 누적.
		   3.입력받은 배열의 인덱스 값들을 순서대로 배열의 인덱스로 가게함.
		   4.배열의 인덱스의 값을 하나 감소시킨 값을 정렬시킬 배열안에 넣어줌.
*/
#include <stdio.h>
#include <stdlib.h>

void CountingSort(int *array, int n, int min, int max)
{
	int i, j, z;

	int range = max - min + 1;
	int *count = (int *)malloc(range * sizeof(*array));	//최대값 크기만큼 임시 메모리 할당

	for (i = 0; i < range; i++)
		count[i] = 0;
	for (i = 0; i < n; i++)
		count[array[i] - min]++;

	for (i = min, z = 0; i <= max; i++)		//카운트 누적
	{
		for (j = 0; j < count[i - min]; j++)
		{
			array[z++] = i;
		}
	}
	free(count);	//임시 메모리 삭제
}

void Counting_Sort(int *array, int n)
{
	int i, min, max;

	min = max = array[0];
	for (i = 1; i < n; i++)
	{
		if (array[i] < min)
		{
			min = array[i];
		}
		else if (array[i] > max)
		{
			max = array[i];
		}
	}
}
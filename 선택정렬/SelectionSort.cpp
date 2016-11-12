/*
선택정렬의 정의 : 정렬되지 않은 데이터들에 대해 가장 작은 데이터를 찾아 가장 앞의 데이터와 교환해나가는 방식
첫번째 값부터 기준으로 설정, 기준으로 설정된 값과 두 번째 위치,… n 번째위치의 값과 비교하면서 정렬.
가장 작은 값을 찾아서 제일 앞에 놓고, 이 다음 작은 값을 찾아 앞에 놓는 방법을 반복.
가장 먼저 오는 값을 찾아서 제일 앞에 놓음.
다음에 올 수 있는 값을 두 번째에 놓고하는 작업을 반복하여 n개의 값들을 정리.
*/


void SelectionSort(int arr[], int MAX)
{
	int i, j;
	int min, temp;
	for (i=0; i<MAX-1; i++)
	{
		min=i;

		for(j=i+1; j<MAX; j++)
		{
			if (arr[j] < arr[min])
				min = j;
		}

		temp=arr[i];	//스왑
		arr[i]=arr[min];
		arr[min]=temp;
	}
}